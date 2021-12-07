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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDineroEnt = new System.Windows.Forms.TextBox();
            this.dineroE = new System.Windows.Forms.Label();
            this.diferencia = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinero a entregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dinero Entregado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diferencia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finalizar Liquidación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDineroEnt
            // 
            this.txtDineroEnt.Location = new System.Drawing.Point(253, 150);
            this.txtDineroEnt.Name = "txtDineroEnt";
            this.txtDineroEnt.Size = new System.Drawing.Size(100, 20);
            this.txtDineroEnt.TabIndex = 5;
            // 
            // dineroE
            // 
            this.dineroE.AutoSize = true;
            this.dineroE.Location = new System.Drawing.Point(278, 87);
            this.dineroE.Name = "dineroE";
            this.dineroE.Size = new System.Drawing.Size(43, 13);
            this.dineroE.TabIndex = 8;
            this.dineroE.Text = "dineroE";
            // 
            // diferencia
            // 
            this.diferencia.AutoSize = true;
            this.diferencia.Location = new System.Drawing.Point(269, 208);
            this.diferencia.Name = "diferencia";
            this.diferencia.Size = new System.Drawing.Size(35, 13);
            this.diferencia.TabIndex = 9;
            this.diferencia.Text = "label2";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(355, 203);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 10;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 321);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.dineroE);
            this.Controls.Add(this.txtDineroEnt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Liquidacion";
            this.Text = "Ventana8";
            this.Load += new System.EventHandler(this.Liquidacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDineroEnt;
        private System.Windows.Forms.Label dineroE;
        private System.Windows.Forms.Label diferencia;
        private System.Windows.Forms.Button calcular;
    }
}