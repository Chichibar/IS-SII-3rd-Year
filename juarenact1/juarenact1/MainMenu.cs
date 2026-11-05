using System;
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
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}