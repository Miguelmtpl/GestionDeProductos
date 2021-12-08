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
    public partial class VentanaEvento : Form
    {
        Evento Ev = new Evento();
        public VentanaEvento()
        {
            InitializeComponent();
        }



        private void boton1_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        rellenarEvento();
                        this.Hide();
                        VentanaProducto ventanap = new VentanaProducto(Ev);
                        ventanap.Show();
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(txtNombre, "Por favor rellene el campo organizador solo con letras");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(txtEvento, "Por favor relene el campo evento");
                        break;
                    }

            }
        }
        public void rellenarEvento()
        {
            Ev.Responsable= txtNombre.Text;
            Ev.Nombre= txtEvento.Text;
            Ev.Fecha = date.Value;
        }

        
        int validaciones()
        {
            
            if (!(txtNombre.Text.Replace(" ", String.Empty).All(Char.IsLetter)) || txtNombre.Text=="")
            {
                
                return 1;
            }
            else
            {
                if (txtEvento.Text == "")
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
                
            }
        }
      
       


        }
    }


