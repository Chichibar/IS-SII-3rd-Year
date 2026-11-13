
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace juarenact1
{
    public partial class MainMenu : Form
    {
        private login loginForm;

        public MainMenu(login form)
        {
            InitializeComponent();
            loginForm = form;

            btnAdd.Click += btnAdd_Click;
            btnClear.Click += btnClear_Click;
            dgvProducts.CellClick += dgvProducts_CellClick;
        }

        // LOAD PRODUCTS
        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // READ PRODUCTS

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = Db.GetConnection())
                {
                    string query = @"
                SELECT ProductID, ProductName, Quantity,
                       UnitPrice, Description
                FROM Products";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvProducts.AutoGenerateColumns = true;
                        dgvProducts.DataSource = table;

                        if (dgvProducts.Columns.Contains("ProductID"))
                        {
                            dgvProducts.Columns["ProductID"].Visible = false;
                        }
                    }
                }

                // Refresh dashboard after loading products
                UpdateDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }



        // LOGOUT
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                loginForm.Show();
                this.Close();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                textProductname.Text = row.Cells["ProductName"].Value?.ToString();
                textquantity.Text = row.Cells["Quantity"].Value?.ToString();
                textdescription.Text = row.Cells["Description"].Value?.ToString();
                textunitprice.Text = row.Cells["UnitPrice"].Value?.ToString();
            }
        }


        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check kung may empty fields
            if (string.IsNullOrWhiteSpace(textProductname.Text) ||
                string.IsNullOrWhiteSpace(textquantity.Text) ||
                string.IsNullOrWhiteSpace(textunitprice.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Validate Quantity
            if (!int.TryParse(textquantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Validate Unit Price
            if (!decimal.TryParse(textunitprice.Text, out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Please enter a valid unit price.");
                return;
            }

            try
            {
                using (SqlConnection conn = Db.GetConnection())
                {
                    string query = @"
                INSERT INTO Products
                (ProductName, Quantity, Description, UnitPrice)
                VALUES
                (@ProductName, @Quantity, @Description, @UnitPrice)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", textProductname.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Description", textdescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added successfully!");

                LoadProducts();

                textProductname.Clear();
                textquantity.Clear();
                textdescription.Clear();
                textunitprice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textProductname.Text) ||
                string.IsNullOrWhiteSpace(textquantity.Text) ||
                string.IsNullOrWhiteSpace(textunitprice.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!int.TryParse(textquantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Invalid quantity.");
                return;
            }

            if (!decimal.TryParse(textunitprice.Text, out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Invalid unit price.");
                return;
            }

            int productID = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["ProductID"].Value
            );

            try
            {
                using (SqlConnection conn = Db.GetConnection())
                {
                    string query = @"
                UPDATE Products
                SET ProductName = @ProductName,
                    Quantity = @Quantity,
                    Description = @Description,
                    UnitPrice = @UnitPrice
                WHERE ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", textProductname.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Description", textdescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@ProductID", productID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully!");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        // DELETE

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            int productID = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["ProductID"].Value
            );

            string productName = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete " + productName + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Db.GetConnection())
                    {
                        string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Product deleted successfully!");

                    LoadProducts();

                    textProductname.Clear();
                    textquantity.Clear();
                    textdescription.Clear();
                    textunitprice.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
        }


        // CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            textProductname.Clear();
            textquantity.Clear();
            textdescription.Clear();
            textunitprice.Clear();

            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Temporary event handler
        }

        private void UpdateDashboard()
        {
            try
            {
                using (SqlConnection conn = Db.GetConnection())
                {
                    string query = @"
                SELECT
                    COUNT(*) AS TotalProducts,
                    SUM(CASE WHEN Quantity >= 5 THEN 1 ELSE 0 END) AS InStock,
                    SUM(CASE WHEN Quantity BETWEEN 1 AND 4 THEN 1 ELSE 0 END) AS LowStock,
                    SUM(CASE WHEN Quantity = 0 THEN 1 ELSE 0 END) AS OutStock
                FROM Products";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalproducts.Text = reader["TotalProducts"].ToString();
                                instocks.Text = reader["InStock"].ToString();
                                lowstocks.Text = reader["LowStock"].ToString();
                                outstocks.Text = reader["OutStock"].ToString();
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard Error: " + ex.Message);
            }
        }

    }
}
