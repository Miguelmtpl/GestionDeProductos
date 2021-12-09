namespace GestionDeProductos
{
    partial class VentanaMochilero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMochilero));
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.nombreMochilero = new System.Windows.Forms.Label();
            this.mochila = new System.Windows.Forms.Label();
            this.comboMo = new System.Windows.Forms.ComboBox();
            this.responsable = new System.Windows.Forms.Label();
            this.evento = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.btnSiguiente = new GestionDeProductos.Diseño.Boton();
            this.btnAgregar = new GestionDeProductos.Diseño.Boton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMC = new GestionDeProductos.Diseño.Boton();
            this.btnMR = new GestionDeProductos.Diseño.Boton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.Location = new System.Drawing.Point(527, 308);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(517, 43);
            this.txtNombreM.TabIndex = 1;
            // 
            // nombreMochilero
            // 
            this.nombreMochilero.AutoSize = true;
            this.nombreMochilero.BackColor = System.Drawing.Color.Transparent;
            this.nombreMochilero.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMochilero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.nombreMochilero.Location = new System.Drawing.Point(106, 311);
            this.nombreMochilero.Name = "nombreMochilero";
            this.nombreMochilero.Size = new System.Drawing.Size(292, 36);
            this.nombreMochilero.TabIndex = 2;
            this.nombreMochilero.Text = "Nombre del mochilero";
            // 
            // mochila
            // 
            this.mochila.AutoSize = true;
            this.mochila.BackColor = System.Drawing.Color.Transparent;
            this.mochila.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mochila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.mochila.Location = new System.Drawing.Point(269, 426);
            this.mochila.Name = "mochila";
            this.mochila.Size = new System.Drawing.Size(112, 36);
            this.mochila.TabIndex = 3;
            this.mochila.Text = "Mochila";
            // 
            // comboMo
            // 
            this.comboMo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMo.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMo.FormattingEnabled = true;
            this.comboMo.Items.AddRange(new object[] {
            "Refrescos",
            "Cerveza"});
            this.comboMo.Location = new System.Drawing.Point(527, 418);
            this.comboMo.Name = "comboMo";
            this.comboMo.Size = new System.Drawing.Size(302, 44);
            this.comboMo.TabIndex = 4;
            // 
            // responsable
            // 
            this.responsable.AutoSize = true;
            this.responsable.BackColor = System.Drawing.Color.Transparent;
            this.responsable.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.responsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.responsable.Location = new System.Drawing.Point(1465, 67);
            this.responsable.Name = "responsable";
            this.responsable.Size = new System.Drawing.Size(236, 24);
            this.responsable.TabIndex = 6;
            this.responsable.Text = "Cristina Gutierrez Leopoldo";
            // 
            // evento
            // 
            this.evento.AutoSize = true;
            this.evento.BackColor = System.Drawing.Color.Transparent;
            this.evento.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.evento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.evento.Location = new System.Drawing.Point(1465, 114);
            this.evento.Name = "evento";
            this.evento.Size = new System.Drawing.Size(160, 24);
            this.evento.TabIndex = 7;
            this.evento.Text = "Concierto Melendi";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.fecha.Location = new System.Drawing.Point(1465, 161);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(120, 24);
            this.fecha.TabIndex = 8;
            this.fecha.Text = "10/03/2022";
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
            this.btnSiguiente.Location = new System.Drawing.Point(831, 874);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(249, 84);
            this.btnSiguiente.TabIndex = 10;
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
            this.btnAgregar.BorderSize = 2;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Paper Daisy DEMO", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.Location = new System.Drawing.Point(499, 553);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(330, 85);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "AGREGAR MOCHILERO";
            this.btnAgregar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.boton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.Transparent;
            this.btnMC.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnMC.BorderRaius = 40;
            this.btnMC.BorderSize = 2;
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("Paper Daisy DEMO", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnMC.Location = new System.Drawing.Point(151, 727);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(263, 78);
            this.btnMC.TabIndex = 11;
            this.btnMC.Text = "CONSULTAR MOCHILEROS CERVEZA";
            this.btnMC.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.boton1_Click_1);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.Transparent;
            this.btnMR.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnMR.BorderRaius = 40;
            this.btnMR.BorderSize = 2;
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("Paper Daisy DEMO", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnMR.Location = new System.Drawing.Point(151, 874);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(263, 72);
            this.btnMR.TabIndex = 12;
            this.btnMR.Text = "CONSULTAR MOCHILEROS REFRESCOS";
            this.btnMR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // VentanaMochilero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.evento);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.comboMo);
            this.Controls.Add(this.mochila);
            this.Controls.Add(this.nombreMochilero);
            this.Controls.Add(this.txtNombreM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaMochilero";
            this.Text = "AgregarMochileros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaMochilero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label nombreMochilero;
        private System.Windows.Forms.Label mochila;
        private System.Windows.Forms.ComboBox comboMo;
        private System.Windows.Forms.Label responsable;
        private System.Windows.Forms.Label evento;
        private System.Windows.Forms.Label fecha;
        private Diseño.Boton btnAgregar;
        private Diseño.Boton btnSiguiente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Diseño.Boton btnMC;
        private Diseño.Boton btnMR;
    }
}