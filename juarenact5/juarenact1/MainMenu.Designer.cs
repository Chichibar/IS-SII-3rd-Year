namespace juarenact1
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableInventory = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelinstocks = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labellowstocks = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labeloutstocks = new System.Windows.Forms.Label();
            this.labeltotalproduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textunitprice = new System.Windows.Forms.TextBox();
            this.textquantity = new System.Windows.Forms.TextBox();
            this.textdescription = new System.Windows.Forms.TextBox();
            this.textProductname = new System.Windows.Forms.TextBox();
            this.totalproducts = new System.Windows.Forms.Label();
            this.instocks = new System.Windows.Forms.Label();
            this.lowstocks = new System.Windows.Forms.Label();
            this.outstocks = new System.Windows.Forms.Label();
            this.tableInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(228, 25);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(142, 38);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "WELCOME";
            // 
            // tableInventory
            // 
            this.tableInventory.ColumnCount = 4;
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.22449F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableInventory.Controls.Add(this.label5, 3, 0);
            this.tableInventory.Controls.Add(this.label4, 2, 0);
            this.tableInventory.Controls.Add(this.label1, 0, 0);
            this.tableInventory.Controls.Add(this.label3, 1, 0);
            this.tableInventory.Controls.Add(this.dgvProducts, 0, 1);
            this.tableInventory.Location = new System.Drawing.Point(62, 503);
            this.tableInventory.Name = "tableInventory";
            this.tableInventory.RowCount = 2;
            this.tableInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42282F));
            this.tableInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.57718F));
            this.tableInventory.Size = new System.Drawing.Size(1124, 149);
            this.tableInventory.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(877, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "DESCRIPTION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "UNIT PRICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "QUANTITY";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInventory.SetColumnSpan(this.dgvProducts, 4);
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 23);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1118, 123);
            this.dgvProducts.TabIndex = 7;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.instocks);
            this.panel2.Controls.Add(this.labelinstocks);
            this.panel2.Location = new System.Drawing.Point(328, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // labelinstocks
            // 
            this.labelinstocks.AutoSize = true;
            this.labelinstocks.Location = new System.Drawing.Point(57, 0);
            this.labelinstocks.Name = "labelinstocks";
            this.labelinstocks.Size = new System.Drawing.Size(77, 16);
            this.labelinstocks.TabIndex = 1;
            this.labelinstocks.Text = "IN STOCKS";
            this.labelinstocks.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lowstocks);
            this.panel3.Controls.Add(this.labellowstocks);
            this.panel3.Location = new System.Drawing.Point(642, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 5;
            // 
            // labellowstocks
            // 
            this.labellowstocks.AutoSize = true;
            this.labellowstocks.Location = new System.Drawing.Point(49, 0);
            this.labellowstocks.Name = "labellowstocks";
            this.labellowstocks.Size = new System.Drawing.Size(94, 16);
            this.labellowstocks.TabIndex = 2;
            this.labellowstocks.Text = "LOW STOCKS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.outstocks);
            this.panel4.Controls.Add(this.labeloutstocks);
            this.panel4.Location = new System.Drawing.Point(986, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 5;
            // 
            // labeloutstocks
            // 
            this.labeloutstocks.AutoSize = true;
            this.labeloutstocks.Location = new System.Drawing.Point(51, 0);
            this.labeloutstocks.Name = "labeloutstocks";
            this.labeloutstocks.Size = new System.Drawing.Size(114, 16);
            this.labeloutstocks.TabIndex = 3;
            this.labeloutstocks.Text = "OUT OF STOCKS";
            // 
            // labeltotalproduct
            // 
            this.labeltotalproduct.AutoSize = true;
            this.labeltotalproduct.Location = new System.Drawing.Point(30, 0);
            this.labeltotalproduct.Name = "labeltotalproduct";
            this.labeltotalproduct.Size = new System.Drawing.Size(130, 16);
            this.labeltotalproduct.TabIndex = 0;
            this.labeltotalproduct.Text = "TOTAL PRODUCTS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.totalproducts);
            this.panel1.Controls.Add(this.labeltotalproduct);
            this.panel1.Location = new System.Drawing.Point(62, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.textunitprice);
            this.panel5.Controls.Add(this.textquantity);
            this.panel5.Controls.Add(this.textdescription);
            this.panel5.Controls.Add(this.textProductname);
            this.panel5.Location = new System.Drawing.Point(62, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1124, 254);
            this.panel5.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(924, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(924, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(692, 132);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(692, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "UNIT PRICE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "QUANTITY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "DESCRIPTION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "PRODUCT NAME";
            // 
            // textunitprice
            // 
            this.textunitprice.Location = new System.Drawing.Point(362, 132);
            this.textunitprice.Name = "textunitprice";
            this.textunitprice.Size = new System.Drawing.Size(236, 22);
            this.textunitprice.TabIndex = 3;
            // 
            // textquantity
            // 
            this.textquantity.Location = new System.Drawing.Point(362, 59);
            this.textquantity.Name = "textquantity";
            this.textquantity.Size = new System.Drawing.Size(236, 22);
            this.textquantity.TabIndex = 2;
            // 
            // textdescription
            // 
            this.textdescription.Location = new System.Drawing.Point(33, 132);
            this.textdescription.Multiline = true;
            this.textdescription.Name = "textdescription";
            this.textdescription.Size = new System.Drawing.Size(236, 82);
            this.textdescription.TabIndex = 1;
            // 
            // textProductname
            // 
            this.textProductname.Location = new System.Drawing.Point(33, 59);
            this.textProductname.Name = "textProductname";
            this.textProductname.Size = new System.Drawing.Size(236, 22);
            this.textProductname.TabIndex = 0;
            // 
            // totalproducts
            // 
            this.totalproducts.AutoSize = true;
            this.totalproducts.Location = new System.Drawing.Point(35, 42);
            this.totalproducts.Name = "totalproducts";
            this.totalproducts.Size = new System.Drawing.Size(14, 16);
            this.totalproducts.TabIndex = 1;
            this.totalproducts.Text = "0";
            // 
            // instocks
            // 
            this.instocks.AutoSize = true;
            this.instocks.Location = new System.Drawing.Point(76, 42);
            this.instocks.Name = "instocks";
            this.instocks.Size = new System.Drawing.Size(14, 16);
            this.instocks.TabIndex = 2;
            this.instocks.Text = "0";
            // 
            // lowstocks
            // 
            this.lowstocks.AutoSize = true;
            this.lowstocks.Location = new System.Drawing.Point(67, 42);
            this.lowstocks.Name = "lowstocks";
            this.lowstocks.Size = new System.Drawing.Size(14, 16);
            this.lowstocks.TabIndex = 3;
            this.lowstocks.Text = "0";
            // 
            // outstocks
            // 
            this.outstocks.AutoSize = true;
            this.outstocks.Location = new System.Drawing.Point(51, 42);
            this.outstocks.Name = "outstocks";
            this.outstocks.Size = new System.Drawing.Size(14, 16);
            this.outstocks.TabIndex = 4;
            this.outstocks.Text = "0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 708);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableInventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogOut);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tableInventory.ResumeLayout(false);
            this.tableInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableInventory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelinstocks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labellowstocks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labeloutstocks;
        private System.Windows.Forms.Label labeltotalproduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textunitprice;
        private System.Windows.Forms.TextBox textquantity;
        private System.Windows.Forms.TextBox textdescription;
        private System.Windows.Forms.TextBox textProductname;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label instocks;
        private System.Windows.Forms.Label lowstocks;
        private System.Windows.Forms.Label outstocks;
        private System.Windows.Forms.Label totalproducts;
    }
}