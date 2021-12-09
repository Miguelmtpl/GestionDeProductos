namespace GestionDeProductos
{
    partial class VentanaGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaGestion));
            this.mochilero = new System.Windows.Forms.Label();
            this.comboNombres = new System.Windows.Forms.ComboBox();
            this.btnfinalizar = new GestionDeProductos.Diseño.Boton();
            this.btnliquidar = new GestionDeProductos.Diseño.Boton();
            this.btnAgregar = new GestionDeProductos.Diseño.Boton();
            this.responsable = new System.Windows.Forms.Label();
            this.evento = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mochilero
            // 
            this.mochilero.AutoSize = true;
            this.mochilero.BackColor = System.Drawing.Color.Transparent;
            this.mochilero.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mochilero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.mochilero.Location = new System.Drawing.Point(189, 338);
            this.mochilero.Name = "mochilero";
            this.mochilero.Size = new System.Drawing.Size(137, 36);
            this.mochilero.TabIndex = 1;
            this.mochilero.Text = "Mochilero";
            // 
            // comboNombres
            // 
            this.comboNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNombres.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNombres.FormattingEnabled = true;
            this.comboNombres.Location = new System.Drawing.Point(444, 335);
            this.comboNombres.Name = "comboNombres";
            this.comboNombres.Size = new System.Drawing.Size(617, 44);
            this.comboNombres.TabIndex = 5;
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnfinalizar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnfinalizar.BorderColor = System.Drawing.Color.Transparent;
            this.btnfinalizar.BorderRaius = 40;
            this.btnfinalizar.BorderSize = 2;
            this.btnfinalizar.FlatAppearance.BorderSize = 0;
            this.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinalizar.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnfinalizar.Location = new System.Drawing.Point(432, 708);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(535, 98);
            this.btnfinalizar.TabIndex = 8;
            this.btnfinalizar.Text = "FINALIZAR EVENTO Y GENERAR REPORTE";
            this.btnfinalizar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.boton3_Click);
            // 
            // btnliquidar
            // 
            this.btnliquidar.BackColor = System.Drawing.Color.Transparent;
            this.btnliquidar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnliquidar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnliquidar.BorderRaius = 40;
            this.btnliquidar.BorderSize = 2;
            this.btnliquidar.FlatAppearance.BorderSize = 0;
            this.btnliquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnliquidar.Font = new System.Drawing.Font("Paper Daisy DEMO", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnliquidar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnliquidar.Location = new System.Drawing.Point(743, 512);
            this.btnliquidar.Name = "btnliquidar";
            this.btnliquidar.Size = new System.Drawing.Size(337, 83);
            this.btnliquidar.TabIndex = 7;
            this.btnliquidar.Text = "LIQUIDAR MOCHILERO";
            this.btnliquidar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnliquidar.UseVisualStyleBackColor = false;
            this.btnliquidar.Click += new System.EventHandler(this.boton2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.BorderRaius = 40;
            this.btnAgregar.BorderSize = 2;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Paper Daisy DEMO", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.Location = new System.Drawing.Point(277, 512);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(367, 83);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR O REMOVER PRODUCTOS";
            this.btnAgregar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.boton1_Click);
            // 
            // responsable
            // 
            this.responsable.AutoSize = true;
            this.responsable.BackColor = System.Drawing.Color.Transparent;
            this.responsable.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.responsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.responsable.Location = new System.Drawing.Point(1465, 67);
            this.responsable.Name = "responsable";
            this.responsable.Size = new System.Drawing.Size(61, 24);
            this.responsable.TabIndex = 9;
            this.responsable.Text = "label2";
            // 
            // evento
            // 
            this.evento.AutoSize = true;
            this.evento.BackColor = System.Drawing.Color.Transparent;
            this.evento.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.evento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.evento.Location = new System.Drawing.Point(1465, 134);
            this.evento.Name = "evento";
            this.evento.Size = new System.Drawing.Size(61, 24);
            this.evento.TabIndex = 10;
            this.evento.Text = "label3";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.fecha.Location = new System.Drawing.Point(1465, 196);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(61, 24);
            this.fecha.TabIndex = 11;
            this.fecha.Text = "label4";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // VentanaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.evento);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btnliquidar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboNombres);
            this.Controls.Add(this.mochilero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaGestion";
            this.Text = "Gestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mochilero;
        private System.Windows.Forms.ComboBox comboNombres;
        private Diseño.Boton btnAgregar;
        private Diseño.Boton btnliquidar;
        private Diseño.Boton btnfinalizar;
        private System.Windows.Forms.Label responsable;
        private System.Windows.Forms.Label evento;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}