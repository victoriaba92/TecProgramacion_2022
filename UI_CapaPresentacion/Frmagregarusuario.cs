using BLL_CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using DAL_CapaDato;

namespace UI_CapaPresentacion
{
    public partial class Frmagregarusuario : Form
    {
        public Frmagregarusuario()
        {
            InitializeComponent();
        }


        private void btnvolver_Click(object sender, EventArgs e)
        {
            FrmAdmin volver = new FrmAdmin();
            volver.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion cancelar = new FrmIniciarsesion();
            cancelar.Show();
            this.Hide();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool regUsuario = false;
            bool regEmpleado = false;
            lblError.Visible = false;
            if (txtContraseña.Text != txtRepetirC.Text)
            {
                lblError.Text = "Las contraseñas no coinciden";
                lblError.Visible = true;
                return;
            }
            regUsuario = Usuariodao.altaUsuario(txtNombreU.Text, txtContraseña.Text);
            if (regUsuario)
            {
                regEmpleado = Usuariodao.altaEmpleado(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtDomicilio.Text, cboxPuesto.Text, txtCuit.Text, txtNombreU.Text, txtContraseña.Text, txtRepetirC.Text);
                if (regEmpleado)
                {
                    MessageBox.Show("Usuario creado exitosamente");
                    FrmIniciarsesion iniciar = new FrmIniciarsesion();
                    iniciar.Show();
                    this.Hide();
                }
            }
            else
            {
                lblError.Text = "Nombre de usuario existente!";
                lblError.Visible = true;
            }
        }
    }
}
