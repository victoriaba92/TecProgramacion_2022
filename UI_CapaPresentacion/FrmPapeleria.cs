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
    public partial class FrmPapeleria : Form
    {
        public FrmPapeleria()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmPapeleria2 papeleria2 = new FrmPapeleria2();
            this.Hide();
            papeleria2.Show();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.Show();
        }
    }
}
