namespace UI_CapaPresentacion
{
    partial class FrmStock
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncerrarsesion = new System.Windows.Forms.Button();
            this.labidprod = new System.Windows.Forms.Label();
            this.labprecio = new System.Windows.Forms.Label();
            this.labdescrpcion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.labcantidad = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtid_producto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(106, 223);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(245, 223);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Location = new System.Drawing.Point(364, 223);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(100, 23);
            this.btncerrarsesion.TabIndex = 2;
            this.btncerrarsesion.Text = "cerrar sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // labidprod
            // 
            this.labidprod.AutoSize = true;
            this.labidprod.Location = new System.Drawing.Point(56, 30);
            this.labidprod.Name = "labidprod";
            this.labidprod.Size = new System.Drawing.Size(71, 15);
            this.labidprod.TabIndex = 3;
            this.labidprod.Text = "id_producto";
            // 
            // labprecio
            // 
            this.labprecio.AutoSize = true;
            this.labprecio.Location = new System.Drawing.Point(56, 65);
            this.labprecio.Name = "labprecio";
            this.labprecio.Size = new System.Drawing.Size(40, 15);
            this.labprecio.TabIndex = 4;
            this.labprecio.Text = "precio";
            // 
            // labdescrpcion
            // 
            this.labdescrpcion.AutoSize = true;
            this.labdescrpcion.Location = new System.Drawing.Point(59, 143);
            this.labdescrpcion.Name = "labdescrpcion";
            this.labdescrpcion.Size = new System.Drawing.Size(68, 15);
            this.labdescrpcion.TabIndex = 5;
            this.labdescrpcion.Text = "descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtdescripcion.Location = new System.Drawing.Point(182, 135);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 23);
            this.txtdescripcion.TabIndex = 7;
            // 
            // labcantidad
            // 
            this.labcantidad.AutoSize = true;
            this.labcantidad.Location = new System.Drawing.Point(56, 106);
            this.labcantidad.Name = "labcantidad";
            this.labcantidad.Size = new System.Drawing.Size(53, 15);
            this.labcantidad.TabIndex = 10;
            this.labcantidad.Text = "cantidad";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtprecio.Location = new System.Drawing.Point(182, 62);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 23);
            this.txtprecio.TabIndex = 11;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtcantidad.Location = new System.Drawing.Point(182, 98);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 23);
            this.txtcantidad.TabIndex = 12;
            // 
            // txtid_producto
            // 
            this.txtid_producto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtid_producto.Location = new System.Drawing.Point(182, 22);
            this.txtid_producto.Name = "txtid_producto";
            this.txtid_producto.Size = new System.Drawing.Size(100, 23);
            this.txtid_producto.TabIndex = 13;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.txtid_producto);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.labcantidad);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.labdescrpcion);
            this.Controls.Add(this.labprecio);
            this.Controls.Add(this.labidprod);
            this.Controls.Add(this.btncerrarsesion);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnagregar;
        private Button btncancelar;
        private Button btncerrarsesion;
        private Label labidprod;
        private Label labprecio;
        private Label labdescrpcion;
        private TextBox txtdescripcion;
        private Label labcantidad;
        private TextBox txtprecio;
        private TextBox txtcantidad;
        private TextBox txtid_producto;
    }
}