using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kardex;

namespace UX1
{
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private void BtnAltaMateria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmAltaMateria());
        }

        private void BtnBajaMateria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmBajaMateria());
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);

            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void BtnConsultaMateria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmConsultaMateria());
        }

        private void BtnModificacionMateria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmModificaMateria());
        }
    }
}
