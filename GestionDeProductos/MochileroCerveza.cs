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
        float dinero;

        public MochileroCerveza(string nombre, int tanquetas, float dinero)
        {
            this.nombre = nombre;
            this.tanquetas = tanquetas;
            this.dinero = dinero;
        }

        public float Dinero { get => dinero; set => dinero = value; }
        public int Tanquetas { get => tanquetas; set => tanquetas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
