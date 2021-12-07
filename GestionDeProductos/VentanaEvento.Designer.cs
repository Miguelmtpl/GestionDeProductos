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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEnc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nombreEnc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnEnc
            // 
            this.btnEnc.ForeColor = System.Drawing.Color.Black;
            this.btnEnc.Location = new System.Drawing.Point(507, 505);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(198, 44);
            this.btnEnc.TabIndex = 1;
            this.btnEnc.Text = "Aceptar";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 20);
            this.textBox2.TabIndex = 3;
            // 
            // nombreEnc
            // 
            this.nombreEnc.AutoSize = true;
            this.nombreEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEnc.ForeColor = System.Drawing.Color.Yellow;
            this.nombreEnc.Location = new System.Drawing.Point(218, 121);
            this.nombreEnc.Name = "nombreEnc";
            this.nombreEnc.Size = new System.Drawing.Size(170, 20);
            this.nombreEnc.TabIndex = 4;
            this.nombreEnc.Text = "Nombre del encargado";
            this.nombreEnc.Click += new System.EventHandler(this.nombreEnc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(273, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Evento";
            // 
            // fechala
            // 
            this.fechala.AutoSize = true;
            this.fechala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechala.ForeColor = System.Drawing.Color.Yellow;
            this.fechala.Location = new System.Drawing.Point(270, 240);
            this.fechala.Name = "fechala";
            this.fechala.Size = new System.Drawing.Size(64, 24);
            this.fechala.TabIndex = 6;
            this.fechala.Text = "Fecha";
            this.fechala.Click += new System.EventHandler(this.label2_Click);
            // 
            // VentanaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1375, 645);
            this.Controls.Add(this.fechala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreEnc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "VentanaEvento";
            this.Text = "Ventana2";
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

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nombreEnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fechala;
    }
}