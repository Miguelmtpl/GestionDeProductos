namespace GestionDeProductos
{
    partial class VentanaProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaProducto));
            this.producto = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtVaso = new System.Windows.Forms.TextBox();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.cantidadT = new System.Windows.Forms.Label();
            this.cantidadV = new System.Windows.Forms.Label();
            this.precioV = new System.Windows.Forms.Label();
            this.cantidadP = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.responsable = new System.Windows.Forms.Label();
            this.evento = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.tiref = new System.Windows.Forms.Label();
            this.ticer = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.boton1 = new GestionDeProductos.Diseño.Boton();
            this.btnSiguiente = new GestionDeProductos.Diseño.Boton();
            this.btnAgregar = new GestionDeProductos.Diseño.Boton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // producto
            // 
            this.producto.AutoSize = true;
            this.producto.BackColor = System.Drawing.Color.Transparent;
            this.producto.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.producto.Location = new System.Drawing.Point(103, 262);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(126, 36);
            this.producto.TabIndex = 2;
            this.producto.Text = "Producto";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.BackColor = System.Drawing.Color.Transparent;
            this.precio.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.precio.Location = new System.Drawing.Point(94, 435);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(135, 36);
            this.precio.TabIndex = 3;
            this.precio.Text = "Precio(€)";
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(304, 259);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(301, 43);
            this.txtproducto.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(304, 432);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 43);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(1018, 264);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 43);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtVaso
            // 
            this.txtVaso.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaso.Location = new System.Drawing.Point(1018, 435);
            this.txtVaso.Name = "txtVaso";
            this.txtVaso.Size = new System.Drawing.Size(100, 40);
            this.txtVaso.TabIndex = 7;
            this.txtVaso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVaso_KeyPress);
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.Location = new System.Drawing.Point(1018, 613);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(100, 40);
            this.txtPrecioV.TabIndex = 8;
            this.txtPrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioV_KeyPress);
            // 
            // cantidadT
            // 
            this.cantidadT.AutoSize = true;
            this.cantidadT.BackColor = System.Drawing.Color.Transparent;
            this.cantidadT.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.cantidadT.Location = new System.Drawing.Point(692, 267);
            this.cantidadT.Name = "cantidadT";
            this.cantidadT.Size = new System.Drawing.Size(301, 36);
            this.cantidadT.TabIndex = 9;
            this.cantidadT.Text = "Cantidad tanqueta(kg)";
            // 
            // cantidadV
            // 
            this.cantidadV.AutoSize = true;
            this.cantidadV.BackColor = System.Drawing.Color.Transparent;
            this.cantidadV.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic);
            this.cantidadV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.cantidadV.Location = new System.Drawing.Point(732, 435);
            this.cantidadV.Name = "cantidadV";
            this.cantidadV.Size = new System.Drawing.Size(252, 36);
            this.cantidadV.TabIndex = 10;
            this.cantidadV.Text = "Cantidad Vaso(kg)";
            // 
            // precioV
            // 
            this.precioV.AutoSize = true;
            this.precioV.BackColor = System.Drawing.Color.Transparent;
            this.precioV.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.precioV.Location = new System.Drawing.Point(779, 621);
            this.precioV.Name = "precioV";
            this.precioV.Size = new System.Drawing.Size(205, 36);
            this.precioV.TabIndex = 11;
            this.precioV.Text = "Precio Vaso(€)";
            // 
            // cantidadP
            // 
            this.cantidadP.AutoSize = true;
            this.cantidadP.BackColor = System.Drawing.Color.Transparent;
            this.cantidadP.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.cantidadP.Location = new System.Drawing.Point(43, 616);
            this.cantidadP.Name = "cantidadP";
            this.cantidadP.Size = new System.Drawing.Size(212, 36);
            this.cantidadP.TabIndex = 12;
            this.cantidadP.Text = "Cantidad inicial ";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(304, 608);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(124, 40);
            this.txtcantidad.TabIndex = 13;
            // 
            // responsable
            // 
            this.responsable.AutoSize = true;
            this.responsable.BackColor = System.Drawing.Color.Transparent;
            this.responsable.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.responsable.Location = new System.Drawing.Point(1465, 67);
            this.responsable.Name = "responsable";
            this.responsable.Size = new System.Drawing.Size(61, 24);
            this.responsable.TabIndex = 16;
            this.responsable.Text = "label7";
            // 
            // evento
            // 
            this.evento.AutoSize = true;
            this.evento.BackColor = System.Drawing.Color.Transparent;
            this.evento.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.evento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.evento.Location = new System.Drawing.Point(1466, 127);
            this.evento.Name = "evento";
            this.evento.Size = new System.Drawing.Size(61, 24);
            this.evento.TabIndex = 17;
            this.evento.Text = "label8";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.Fecha.Location = new System.Drawing.Point(1466, 186);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(61, 24);
            this.Fecha.TabIndex = 18;
            this.Fecha.Text = "label9";
            // 
            // tiref
            // 
            this.tiref.AutoSize = true;
            this.tiref.BackColor = System.Drawing.Color.Transparent;
            this.tiref.Font = new System.Drawing.Font("Paper Daisy DEMO", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiref.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.tiref.Location = new System.Drawing.Point(240, 104);
            this.tiref.Name = "tiref";
            this.tiref.Size = new System.Drawing.Size(111, 36);
            this.tiref.TabIndex = 19;
            this.tiref.Text = "REFRESCOS";
            // 
            // ticer
            // 
            this.ticer.AutoSize = true;
            this.ticer.BackColor = System.Drawing.Color.Transparent;
            this.ticer.Font = new System.Drawing.Font("Paper Daisy DEMO", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.ticer.Location = new System.Drawing.Point(872, 104);
            this.ticer.Name = "ticer";
            this.ticer.Size = new System.Drawing.Size(95, 36);
            this.ticer.TabIndex = 20;
            this.ticer.Text = "CERVEZA";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.Transparent;
            this.boton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.boton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton1.BorderRaius = 40;
            this.boton1.BorderSize = 2;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold);
            this.boton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton1.Location = new System.Drawing.Point(85, 901);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(229, 72);
            this.boton1.TabIndex = 21;
            this.boton1.Text = "CONSULTAR REFRESCOS";
            this.boton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click_1);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnSiguiente.BorderRaius = 40;
            this.btnSiguiente.BorderSize = 2;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnSiguiente.Location = new System.Drawing.Point(737, 875);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(247, 98);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.boton2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.BorderRaius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.Location = new System.Drawing.Point(85, 715);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(240, 82);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "AGREGAR PRODUCTO";
            this.btnAgregar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.boton1_Click);
            // 
            // VentanaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.ticer);
            this.Controls.Add(this.tiref);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.evento);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.cantidadP);
            this.Controls.Add(this.precioV);
            this.Controls.Add(this.cantidadV);
            this.Controls.Add(this.cantidadT);
            this.Controls.Add(this.txtPrecioV);
            this.Controls.Add(this.txtVaso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.producto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaProducto";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label producto;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtVaso;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.Label cantidadT;
        private System.Windows.Forms.Label cantidadV;
        private System.Windows.Forms.Label precioV;
        private System.Windows.Forms.Label cantidadP;
        private System.Windows.Forms.TextBox txtcantidad;
        private Diseño.Boton btnAgregar;
        private Diseño.Boton btnSiguiente;
        private System.Windows.Forms.Label responsable;
        private System.Windows.Forms.Label evento;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label tiref;
        private System.Windows.Forms.Label ticer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Diseño.Boton boton1;
    }
}