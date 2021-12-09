using System;

namespace GestionDeProductos
{
    partial class VentanaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicio));
            this.slogan = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.botonInicio = new GestionDeProductos.Diseño.Boton();
            this.SuspendLayout();
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.BackColor = System.Drawing.Color.Transparent;
            this.slogan.Font = new System.Drawing.Font("Paper Daisy DEMO", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.slogan.Location = new System.Drawing.Point(1145, 259);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(332, 67);
            this.slogan.TabIndex = 0;
            this.slogan.Text = "Crea un nuevo orden";
            this.slogan.Click += new System.EventHandler(this.label1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Paper Daisy DEMO", 135F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.titulo.Location = new System.Drawing.Point(511, 61);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(887, 188);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "MANAGEAPPEVENTS";
           
            // 
            // botonInicio
            // 
            this.botonInicio.BackColor = System.Drawing.Color.Transparent;
            this.botonInicio.BackgroundColor = System.Drawing.Color.Transparent;
            this.botonInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.botonInicio.BorderRaius = 40;
            this.botonInicio.BorderSize = 3;
            this.botonInicio.FlatAppearance.BorderSize = 0;
            this.botonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInicio.Font = new System.Drawing.Font("Paper Daisy DEMO", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.botonInicio.Location = new System.Drawing.Point(803, 660);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(297, 124);
            this.botonInicio.TabIndex = 3;
            this.botonInicio.Text = "INICIO";
            this.botonInicio.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.botonInicio.UseVisualStyleBackColor = false;
            this.botonInicio.Click += new System.EventHandler(this.boton1_Click);
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.botonInicio);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.slogan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Label titulo;
        private Diseño.Boton botonInicio;
    }
}

