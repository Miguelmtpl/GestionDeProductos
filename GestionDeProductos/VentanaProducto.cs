using System;
using System.Collections;
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
    public partial class VentanaProducto : Form
    {
        Evento ev;
        Cerveza c = new Cerveza();
         List<Producto> listaProductos = new List<Producto>();
        public VentanaProducto(Evento ev)
        {
            this.ev = ev;
            InitializeComponent();
        }

       private void rellenarCerveza()
        {
            c.Peso= Convert.ToDouble(txtPeso.Text);
            c.CantidadVaso = Convert.ToDouble(txtVaso.Text);
            c.PrecioVaso = Convert.ToDouble(txtPrecioV.Text);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        String nombre = txtproducto.Text;
                        double precio = Convert.ToDouble(txtPrecio.Text);
                        int cantidad = Convert.ToInt32(txtcantidad.Text);
                        listaProductos.Add(new Producto(nombre, precio, cantidad));
                        errorProvider1.SetError(txtproducto, "");
                        errorProvider1.SetError(txtPrecio, "");
                        errorProvider1.SetError(txtcantidad, "");
                        limpiar();

                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtproducto, "Por favor rellene el campo organizador solo con letras");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtPrecio, "Por favor rellene el campo precio solo con números o .");
                        break;
                    }
                case 3:
                    {
                        errorProvider1.SetError(txtcantidad, "Por favor rellene el campo cantidades solo con numeros");
                        break;
                    }

            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            switch (validaciones2())
            {
                case 0:
                    {
                        rellenarCerveza();
                        this.Hide();
                        VentanaMochilero ventm = new VentanaMochilero(listaProductos, c,ev);
                        ventm.Show();
                        errorProvider1.SetError(txtPeso, "");
                        errorProvider1.SetError(txtVaso, "");
                        errorProvider1.SetError(txtPrecioV, "");

                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtPeso, "Por favor rellene el campo cantidad de la tanqueta con un numero decimal");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtVaso, "Por favor rellene el campo vaso con un numero decimal");
                        break;
                    }
                case 3:
                    {
                        errorProvider1.SetError(txtPrecioV, "Por favor rellene el campo precio vaso con un numero decimal");
                        break;
                    }

            }
           
        }

        private void VentanaProducto_Load(object sender, EventArgs e)
        {
            responsable.Text = ev.Responsable;
            evento.Text = ev.Nombre;
            Fecha.Text = ev.Fecha.ToString();
        }
        int validaciones()
        {
            if (!(txtproducto.Text.All(Char.IsLetter) || txtproducto.Text == ""))
                return 1;
            else
            {
                if ( txtPrecio.Text == "")
                {
                    return 2;
                }
                else
                {
                    if (!(txtcantidad.Text.All(Char.IsNumber)) || txtcantidad.Text == "")
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            } 
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            numerosDecimales( sender, e,txtPrecio.Text);
        }
        private void numerosDecimales(object sender, KeyPressEventArgs e,String a)
        {
            char ch = e.KeyChar;

            if (ch == 46 && a.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            numerosDecimales(sender, e,txtPeso.Text);
        }

        private void txtVaso_KeyPress(object sender, KeyPressEventArgs e)
        {
            numerosDecimales(sender, e,txtVaso.Text);
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            numerosDecimales(sender, e,txtPrecioV.Text);
        }
        int validaciones2()
        {
            if (txtPeso.Text == "")
                return 1;
            else
            {
                if (txtVaso.Text == "")
                {
                    return 2;
                }
                else
                {
                    if (txtPrecioV.Text == "")
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }
        private void limpiar()
        {
            txtproducto.Text = "";
            txtPrecio.Text = "";
            txtcantidad.Text = "";
        }
    }
}
