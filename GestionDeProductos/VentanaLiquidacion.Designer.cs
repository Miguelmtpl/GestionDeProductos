namespace GestionDeProductos
{
    partial class VentanaLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLiquidacion));
            this.diner = new System.Windows.Forms.Label();
            this.dE = new System.Windows.Forms.Label();
            this.dif = new System.Windows.Forms.Label();
            this.txtDineroEnt = new System.Windows.Forms.TextBox();
            this.dineroE = new System.Windows.Forms.Label();
            this.diferencia = new System.Windows.Forms.Label();
            this.responsable = new System.Windows.Forms.Label();
            this.evento = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLiqui = new GestionDeProductos.Diseño.Boton();
            this.btnCalc = new GestionDeProductos.Diseño.Boton();
            this.nombreMochilero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // diner
            // 
            this.diner.AutoSize = true;
            this.diner.BackColor = System.Drawing.Color.Transparent;
            this.diner.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.diner.Location = new System.Drawing.Point(223, 312);
            this.diner.Name = "diner";
            this.diner.Size = new System.Drawing.Size(236, 36);
            this.diner.TabIndex = 0;
            this.diner.Text = "Dinero a entregar";
            // 
            // dE
            // 
            this.dE.AutoSize = true;
            this.dE.BackColor = System.Drawing.Color.Transparent;
            this.dE.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.dE.Location = new System.Drawing.Point(226, 404);
            this.dE.Name = "dE";
            this.dE.Size = new System.Drawing.Size(237, 36);
            this.dE.TabIndex = 2;
            this.dE.Text = "Dinero Entregado";
            // 
            // dif
            // 
            this.dif.AutoSize = true;
            this.dif.BackColor = System.Drawing.Color.Transparent;
            this.dif.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.dif.Location = new System.Drawing.Point(320, 503);
            this.dif.Name = "dif";
            this.dif.Size = new System.Drawing.Size(139, 36);
            this.dif.TabIndex = 3;
            this.dif.Text = "Diferencia";
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
            // btnLiqui
            // 
            this.btnLiqui.BackColor = System.Drawing.Color.Transparent;
            this.btnLiqui.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLiqui.BorderColor = System.Drawing.Color.LightBlue;
            this.btnLiqui.BorderRaius = 40;
            this.btnLiqui.BorderSize = 2;
            this.btnLiqui.FlatAppearance.BorderSize = 0;
            this.btnLiqui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiqui.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiqui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnLiqui.Location = new System.Drawing.Point(420, 749);
            this.btnLiqui.Name = "btnLiqui";
            this.btnLiqui.Size = new System.Drawing.Size(324, 68);
            this.btnLiqui.TabIndex = 12;
            this.btnLiqui.Text = "FINALIZAR LIQUIDACION";
            this.btnLiqui.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnLiqui.UseVisualStyleBackColor = false;
            this.btnLiqui.Click += new System.EventHandler(this.boton2_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnCalc.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCalc.BorderColor = System.Drawing.Color.LightBlue;
            this.btnCalc.BorderRaius = 40;
            this.btnCalc.BorderSize = 2;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnCalc.Location = new System.Drawing.Point(448, 590);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(272, 38);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "CALCULAR DIFERENCIA";
            this.btnCalc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.boton1_Click);
            // 
            // nombreMochilero
            // 
            this.nombreMochilero.AutoSize = true;
            this.nombreMochilero.BackColor = System.Drawing.Color.Transparent;
            this.nombreMochilero.Font = new System.Drawing.Font("Paper Daisy DEMO", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMochilero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.nombreMochilero.Location = new System.Drawing.Point(530, 169);
            this.nombreMochilero.Name = "nombreMochilero";
            this.nombreMochilero.Size = new System.Drawing.Size(110, 67);
            this.nombreMochilero.TabIndex = 16;
            this.nombreMochilero.Text = "label1";
            // 
            // VentanaLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.nombreMochilero);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.evento);
            this.Controls.Add(this.responsable);
            this.Controls.Add(this.btnLiqui);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.dineroE);
            this.Controls.Add(this.txtDineroEnt);
            this.Controls.Add(this.dif);
            this.Controls.Add(this.dE);
            this.Controls.Add(this.diner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaLiquidacion";
            this.Text = "Liquidacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Liquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diner;
        private System.Windows.Forms.Label dE;
        private System.Windows.Forms.Label dif;
        private System.Windows.Forms.TextBox txtDineroEnt;
        private System.Windows.Forms.Label dineroE;
        private System.Windows.Forms.Label diferencia;
        private Diseño.Boton btnCalc;
        private Diseño.Boton btnLiqui;
        private System.Windows.Forms.Label responsable;
        private System.Windows.Forms.Label evento;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label nombreMochilero;
    }
}