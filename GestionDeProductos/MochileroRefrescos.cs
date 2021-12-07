using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class MochileroRefrescos
    {
        String nombre;
        private List<Producto> listaProductos;
        float dinero;

        

        public MochileroRefrescos(String nombre, List<Producto> listaProductos,float dinero)
        {
            this.Nombre = nombre;
            this.listaProductos = listaProductos;
            this.dinero = dinero;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public float Dinero { get => dinero; set => dinero = value; }
    }
}
