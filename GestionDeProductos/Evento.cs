using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProductos
{
    public class Evento
    {
        String responsable;
        String nombre;
        DateTime fecha;

        public Evento(string responsable, string nombre, DateTime fecha)
        {
            this.responsable = responsable;
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public string Responsable { get => responsable; set => responsable = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
