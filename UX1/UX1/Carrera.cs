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
    public partial class Carrera : Form
    {
        
        public frmAltaCarrera frmaltacarr;
        
        public Carrera()
        {
            InitializeComponent();
        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaCarrera_Click(object sender, EventArgs e)
        {

            if (frmaltacarr == null || frmaltacarr.IsDisposed)
            {
                frmaltacarr = new frmAltaCarrera();
                frmaltacarr.Show();
                frmaltacarr.MdiParent = this;
            }
            else
            {
                MessageBox.Show("Ya hay una ventana abierta.", "Alerta", MessageBoxButtons.OK);
            }
            //frmAltaCarrera FAC = new frmAltaCarrera();
            //FAC.Show();
            
        }

        private void BtnBajaCarrera_Click(object sender, EventArgs e)
        {
            frmBajaCarrera FBC = new frmBajaCarrera();
            FBC.Show();
        }

        private void BtnConsultaCarrera_Click(object sender, EventArgs e)
        {
            frmConsultaCarrera FCC = new frmConsultaCarrera();
            FCC.Show();
        }

        private void BtnModificacionCarrera_Click(object sender, EventArgs e)
        {
            frmModificaCarrera FMC = new frmModificaCarrera();
            FMC.Show();
        }
    }
}
