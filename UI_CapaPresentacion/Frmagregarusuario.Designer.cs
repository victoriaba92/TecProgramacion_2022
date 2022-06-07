namespace UI_CapaPresentacion
{
    partial class Frmagregarusuario
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labtitutlo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboxpuesto = new System.Windows.Forms.ComboBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Location = new System.Drawing.Point(251, 324);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 0;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(81, 324);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puesto";
            // 
            // labtitutlo
            // 
            this.labtitutlo.AutoSize = true;
            this.labtitutlo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labtitutlo.ForeColor = System.Drawing.Color.White;
            this.labtitutlo.Location = new System.Drawing.Point(160, 26);
            this.labtitutlo.Name = "labtitutlo";
            this.labtitutlo.Size = new System.Drawing.Size(285, 53);
            this.labtitutlo.TabIndex = 6;
            this.labtitutlo.Text = "Crear Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 23);
            this.textBox3.TabIndex = 9;
            // 
            // cboxpuesto
            // 
            this.cboxpuesto.FormattingEnabled = true;
            this.cboxpuesto.Items.AddRange(new object[] {
            "gerente",
            "encargado de inventario y logistica"});
            this.cboxpuesto.Location = new System.Drawing.Point(203, 239);
            this.cboxpuesto.Name = "cboxpuesto";
            this.cboxpuesto.Size = new System.Drawing.Size(165, 23);
            this.cboxpuesto.TabIndex = 10;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnvolver.ForeColor = System.Drawing.Color.White;
            this.btnvolver.Location = new System.Drawing.Point(478, 324);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Domicilio";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 23);
            this.textBox4.TabIndex = 13;
            // 
            // Frmagregarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(609, 394);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.cboxpuesto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labtitutlo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Frmagregarusuario";
            this.Text = "Frmagregarusuario";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnaceptar;
        private Button btncancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labtitutlo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox cboxpuesto;
        private Button btnvolver;
        private Label label5;
        private TextBox textBox4;
    }
}