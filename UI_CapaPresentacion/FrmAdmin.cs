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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion patallaPrincipal = new FrmIniciarsesion();
            this.Hide();

            patallaPrincipal.Show();
        }

        private void btncrearusuario_Click(object sender, EventArgs e)
        {
            Frmagregarusuario agregarusuario = new Frmagregarusuario();
            this.Hide();
            agregarusuario.Show();
        }

        private void btnmodificarusuario_Click(object sender, EventArgs e)
        {
            Frmmodificarusuario modificarusuario = new Frmmodificarusuario();
            this.Hide();
            modificarusuario.Show();
        }

        private void btninhabilitarusuario_Click(object sender, EventArgs e)
        {
            Frminhabilitarusuario inhabilita = new Frminhabilitarusuario();
            this.Hide();
            inhabilita.Show();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion volver = new FrmIniciarsesion();
            this.Hide();
            volver.Show();
        }
    }
}
