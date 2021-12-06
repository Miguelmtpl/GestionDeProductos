namespace GestionDeProductos
{
    partial class Ventana3
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
            this.btnMochilero = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btngest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMochilero
            // 
            this.btnMochilero.Location = new System.Drawing.Point(261, 61);
            this.btnMochilero.Name = "btnMochilero";
            this.btnMochilero.Size = new System.Drawing.Size(229, 51);
            this.btnMochilero.TabIndex = 0;
            this.btnMochilero.Text = "Agregar Mochileros";
            this.btnMochilero.UseVisualStyleBackColor = true;
            this.btnMochilero.Click += new System.EventHandler(this.btnMochilero_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(261, 171);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(229, 54);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Agregar productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btngest
            // 
            this.btngest.Location = new System.Drawing.Point(261, 295);
            this.btngest.Name = "btngest";
            this.btngest.Size = new System.Drawing.Size(229, 71);
            this.btngest.TabIndex = 2;
            this.btngest.Text = "Iniciar Gestión";
            this.btngest.UseVisualStyleBackColor = true;
            this.btngest.Click += new System.EventHandler(this.btngest_Click);
            // 
            // Ventana3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngest);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnMochilero);
            this.Name = "Ventana3";
            this.Text = "Ventana3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMochilero;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btngest;
    }
}