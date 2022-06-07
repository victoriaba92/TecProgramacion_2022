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
    public partial class Frmagregarusuario : Form
    {
        public Frmagregarusuario()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FrmAdmin volver = new FrmAdmin();
            this.Hide();

            volver.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
