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
        Cerveza c = new Cerveza();
         List<Producto> listaProductos = new List<Producto>();
        public VentanaProducto()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rellenarCerveza();
            this.Hide();
            VentanaMochilero ventm= new VentanaMochilero(listaProductos,c);
            ventm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = txtnombre.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtcantidad.Text);
            listaProductos.Add(new Producto(nombre, precio, cantidad));
            
            
            
           
        }
        private void rellenarCerveza()
        {
            c.Peso= Convert.ToDouble(txtPeso.Text);
            c.CantidadVaso = Convert.ToDouble(txtVaso.Text);
            c.PrecioVaso = Convert.ToDouble(txtPrecioV.Text);
        }
    }
}
