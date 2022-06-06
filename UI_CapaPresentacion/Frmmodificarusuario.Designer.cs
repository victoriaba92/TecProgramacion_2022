namespace UI_CapaPresentacion
{
    partial class Frmmodificarusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmodificarusuario));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labmodificar = new System.Windows.Forms.Label();
            this.labpuesto = new System.Windows.Forms.Label();
            this.labdni = new System.Windows.Forms.Label();
            this.labnombre = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "gerente",
            "encargado de inventario y logistica"});
            this.comboBox1.Location = new System.Drawing.Point(250, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 23);
            this.textBox1.TabIndex = 18;
            // 
            // labmodificar
            // 
            this.labmodificar.AutoSize = true;
            this.labmodificar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labmodificar.ForeColor = System.Drawing.Color.White;
            this.labmodificar.Location = new System.Drawing.Point(137, 23);
            this.labmodificar.Name = "labmodificar";
            this.labmodificar.Size = new System.Drawing.Size(320, 48);
            this.labmodificar.TabIndex = 17;
            this.labmodificar.Text = "Modificar Usuario";
            this.labmodificar.Click += new System.EventHandler(this.labmodificar_Click);
            // 
            // labpuesto
            // 
            this.labpuesto.AutoSize = true;
            this.labpuesto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labpuesto.Location = new System.Drawing.Point(68, 262);
            this.labpuesto.Name = "labpuesto";
            this.labpuesto.Size = new System.Drawing.Size(71, 28);
            this.labpuesto.TabIndex = 16;
            this.labpuesto.Text = "Puesto";
            this.labpuesto.Click += new System.EventHandler(this.labpuesto_Click);
            // 
            // labdni
            // 
            this.labdni.AutoSize = true;
            this.labdni.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labdni.Location = new System.Drawing.Point(64, 204);
            this.labdni.Name = "labdni";
            this.labdni.Size = new System.Drawing.Size(46, 28);
            this.labdni.TabIndex = 15;
            this.labdni.Text = "DNI";
            // 
            // labnombre
            // 
            this.labnombre.AutoSize = true;
            this.labnombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labnombre.Location = new System.Drawing.Point(64, 141);
            this.labnombre.Name = "labnombre";
            this.labnombre.Size = new System.Drawing.Size(174, 28);
            this.labnombre.TabIndex = 13;
            this.labnombre.Text = "Nombre completo";
            this.labnombre.Click += new System.EventHandler(this.labnombre_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncancelar.Location = new System.Drawing.Point(296, 343);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnaceptar.Location = new System.Drawing.Point(86, 343);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnvolver.Location = new System.Drawing.Point(488, 343);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 22;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 112);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Frmmodificarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(653, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labmodificar);
            this.Controls.Add(this.labpuesto);
            this.Controls.Add(this.labdni);
            this.Controls.Add(this.labnombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Frmmodificarusuario";
            this.Text = "Frmmodificarusuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label labmodificar;
        private Label labpuesto;
        private Label labdni;
        private Label labnombre;
        private Button btncancelar;
        private Button btnaceptar;
        private Button btnvolver;
        private PictureBox pictureBox1;
    }
}