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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion patallaPrincipal = new FrmIniciarsesion();
            this.Hide();

            patallaPrincipal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {/*
            button4 pantallaperfilcliente = new button4();
            this.Hide(pantallaperfilcliente);
            pantallaperfilcliente.show();
            */
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmHogar hogar = new FrmHogar();
            this.Hide();
            hogar.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmJuegos juegos = new FrmJuegos();
            this.Hide();
            juegos.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmRopa ropa = new FrmRopa();
            this.Hide();
            ropa.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmMascotas mascotas = new FrmMascotas();
            this.Hide();
            mascotas.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmPapeleria papeleria = new FrmPapeleria();
            this.Hide();
            papeleria.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmCuidadoP cuidadoPersonal = new FrmCuidadoP();
            this.Hide();
            cuidadoPersonal.Show();
        }
    }
}
