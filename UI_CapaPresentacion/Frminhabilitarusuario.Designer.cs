namespace UI_CapaPresentacion
{
    partial class Frminhabilitarusuario
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.btninhabilitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labcodigo = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(135, 212);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 0;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btninhabilitar
            // 
            this.btninhabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btninhabilitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninhabilitar.Location = new System.Drawing.Point(334, 212);
            this.btninhabilitar.Name = "btninhabilitar";
            this.btninhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btninhabilitar.TabIndex = 1;
            this.btninhabilitar.Text = "Inhabilitar";
            this.btninhabilitar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 4;
            // 
            // labcodigo
            // 
            this.labcodigo.AutoSize = true;
            this.labcodigo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labcodigo.Location = new System.Drawing.Point(76, 125);
            this.labcodigo.Name = "labcodigo";
            this.labcodigo.Size = new System.Drawing.Size(165, 28);
            this.labcodigo.TabIndex = 5;
            this.labcodigo.Text = "Id codigo usuario";
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtitulo.ForeColor = System.Drawing.Color.White;
            this.lbtitulo.Location = new System.Drawing.Point(135, 35);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(307, 45);
            this.lbtitulo.TabIndex = 6;
            this.lbtitulo.Text = "Inhabilitar Usuario";
            // 
            // Frminhabilitarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(572, 302);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.labcodigo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninhabilitar);
            this.Controls.Add(this.btnvolver);
            this.Name = "Frminhabilitarusuario";
            this.Text = "Frminhabilitar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnvolver;
        private Button btninhabilitar;
        private Label label1;
        private TextBox textBox1;
        private Label labcodigo;
        private Label lbtitulo;
    }
}