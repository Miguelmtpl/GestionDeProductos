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
    public partial class Ventana3 : Form
    {
        public Ventana3()
        {
            InitializeComponent();
        }

        private void btnMochilero_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana4 vent4 = new Ventana4();
            vent4.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana5 vent5 = new Ventana5();
            vent5.Show();
        }

        private void btngest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana6 vent6 = new Ventana6();
            vent6.Show();
        }
    }
}
