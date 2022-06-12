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
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmIniciarsesion iniciar = new FrmIniciarsesion();
            iniciar.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool regUsuario = false;
            bool regCliente = false;
            lblError.Visible = false;
            if (txtContra.Text != txtContraRep.Text)
            {
                lblError.Text = "Las contraseñas no coinciden";
                lblError.Visible = true;
                return;
            }
            regUsuario = Usuariodao.altaUsuario(txtNUsuario.Text, txtContra.Text);
            if (regUsuario)
            {
                regCliente = Usuariodao.altaCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtDomicilio.Text, txtCP.Text, txtEmail.Text, dtFNac.Value, txtTel.Text, txtNUsuario.Text, txtContra.Text, txtContraRep.Text);
                if (regCliente)
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
