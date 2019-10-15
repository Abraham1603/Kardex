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
    public partial class frmAltaCarrera : Form
    {
        BL bl = new BL();
        public frmAltaCarrera()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string carrera = txtCarrera.Text.ToString();
            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.ToString());
            bool estatus;

            if(cbEstatus.SelectedValue.ToString() == "Activo")
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }
            bl.AltaCarrera(carrera, fechaalta, estatus);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
