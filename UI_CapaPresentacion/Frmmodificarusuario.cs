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
    public partial class Frmmodificarusuario : Form
    {
        public Frmmodificarusuario()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FrmAdmin vuelve = new FrmAdmin();
            this.Hide();

            vuelve.Show();
        }

        private void labmodificar_Click(object sender, EventArgs e)
        {

        }

        private void labnombre_Click(object sender, EventArgs e)
        {

        }

        private void labpuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
