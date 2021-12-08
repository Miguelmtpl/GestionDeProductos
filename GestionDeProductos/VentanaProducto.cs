using System;
using System.Collections;
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
    public partial class VentanaProducto : Form
    {
        Evento ev;
        Cerveza c = new Cerveza();
         List<Producto> listaProductos = new List<Producto>();
        public VentanaProducto(Evento ev)
        {
            this.ev = ev;
            InitializeComponent();
        }

       private void rellenarCerveza()
        {
            c.Peso= Convert.ToDouble(txtPeso.Text);
            c.CantidadVaso = Convert.ToDouble(txtVaso.Text);
            c.PrecioVaso = Convert.ToDouble(txtPrecioV.Text);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            String nombre = txtnombre.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtcantidad.Text);
            listaProductos.Add(new Producto(nombre, precio, cantidad));

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            rellenarCerveza();
            this.Hide();
            VentanaMochilero ventm = new VentanaMochilero(listaProductos, c);
            ventm.Show();
        }

        private void VentanaProducto_Load(object sender, EventArgs e)
        {
            responsable.Text = ev.Responsable;
            evento.Text = ev.Nombre;
            Fecha.Text = ev.Fecha.ToString();
        }
    }
}
