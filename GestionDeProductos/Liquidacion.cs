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
        Evento ev;
        Cerveza c;
        List<MochileroRefrescos> listaMochilerosR;
        List<MochileroCerveza> listaMochilerosC;
        String nombre;

        public Liquidacion(String nombre,List<MochileroRefrescos> mochilerosR, List<MochileroCerveza> mochilerosC, Cerveza c,Evento ev)
        {
            this.nombre = nombre;
            this.listaMochilerosC = mochilerosC;
            this.listaMochilerosR = mochilerosR;
            this.c = c;
            this.ev = ev;
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
            nombreMochilero.Text= nombre;
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
            responsable.Text = ev.Responsable;
            evento.Text = ev.Nombre;
            fecha.Text = ev.Fecha.ToString();

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (txtDineroEnt.Text == "")
            {
                errorProvider1.SetError(txtDineroEnt, "Por favor introduzca la cantidad entregada");
            }
            else
            {
                double a = Convert.ToDouble(txtDineroEnt.Text);
                double b = Convert.ToDouble(dineroE.Text);
                diferencia.Text = (a - b).ToString();
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGestion vg = new VentanaGestion(listaMochilerosR, listaMochilerosC, c, ev);
            vg.Show();
        }

        private void txtDineroEnt_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (ch == 46 && txtDineroEnt.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        
    }
}
