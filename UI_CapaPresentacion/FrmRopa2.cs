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
    public partial class FrmRopa2 : Form
    {
        public FrmRopa2()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmRopa3 ropa3 = new FrmRopa3();
            this.Hide();
            ropa3.Show();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmRopa ropa1 = new FrmRopa();
            this.Hide();
            ropa1.Show();
        }
    }
}
