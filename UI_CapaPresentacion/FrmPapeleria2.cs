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
    public partial class FrmPapeleria2 : Form
    {
        public FrmPapeleria2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmPapeleria3 papeleria3 = new FrmPapeleria3();
            this.Hide();
            papeleria3.Show();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmPapeleria papeleria1 = new FrmPapeleria();
            this.Hide();
            papeleria1.Show();
        }
    }
}
