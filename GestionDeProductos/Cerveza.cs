using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class Cerveza
    {
        double peso;
        double cantidadVaso;
        double precioVaso;

        public double PrecioVaso { get => precioVaso; set => precioVaso = value; }
        public double CantidadVaso { get => cantidadVaso; set => cantidadVaso = value; }
        public double Peso { get => peso; set => peso = value; }
    }
}
