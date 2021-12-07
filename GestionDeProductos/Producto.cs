using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class Producto
    {
        private string nombre;
        private double precio;
        private int cantidad;

        public Producto(string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
