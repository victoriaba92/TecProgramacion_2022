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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(102, 273);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(241, 273);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncerrarsesion.ForeColor = System.Drawing.Color.White;
            this.btncerrarsesion.Location = new System.Drawing.Point(360, 273);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(100, 23);
            this.btncerrarsesion.TabIndex = 2;
            this.btncerrarsesion.Text = "Cerrar sesion";
            this.btncerrarsesion.UseVisualStyleBackColor = false;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // labidprod
            // 
            this.labidprod.AutoSize = true;
            this.labidprod.Location = new System.Drawing.Point(134, 79);
            this.labidprod.Name = "labidprod";
            this.labidprod.Size = new System.Drawing.Size(70, 15);
            this.labidprod.TabIndex = 3;
            this.labidprod.Text = "ID producto";
            // 
            // labprecio
            // 
            this.labprecio.AutoSize = true;
            this.labprecio.Location = new System.Drawing.Point(137, 119);
            this.labprecio.Name = "labprecio";
            this.labprecio.Size = new System.Drawing.Size(40, 15);
            this.labprecio.TabIndex = 4;
            this.labprecio.Text = "Precio";
            // 
            // labdescrpcion
            // 
            this.labdescrpcion.AutoSize = true;
            this.labdescrpcion.Location = new System.Drawing.Point(134, 207);
            this.labdescrpcion.Name = "labdescrpcion";
            this.labdescrpcion.Size = new System.Drawing.Size(69, 15);
            this.labdescrpcion.TabIndex = 5;
            this.labdescrpcion.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtdescripcion.Location = new System.Drawing.Point(260, 199);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(158, 23);
            this.txtdescripcion.TabIndex = 7;
            // 
            // labcantidad
            // 
            this.labcantidad.AutoSize = true;
            this.labcantidad.Location = new System.Drawing.Point(134, 160);
            this.labcantidad.Name = "labcantidad";
            this.labcantidad.Size = new System.Drawing.Size(55, 15);
            this.labcantidad.TabIndex = 10;
            this.labcantidad.Text = "Cantidad";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtprecio.Location = new System.Drawing.Point(260, 116);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(158, 23);
            this.txtprecio.TabIndex = 11;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtcantidad.Location = new System.Drawing.Point(260, 157);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(158, 23);
            this.txtcantidad.TabIndex = 12;
            // 
            // txtid_producto
            // 
            this.txtid_producto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtid_producto.Location = new System.Drawing.Point(260, 76);
            this.txtid_producto.Name = "txtid_producto";
            this.txtid_producto.Size = new System.Drawing.Size(158, 23);
            this.txtid_producto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registro de mercadería";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(575, 337);
            this.Controls.Add(this.label1);
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
        private Label label1;
    }
}