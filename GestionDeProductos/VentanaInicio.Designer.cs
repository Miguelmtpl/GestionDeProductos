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
            this.txtInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonInicio = new GestionDeProductos.Diseño.Boton();
            this.SuspendLayout();
            // 
            // txtInicio
            // 
            this.txtInicio.AutoSize = true;
            this.txtInicio.BackColor = System.Drawing.Color.Transparent;
            this.txtInicio.Font = new System.Drawing.Font("Paper Daisy DEMO", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.txtInicio.Location = new System.Drawing.Point(1145, 259);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(332, 67);
            this.txtInicio.TabIndex = 0;
            this.txtInicio.Text = "Crea un nuevo orden";
            this.txtInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Paper Daisy DEMO", 135F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(570, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 188);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGEAPPEVENTS";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botonInicio
            // 
            this.botonInicio.BackColor = System.Drawing.Color.Transparent;
            this.botonInicio.BackgroundColor = System.Drawing.Color.Transparent;
            this.botonInicio.BorderColor = System.Drawing.Color.LightBlue;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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

        private System.Windows.Forms.Label txtInicio;
        private System.Windows.Forms.Label label1;
        private Diseño.Boton botonInicio;
    }
}

