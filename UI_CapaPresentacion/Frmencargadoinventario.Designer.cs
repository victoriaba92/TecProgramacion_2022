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
            this.btnlistar = new System.Windows.Forms.Button();
            this.btngenera = new System.Windows.Forms.Button();
            this.btnadministra = new System.Windows.Forms.Button();
            this.labtitulo = new System.Windows.Forms.Label();
            this.btnregistra = new System.Windows.Forms.Button();
            this.btnconfigurar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(47, 58);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(121, 33);
            this.btnlistar.TabIndex = 0;
            this.btnlistar.Text = "Listar Stock";
            this.btnlistar.UseVisualStyleBackColor = true;
            // 
            // btngenera
            // 
            this.btngenera.Location = new System.Drawing.Point(47, 114);
            this.btngenera.Name = "btngenera";
            this.btngenera.Size = new System.Drawing.Size(121, 40);
            this.btngenera.TabIndex = 1;
            this.btngenera.Text = "Genera Orden de Compra";
            this.btngenera.UseVisualStyleBackColor = true;
            // 
            // btnadministra
            // 
            this.btnadministra.Location = new System.Drawing.Point(47, 178);
            this.btnadministra.Name = "btnadministra";
            this.btnadministra.Size = new System.Drawing.Size(121, 39);
            this.btnadministra.TabIndex = 2;
            this.btnadministra.Text = "Administrar Productos";
            this.btnadministra.UseVisualStyleBackColor = true;
            // 
            // labtitulo
            // 
            this.labtitulo.AutoSize = true;
            this.labtitulo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labtitulo.Location = new System.Drawing.Point(47, 9);
            this.labtitulo.Name = "labtitulo";
            this.labtitulo.Size = new System.Drawing.Size(586, 46);
            this.labtitulo.TabIndex = 3;
            this.labtitulo.Text = "Perfil Encargado Inventario y Logistica";
            // 
            // btnregistra
            // 
            this.btnregistra.Location = new System.Drawing.Point(47, 237);
            this.btnregistra.Name = "btnregistra";
            this.btnregistra.Size = new System.Drawing.Size(121, 41);
            this.btnregistra.TabIndex = 4;
            this.btnregistra.Text = "Registrar Mercaderia";
            this.btnregistra.UseVisualStyleBackColor = true;
            this.btnregistra.Click += new System.EventHandler(this.btnregistra_Click);
            // 
            // btnconfigurar
            // 
            this.btnconfigurar.Location = new System.Drawing.Point(47, 294);
            this.btnconfigurar.Name = "btnconfigurar";
            this.btnconfigurar.Size = new System.Drawing.Size(121, 38);
            this.btnconfigurar.TabIndex = 5;
            this.btnconfigurar.Text = "Configurar Alerta";
            this.btnconfigurar.UseVisualStyleBackColor = true;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(422, 294);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(112, 38);
            this.btnvolver.TabIndex = 6;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Frmencargadoinventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(693, 420);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnconfigurar);
            this.Controls.Add(this.btnregistra);
            this.Controls.Add(this.labtitulo);
            this.Controls.Add(this.btnadministra);
            this.Controls.Add(this.btngenera);
            this.Controls.Add(this.btnlistar);
            this.Name = "Frmencargadoinventario";
            this.Text = "Frmencargadoinventario";
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
    }
}