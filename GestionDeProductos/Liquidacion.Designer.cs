namespace GestionDeProductos
{
    partial class Liquidacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDineroEnt = new System.Windows.Forms.TextBox();
            this.dineroE = new System.Windows.Forms.Label();
            this.diferencia = new System.Windows.Forms.Label();
            this.responsable = new System.Windows.Forms.Label();
            this.evento = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.boton2 = new GestionDeProductos.Diseño.Boton();
            this.boton1 = new GestionDeProductos.Diseño.Boton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(223, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinero a entregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(226, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dinero Entregado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(320, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diferencia";
            // 
            // txtDineroEnt
            // 
            this.txtDineroEnt.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDineroEnt.Location = new System.Drawing.Point(659, 393);
            this.txtDineroEnt.Name = "txtDineroEnt";
            this.txtDineroEnt.Size = new System.Drawing.Size(100, 43);
            this.txtDineroEnt.TabIndex = 5;
            this.txtDineroEnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDineroEnt_KeyPress);
            // 
            // dineroE
            // 
            this.dineroE.AutoSize = true;
            this.dineroE.BackColor = System.Drawing.Color.Transparent;
            this.dineroE.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineroE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.dineroE.Location = new System.Drawing.Point(653, 312);
            this.dineroE.Name = "dineroE";
            this.dineroE.Size = new System.Drawing.Size(110, 36);
            this.dineroE.TabIndex = 8;
            this.dineroE.Text = "dineroE";
            // 
            // diferencia
            // 
            this.diferencia.AutoSize = true;
            this.diferencia.BackColor = System.Drawing.Color.Transparent;
            this.diferencia.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.diferencia.Location = new System.Drawing.Point(653, 503);
            this.diferencia.Name = "diferencia";
            this.diferencia.Size = new System.Drawing.Size(173, 36);
            this.diferencia.TabIndex = 9;
            this.diferencia.Text = "DIFERENCIA";
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
            this.responsable.TabIndex = 13;
            this.responsable.Text = "label2";
            // 
            // evento
            // 
            this.evento.AutoSize = true;
            this.evento.BackColor = System.Drawing.Color.Transparent;
            this.evento.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.evento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.evento.Location = new System.Drawing.Point(1465, 127);
            this.evento.Name = "evento";
            this.evento.Size = new System.Drawing.Size(61, 24);
            this.evento.TabIndex = 14;
            this.evento.Text = "label5";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.fecha.Location = new System.Drawing.Point(1465, 192);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(61, 24);
            this.fecha.TabIndex = 15;
            this.fecha.Text = "label6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.Transparent;
            this.boton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.boton2.BorderColor = System.Drawing.Color.LightBlue;
            this.boton2.BorderRaius = 40;
            this.boton2.BorderSize = 2;
            this.boton2.FlatAppearance.BorderSize = 0;
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton2.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton2.Location = new System.Drawing.Point(420, 749);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(324, 68);
            this.boton2.TabIndex = 12;
            this.boton2.Text = "FINALIZAR LIQUIDACION";
            this.boton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.Transparent;
            this.boton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.boton1.BorderColor = System.Drawing.Color.LightBlue;
            this.boton1.BorderRaius = 40;
            this.boton1.BorderSize = 2;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton1.Location = new System.Drawing.Point(448, 590);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(272, 38);
            this.boton1.TabIndex = 11;
            this.boton1.Text = "CALCULAR DIFERENCIA";
            this.boton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // Liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.evento);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.dineroE);
            this.Controls.Add(this.txtDineroEnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Liquidacion";
            this.Text = "Liquidacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Liquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDineroEnt;
        private System.Windows.Forms.Label dineroE;
        private System.Windows.Forms.Label diferencia;
        private Diseño.Boton boton1;
        private Diseño.Boton boton2;
        private System.Windows.Forms.Label responsable;
        private System.Windows.Forms.Label evento;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}