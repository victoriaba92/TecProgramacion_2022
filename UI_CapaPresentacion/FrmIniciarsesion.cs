namespace UI_CapaPresentacion
{
    public partial class FrmIniciarsesion : Form
    {
        private Label labusuario;
        private Button btniniciar;
        private Button btncancelar;
        private TextBox txtUsername;
        private TextBox txtPass;
        private PictureBox pictureBox1;
        private Label label1;

        public FrmIniciarsesion()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciarsesion));
            this.labusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labusuario
            // 
            this.labusuario.AutoSize = true;
            this.labusuario.BackColor = System.Drawing.Color.Black;
            this.labusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labusuario.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labusuario.ForeColor = System.Drawing.Color.White;
            this.labusuario.Location = new System.Drawing.Point(240, 71);
            this.labusuario.Name = "labusuario";
            this.labusuario.Size = new System.Drawing.Size(160, 39);
            this.labusuario.TabIndex = 0;
            this.labusuario.Text = "Username";
            this.labusuario.Click += new System.EventHandler(this.labusuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.Black;
            this.btniniciar.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btniniciar.ForeColor = System.Drawing.Color.Transparent;
            this.btniniciar.Location = new System.Drawing.Point(264, 280);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(194, 52);
            this.btniniciar.TabIndex = 2;
            this.btniniciar.Text = "Iniciar Sesión";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Black;
            this.btncancelar.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btncancelar.Location = new System.Drawing.Point(574, 280);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(142, 52);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Gold;
            this.txtUsername.Location = new System.Drawing.Point(472, 79);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(244, 31);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Gold;
            this.txtPass.Location = new System.Drawing.Point(472, 169);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(244, 31);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Iniciarsesion
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(778, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labusuario);
            this.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.Name = "Iniciarsesion";
            this.Load += new System.EventHandler(this.Iniciarsesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labusuario_Click(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            CapaEntidades.Usuario usuario = new CapaEntidades.Usuario();
            BLL_CapaNegocio.Usuario negocio = new BLL_CapaNegocio.Usuario();

            usuario.Username = txtUsername.Text;
            usuario.Password = txtPass.Text;

            if (negocio.validarcredencialesdeusuario(usuario))
            {
                CapaEntidades.Perfil perfil = negocio.GetPerfilByUsername(usuario.Username);

                if (perfil.Descripcion == "ADMINISTRADOR")
                {
                    FrmAdmin formularioDeAdministrador = new FrmAdmin();
                    this.Hide();

                    formularioDeAdministrador.ShowDialog();
                }
                if (perfil.Descripcion == "CLIENTE")
                {
                    FrmCliente formularioDeCliente = new FrmCliente();
                    this.Hide();

                    formularioDeCliente.ShowDialog();
                }
                if (perfil.Descripcion == "VENDEDOR")
                {
                    FrmVendedor formularioDeVendedor= new FrmVendedor();
                    this.Hide();

                    formularioDeVendedor.ShowDialog();
                }
                if (perfil.Descripcion == "STOCK")
                {
                    FrmStock formularioDeVendedor = new FrmStock();
                    this.Hide();

                    formularioDeVendedor.ShowDialog();
                }
                //else
                //{
                //    MessageBox.Show("...");
                //}


                //MessageBox.Show("El usuario y clave son validos");
            }
            else 
            {
                MessageBox.Show("El usuario y clave son invalidos!...");
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Iniciarsesion_Load(object sender, EventArgs e)
        {

        }
    }
}