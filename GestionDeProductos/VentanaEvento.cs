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
    public partial class VentanaEvento : Form
    {
        Evento Ev = new Evento();
        public VentanaEvento()
        {
            InitializeComponent();
        }

        

        private void boton1_Click(object sender, EventArgs e)
        {
            rellenarEvento();
            this.Hide();
            VentanaProducto ventanap = new VentanaProducto(Ev);
            ventanap.Show();
        }
        private void rellenarEvento()
        {
            Ev.Responsable= txtNombre.Text;
            Ev.Nombre= txtEvento.Text;
            Ev.Fecha = date.Value;
        }

        
    }
}
