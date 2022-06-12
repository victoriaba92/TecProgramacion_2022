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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnvolver.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.Location = new System.Drawing.Point(80, 133);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(162, 52);
            this.btnvolver.TabIndex = 0;
            this.btnvolver.Text = "Baja Cliente";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btninhabilitar
            // 
            this.btninhabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btninhabilitar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninhabilitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninhabilitar.Location = new System.Drawing.Point(326, 133);
            this.btninhabilitar.Name = "btninhabilitar";
            this.btninhabilitar.Size = new System.Drawing.Size(154, 52);
            this.btninhabilitar.TabIndex = 1;
            this.btninhabilitar.Text = "Baja Empleado";
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
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(170, 35);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(236, 43);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "Baja Usuario";
            // 
            // Frminhabilitarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(572, 302);
            this.Controls.Add(this.lbltitulo);
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
        private Label lbltitulo;
    }
}