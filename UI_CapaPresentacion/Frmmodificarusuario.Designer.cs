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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labmodificar = new System.Windows.Forms.Label();
            this.labpuesto = new System.Windows.Forms.Label();
            this.labdni = new System.Windows.Forms.Label();
            this.labapellido = new System.Windows.Forms.Label();
            this.labnombre = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "gerente",
            "encargado de inventario y logistica"});
            this.comboBox1.Location = new System.Drawing.Point(335, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(335, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 18;
            // 
            // labmodificar
            // 
            this.labmodificar.AutoSize = true;
            this.labmodificar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labmodificar.Location = new System.Drawing.Point(153, 26);
            this.labmodificar.Name = "labmodificar";
            this.labmodificar.Size = new System.Drawing.Size(339, 54);
            this.labmodificar.TabIndex = 17;
            this.labmodificar.Text = "Modificar Usuario";
            // 
            // labpuesto
            // 
            this.labpuesto.AutoSize = true;
            this.labpuesto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labpuesto.Location = new System.Drawing.Point(64, 270);
            this.labpuesto.Name = "labpuesto";
            this.labpuesto.Size = new System.Drawing.Size(71, 28);
            this.labpuesto.TabIndex = 16;
            this.labpuesto.Text = "Puesto";
            // 
            // labdni
            // 
            this.labdni.AutoSize = true;
            this.labdni.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labdni.Location = new System.Drawing.Point(64, 227);
            this.labdni.Name = "labdni";
            this.labdni.Size = new System.Drawing.Size(46, 28);
            this.labdni.TabIndex = 15;
            this.labdni.Text = "DNI";
            // 
            // labapellido
            // 
            this.labapellido.AutoSize = true;
            this.labapellido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labapellido.Location = new System.Drawing.Point(64, 184);
            this.labapellido.Name = "labapellido";
            this.labapellido.Size = new System.Drawing.Size(86, 28);
            this.labapellido.TabIndex = 14;
            this.labapellido.Text = "Apellido";
            // 
            // labnombre
            // 
            this.labnombre.AutoSize = true;
            this.labnombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labnombre.Location = new System.Drawing.Point(64, 141);
            this.labnombre.Name = "labnombre";
            this.labnombre.Size = new System.Drawing.Size(85, 28);
            this.labnombre.TabIndex = 13;
            this.labnombre.Text = "Nombre";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(258, 343);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(64, 343);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 11;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(488, 343);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 22;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Frmmodificarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(653, 404);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labmodificar);
            this.Controls.Add(this.labpuesto);
            this.Controls.Add(this.labdni);
            this.Controls.Add(this.labapellido);
            this.Controls.Add(this.labnombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Frmmodificarusuario";
            this.Text = "Frmmodificarusuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labmodificar;
        private Label labpuesto;
        private Label labdni;
        private Label labapellido;
        private Label labnombre;
        private Button btncancelar;
        private Button btnaceptar;
        private Button btnvolver;
    }
}