using System;
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
    public partial class FrmRopa3 : Form
    {
        public FrmRopa3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmRopa2 ropa2 = new FrmRopa2();
            this.Hide();
            ropa2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.Show();
        }
    }
}
