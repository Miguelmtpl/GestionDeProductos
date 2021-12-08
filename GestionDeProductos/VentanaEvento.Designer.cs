using System;

namespace GestionDeProductos
{
    partial class VentanaEvento
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.nombreEnc = new System.Windows.Forms.Label();
            this.nombreEv = new System.Windows.Forms.Label();
            this.fechala = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.botonSiguiente = new GestionDeProductos.Diseño.Boton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(602, 541);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(522, 43);
            this.date.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic);
            this.txtNombre.Location = new System.Drawing.Point(602, 266);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(522, 43);
            this.txtNombre.TabIndex = 2;
            // 
            // txtEvento
            // 
            this.txtEvento.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvento.Location = new System.Drawing.Point(602, 396);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(522, 43);
            this.txtEvento.TabIndex = 3;
            // 
            // nombreEnc
            // 
            this.nombreEnc.AutoSize = true;
            this.nombreEnc.BackColor = System.Drawing.Color.Transparent;
            this.nombreEnc.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEnc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.nombreEnc.Location = new System.Drawing.Point(261, 269);
            this.nombreEnc.Name = "nombreEnc";
            this.nombreEnc.Size = new System.Drawing.Size(311, 36);
            this.nombreEnc.TabIndex = 4;
            this.nombreEnc.Text = "Nombre del encargad@";
            this.nombreEnc.Click += new System.EventHandler(this.nombreEnc_Click);
            // 
            // nombreEv
            // 
            this.nombreEv.AutoSize = true;
            this.nombreEv.BackColor = System.Drawing.Color.Transparent;
            this.nombreEv.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.nombreEv.Location = new System.Drawing.Point(471, 399);
            this.nombreEv.Name = "nombreEv";
            this.nombreEv.Size = new System.Drawing.Size(101, 36);
            this.nombreEv.TabIndex = 5;
            this.nombreEv.Text = "Evento";
            // 
            // fechala
            // 
            this.fechala.AutoSize = true;
            this.fechala.BackColor = System.Drawing.Color.Transparent;
            this.fechala.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.fechala.Location = new System.Drawing.Point(481, 541);
            this.fechala.Name = "fechala";
            this.fechala.Size = new System.Drawing.Size(91, 36);
            this.fechala.TabIndex = 6;
            this.fechala.Text = "Fecha";
            this.fechala.Click += new System.EventHandler(this.label2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.botonSiguiente.BackgroundColor = System.Drawing.Color.Transparent;
            this.botonSiguiente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.botonSiguiente.BorderRaius = 40;
            this.botonSiguiente.BorderSize = 2;
            this.botonSiguiente.FlatAppearance.BorderSize = 0;
            this.botonSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSiguiente.Font = new System.Drawing.Font("Paper Daisy DEMO", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.botonSiguiente.Location = new System.Drawing.Point(816, 806);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(308, 79);
            this.botonSiguiente.TabIndex = 7;
            this.botonSiguiente.Text = "SIGUIENTE";
            this.botonSiguiente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.botonSiguiente.UseVisualStyleBackColor = false;
            this.botonSiguiente.Click += new System.EventHandler(this.boton1_Click);
            // 
            // VentanaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.fechala);
            this.Controls.Add(this.nombreEv);
            this.Controls.Add(this.nombreEnc);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.date);
            this.MaximizeBox = false;
            this.Name = "VentanaEvento";
            this.Text = "Evento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void nombreEnc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label nombreEnc;
        private System.Windows.Forms.Label nombreEv;
        private System.Windows.Forms.Label fechala;
        private Diseño.Boton botonSiguiente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}