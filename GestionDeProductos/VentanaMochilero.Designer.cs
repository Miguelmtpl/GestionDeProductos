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
            this.btnAgrMoc = new System.Windows.Forms.Button();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMo = new System.Windows.Forms.ComboBox();
            this.btnFinMoc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgrMoc
            // 
            this.btnAgrMoc.Location = new System.Drawing.Point(266, 255);
            this.btnAgrMoc.Name = "btnAgrMoc";
            this.btnAgrMoc.Size = new System.Drawing.Size(155, 49);
            this.btnAgrMoc.TabIndex = 0;
            this.btnAgrMoc.Text = "Agregar";
            this.btnAgrMoc.UseVisualStyleBackColor = true;
            this.btnAgrMoc.Click += new System.EventHandler(this.btnAgrMoc_Click);
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(284, 104);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(302, 20);
            this.txtNombreM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del mochilero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mochila";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboMo
            // 
            this.comboMo.FormattingEnabled = true;
            this.comboMo.Items.AddRange(new object[] {
            "Refrescos",
            "Cerveza"});
            this.comboMo.Location = new System.Drawing.Point(284, 172);
            this.comboMo.Name = "comboMo";
            this.comboMo.Size = new System.Drawing.Size(167, 21);
            this.comboMo.TabIndex = 4;
            // 
            // btnFinMoc
            // 
            this.btnFinMoc.Location = new System.Drawing.Point(616, 368);
            this.btnFinMoc.Name = "btnFinMoc";
            this.btnFinMoc.Size = new System.Drawing.Size(75, 23);
            this.btnFinMoc.TabIndex = 5;
            this.btnFinMoc.Text = "Finalizar";
            this.btnFinMoc.UseVisualStyleBackColor = true;
            this.btnFinMoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cristina Gutierrez Leopoldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Concierto Melendi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "10/03/2022";
            // 
            // VentanaMochilero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinMoc);
            this.Controls.Add(this.comboMo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.btnAgrMoc);
            this.Name = "VentanaMochilero";
            this.Text = "Ventana4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgrMoc;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMo;
        private System.Windows.Forms.Button btnFinMoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}