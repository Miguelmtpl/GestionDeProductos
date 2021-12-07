using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class MochileroCerveza
    {
        String nombre;
        int tanquetas;
        double dinero;
        double dineroEntregado;

        public MochileroCerveza(string nombre, int tanquetas, double dinero,double dineroEntregado)
        {
            this.nombre = nombre;
            this.tanquetas = tanquetas;
            this.dinero = dinero;
            this.dineroEntregado = dineroEntregado;
        }

        public double Dinero { get => dinero; set => dinero = value; }
        public int Tanquetas { get => tanquetas; set => tanquetas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double DineroEntregado { get => dineroEntregado; set => dineroEntregado = value; }
    }
}
