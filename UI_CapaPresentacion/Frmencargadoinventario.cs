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
    public partial class Frmencargadoinventario : Form
    {
        public Frmencargadoinventario()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion volver = new FrmIniciarsesion();
            this.Hide();
            volver.Show();  
        }

        private void btnregistra_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            this.Hide();
            frmStock.Show();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {

        }
    }
}
