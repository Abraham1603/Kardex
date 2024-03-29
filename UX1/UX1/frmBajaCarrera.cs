﻿using System;
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
    
    public partial class frmBajaCarrera : Form
    {
        BL bl = new BL();
        public frmBajaCarrera()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string carrera = txtCarrera.Text.ToString();
            bl.BajaCarrera(carrera);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
