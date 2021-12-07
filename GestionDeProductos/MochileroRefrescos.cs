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
        double dinero;
        double dineroEntregado;



        public MochileroRefrescos(String nombre, List<Producto> listaProductos, double dinero,double dineroEntregado)
        {
            this.Nombre = nombre;
            this.listaProductos = listaProductos;
            this.dinero = dinero;
            this.dineroEntregado = dineroEntregado; 
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public double Dinero { get => dinero; set => dinero = value; }
        public double DineroEntregado { get => dineroEntregado; set => dineroEntregado = value; }
    }
}
