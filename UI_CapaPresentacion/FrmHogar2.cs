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
    public partial class FrmHogar2 : Form
    {
        public FrmHogar2()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmHogar3 hogar3 = new FrmHogar3();
            this.Hide();
            hogar3.Show();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmHogar hogar1 = new FrmHogar();
            this.Hide();
            hogar1.Show();
        }
    }
}
