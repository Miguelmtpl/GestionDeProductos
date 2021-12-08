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
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boton1 = new GestionDeProductos.Diseño.Boton();
            this.boton2 = new GestionDeProductos.Diseño.Boton();
            this.SuspendLayout();
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreM.Location = new System.Drawing.Point(613, 243);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(517, 40);
            this.txtNombreM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(192, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del mochilero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(355, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mochila";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboMo
            // 
            this.comboMo.Font = new System.Drawing.Font("Abadi MT Std Extra Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMo.FormattingEnabled = true;
            this.comboMo.Items.AddRange(new object[] {
            "Refrescos",
            "Cerveza"});
            this.comboMo.Location = new System.Drawing.Point(613, 353);
            this.comboMo.Name = "comboMo";
            this.comboMo.Size = new System.Drawing.Size(302, 40);
            this.comboMo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1544, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cristina Gutierrez Leopoldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1544, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Concierto Melendi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1544, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "10/03/2022";
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
            this.boton1.Font = new System.Drawing.Font("Paper Daisy DEMO", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton1.Location = new System.Drawing.Point(585, 488);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(330, 85);
            this.boton1.TabIndex = 9;
            this.boton1.Text = "AGREGAR MOCHILERO";
            this.boton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.Transparent;
            this.boton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.boton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton2.BorderRaius = 40;
            this.boton2.BorderSize = 2;
            this.boton2.FlatAppearance.BorderSize = 0;
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton2.Font = new System.Drawing.Font("Paper Daisy DEMO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton2.Location = new System.Drawing.Point(831, 874);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(249, 84);
            this.boton2.TabIndex = 10;
            this.boton2.Text = "SIGUIENTE";
            this.boton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(203)))), ((int)(((byte)(215)))));
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // VentanaMochilero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionDeProductos.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreM);
            this.MaximizeBox = false;
            this.Name = "VentanaMochilero";
            this.Text = "Ventana4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Diseño.Boton boton1;
        private Diseño.Boton boton2;
    }
}