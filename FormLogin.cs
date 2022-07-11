using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancel = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string password = txtPass.Text;

            if (UserRegistration.Login(name, password))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado!!!");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Close();
        }
    }
}
