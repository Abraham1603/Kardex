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
    public partial class frmModificaCarrera : Form
    {
        BL bl = new BL();
        public frmModificaCarrera()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string carrera = txtCarrera.Text.ToString();
            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.Value.ToShortDateString());
            DateTime fechabaja = Convert.ToDateTime(dtpFechaBaja.Value.ToShortDateString());
            bool estatus;
            if(cbEstatus.SelectedText == "Activo")
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }
            bl.ModificaCarrera(carrera, fechaalta, fechabaja, estatus);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
