using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kardex.Layers;

namespace Kardex
{
    public partial class Login : Form
    {
        BL bl = new BL();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsername.Text;
            DataTable dt = bl.LoginValidation(txtUsername.Text, txtPassword.Text);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + Usuario, "Inicio de sesión", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Alerta", MessageBoxButtons.OK);
            }
        }
    }
}
