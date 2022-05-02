namespace UI_CapaPresentacion
{
    partial class FrmCliente
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbmenuprincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbmenuprincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(963, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cerrar Sesion";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(1086, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbmenuprincipal
            // 
            this.pbmenuprincipal.Image = global::UI_CapaPresentacion.Properties.Resources.WhatsApp_Image_2022_05_02_at_3_08_18_AM;
            this.pbmenuprincipal.Location = new System.Drawing.Point(0, 54);
            this.pbmenuprincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pbmenuprincipal.Name = "pbmenuprincipal";
            this.pbmenuprincipal.Size = new System.Drawing.Size(1186, 483);
            this.pbmenuprincipal.TabIndex = 10;
            this.pbmenuprincipal.TabStop = false;
            this.pbmenuprincipal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(60)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1184, 533);
            this.Controls.Add(this.pbmenuprincipal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbmenuprincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private PictureBox pbmenuprincipal;
    }
}