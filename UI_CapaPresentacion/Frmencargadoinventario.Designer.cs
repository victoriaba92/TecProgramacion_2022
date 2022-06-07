namespace UI_CapaPresentacion
{
    partial class Frmencargadoinventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmencargadoinventario));
            this.btnlistar = new System.Windows.Forms.Button();
            this.btngenera = new System.Windows.Forms.Button();
            this.btnadministra = new System.Windows.Forms.Button();
            this.labtitulo = new System.Windows.Forms.Label();
            this.btnregistra = new System.Windows.Forms.Button();
            this.btnconfigurar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlistar
            // 
            this.btnlistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlistar.Location = new System.Drawing.Point(47, 58);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(121, 33);
            this.btnlistar.TabIndex = 0;
            this.btnlistar.Text = "Listar Stock";
            this.btnlistar.UseVisualStyleBackColor = false;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btngenera
            // 
            this.btngenera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btngenera.Location = new System.Drawing.Point(47, 114);
            this.btngenera.Name = "btngenera";
            this.btngenera.Size = new System.Drawing.Size(121, 40);
            this.btngenera.TabIndex = 1;
            this.btngenera.Text = "Genera Orden de Compra";
            this.btngenera.UseVisualStyleBackColor = false;
            this.btngenera.Click += new System.EventHandler(this.btngenera_Click);
            // 
            // btnadministra
            // 
            this.btnadministra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnadministra.Location = new System.Drawing.Point(47, 178);
            this.btnadministra.Name = "btnadministra";
            this.btnadministra.Size = new System.Drawing.Size(121, 39);
            this.btnadministra.TabIndex = 2;
            this.btnadministra.Text = "Administrar Productos";
            this.btnadministra.UseVisualStyleBackColor = false;
            this.btnadministra.Click += new System.EventHandler(this.btnadministra_Click);
            // 
            // labtitulo
            // 
            this.labtitulo.AutoSize = true;
            this.labtitulo.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labtitulo.ForeColor = System.Drawing.Color.White;
            this.labtitulo.Location = new System.Drawing.Point(47, 9);
            this.labtitulo.Name = "labtitulo";
            this.labtitulo.Size = new System.Drawing.Size(615, 45);
            this.labtitulo.TabIndex = 3;
            this.labtitulo.Text = "Perfil Encargado Inventario y Logistica";
            // 
            // btnregistra
            // 
            this.btnregistra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnregistra.Location = new System.Drawing.Point(47, 237);
            this.btnregistra.Name = "btnregistra";
            this.btnregistra.Size = new System.Drawing.Size(121, 41);
            this.btnregistra.TabIndex = 4;
            this.btnregistra.Text = "Registrar Mercaderia";
            this.btnregistra.UseVisualStyleBackColor = false;
            this.btnregistra.Click += new System.EventHandler(this.btnregistra_Click);
            // 
            // btnconfigurar
            // 
            this.btnconfigurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnconfigurar.Location = new System.Drawing.Point(47, 294);
            this.btnconfigurar.Name = "btnconfigurar";
            this.btnconfigurar.Size = new System.Drawing.Size(121, 38);
            this.btnconfigurar.TabIndex = 5;
            this.btnconfigurar.Text = "Configurar Alerta";
            this.btnconfigurar.UseVisualStyleBackColor = false;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvolver.ForeColor = System.Drawing.Color.Black;
            this.btnvolver.Location = new System.Drawing.Point(422, 294);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(112, 38);
            this.btnvolver.TabIndex = 6;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 183);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frmencargadoinventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(693, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnconfigurar);
            this.Controls.Add(this.btnregistra);
            this.Controls.Add(this.labtitulo);
            this.Controls.Add(this.btnadministra);
            this.Controls.Add(this.btngenera);
            this.Controls.Add(this.btnlistar);
            this.Name = "Frmencargadoinventario";
            this.Text = "Frmencargadoinventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnlistar;
        private Button btngenera;
        private Button btnadministra;
        private Label labtitulo;
        private Button btnregistra;
        private Button btnconfigurar;
        private Button btnvolver;
        private PictureBox pictureBox1;
    }
}