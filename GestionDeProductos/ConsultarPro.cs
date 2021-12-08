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
    public partial class ConsultarProducto : Form
    {
        List<Producto> listaProductos;
        public ConsultarProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
        }

        

        private void ConsultarPro_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Nombre";
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Precio";
            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Cantidad";

            tabla.Columns.Add(c1);
            tabla.Columns.Add(c2);
            tabla.Columns.Add(c3);
            foreach(Producto p in listaProductos)
            {
                tabla.Rows.Add(p.Nombre,p.Precio,p.Cantidad);
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            int posicion = tabla.CurrentRow.Index;
            tabla.Rows.RemoveAt(posicion);
            listaProductos.RemoveAt(posicion);
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
