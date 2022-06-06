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
    public partial class FrmCuidadoP2 : Form
    {
        public FrmCuidadoP2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmCuidadoP cuidadoP1 = new FrmCuidadoP();
            this.Hide();
            cuidadoP1.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmCuidadoP3 cuidadoP3 = new FrmCuidadoP3();
            this.Hide();
            cuidadoP3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.Show();
        }
    }
}
