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
    public partial class FrmHogar3 : Form
    {
        public FrmHogar3()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmHogar2 hogar2 = new FrmHogar2();
            this.Hide();
            hogar2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.Show();
        }
    }
}
