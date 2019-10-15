using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UX1
{
    public partial class Maestro : Form
    {
        public Maestro()
        {
            InitializeComponent();
        }

        private void Maestro_Load(object sender, EventArgs e)
        {

        }

        private void BtnAltaMaestro_Click(object sender, EventArgs e)
        {

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
    }
}
