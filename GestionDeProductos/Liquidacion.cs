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
    public partial class Liquidacion : Form
    {
        Cerveza c;
        List<MochileroRefrescos> listaMochilerosR;
        List<MochileroCerveza> listaMochilerosC;
        String nombre;

        public Liquidacion(String nombre,List<MochileroRefrescos> mochilerosR, List<MochileroCerveza> mochilerosC, Cerveza c)
        {
            this.nombre = nombre;
            this.listaMochilerosC = mochilerosC;
            this.listaMochilerosR = mochilerosR;
            this.c = c;
            calcularDineroAEntregar();
           
            InitializeComponent();
        }
       

        
        private void calcularDineroAEntregar()
        {
            foreach (var v in listaMochilerosR)
            {
                if (v.Nombre.Equals(nombre))
                {
                    foreach (var x in v.ListaProductos)
                    {
                        v.Dinero = v.Dinero + (x.Cantidad*x.Precio);
                    }
                  
                    
                }
               
            }
            foreach (var v in listaMochilerosC)
            {
                if (v.Nombre.Equals(nombre))
                {
                    v.Dinero = (c.Peso / c.CantidadVaso * c.PrecioVaso)*v.Tanquetas;
                }
              
            }
        }
        private void introducirDinero()
        {
            foreach(var v in listaMochilerosR)
            {
                if (v.Nombre.Equals(nombre))
                {

                    dineroE.Text = v.Dinero.ToString();



                }

            }
            foreach (var v in listaMochilerosC)
            {
                if (v.Nombre.Equals(nombre))
                {
                    dineroE.Text = v.Dinero.ToString();

                }

            }

        }

        private void Liquidacion_Load(object sender, EventArgs e)
        {
            foreach (var v in listaMochilerosR)
            {
                if (v.Nombre.Equals(nombre))
                {

                    dineroE.Text = v.Dinero.ToString();
                  
                    
                    
                }

            }
            foreach (var v in listaMochilerosC)
            {
                if (v.Nombre.Equals(nombre))
                {
                    dineroE.Text = v.Dinero.ToString();
                  
                }

            }

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDineroEnt.Text);
            double b = Convert.ToDouble(dineroE.Text);
            diferencia.Text = (a - b).ToString();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
