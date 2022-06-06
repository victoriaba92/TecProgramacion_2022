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
    public partial class FrmCuidadoP : Form
    {
        public FrmCuidadoP()
        {
            InitializeComponent();
        }

        private void FrmCuidadoP_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmCuidadoP2 cuidadoP2 = new FrmCuidadoP2();
            this.Hide();
            cuidadoP2.Show();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.Show();
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            FrmCuidadoP2 cuidadoP2 = new FrmCuidadoP2();
            this.Hide();
            cuidadoP2.Show();
        }
    }
}
