﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CapaPresentacion
{
    public partial class FrmRopa : Form
    {
        public FrmRopa()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmRopa2 ropa2 = new FrmRopa2();
            this.Hide();
            ropa2.Show();
        }
    }
}
