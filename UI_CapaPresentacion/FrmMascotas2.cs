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
    public partial class FrmMascotas2 : Form
    {
        public FrmMascotas2()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FrmMascotas mascotas = new FrmMascotas();
            this.Hide();
            mascotas.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmMascotas3 mascotas3 = new FrmMascotas3();
            this.Hide();
            mascotas3.Show();
        }
    }
}
