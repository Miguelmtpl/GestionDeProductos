using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeProductos
{
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
            
            
        }

       

        private void boton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaEvento ventana2 = new VentanaEvento();
            ventana2.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
