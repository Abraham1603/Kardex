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
using Kardex.Layers;

namespace UX1
{
    public partial class frmModificaMateria : Form
    {
        BL bl = new BL();
        public frmModificaMateria()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string materia = txtMateria.Text.ToString();
            DateTime fechaalta = Convert.ToDateTime(dtpFechaAlta.Value.ToShortDateString());
            DateTime fechabaja = Convert.ToDateTime(dtpFechaBaja.Value.ToShortDateString());
            bool estatus;
            if (cbEstatus.SelectedIndex == 0)
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }
            bl.ModificaMateria(materia, fechaalta, fechabaja, estatus);
        }
    }
}
