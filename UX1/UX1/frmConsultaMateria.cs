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
    public partial class frmConsultaMateria : Form
    {
        BL bl = new BL();
        public frmConsultaMateria()
        {
            InitializeComponent();
        }

        private void CbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                txtMateria.Enabled = false;
            }
            else
            {
                txtMateria.Enabled = true;
            }
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (cbTodas.Checked == true)
            {
                DataTable dt = bl.ConsultaMateria("todas");

                if (dt.Rows.Count > 0)
                {
                    dgvCarrera.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No hay materias activas", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                String materia = txtMateria.Text.ToString();

                if (materia == "")
                {
                    MessageBox.Show("Favor de especificar la materia", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    DataTable dt = bl.ConsultaMateria(materia);
                    if (dt.Rows.Count > 0)
                    {
                        dgvCarrera.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No registros con la materia ingresada", "Aviso", MessageBoxButtons.OK);
                    }
                }

            }
        }
    }
}
