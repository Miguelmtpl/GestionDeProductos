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
    public partial class VentanaMochilero : Form
    {
        Evento ev;
        Cerveza c;
        List<Producto> listaProductos = new List<Producto>();
        public VentanaMochilero(List<Producto> listaProductos, Cerveza c, Evento ev)
        {

            InitializeComponent();
            this.listaProductos = listaProductos;
            this.c = c;
            this.ev= ev;
        }
        List <MochileroRefrescos> listaMochilerosR = new List<MochileroRefrescos>();
        List<MochileroCerveza> listaMochilerosC = new List<MochileroCerveza>();
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGestion vent6  = new VentanaGestion(listaMochilerosR,listaMochilerosC,c,ev);
            vent6.Show();
        }

        

        private void boton1_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        if (comboMo.Text.Equals("Refrescos"))
                        {
                            listaMochilerosR.Add(new MochileroRefrescos(txtNombreM.Text, listaProductos, 0, 0));
                        }
                        if (comboMo.Text.Equals("Cerveza"))
                        {
                            listaMochilerosC.Add(new MochileroCerveza(txtNombreM.Text, 1, 0, 0));
                        }
                    }
                    break;
                case 1:
                    {
                        errorProvider1.SetError(txtNombreM, "Por favor rellene el campo nombre del mochilero solo con letras");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(comboMo, "Por favor seleccione un tipo de mochila para el mochilero");
                        break;
                    }

            }
            
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGestion vent6 = new VentanaGestion(listaMochilerosR, listaMochilerosC, c,ev);
            vent6.Show();
        }

        private void VentanaMochilero_Load(object sender, EventArgs e)
        {
            responsable.Text = ev.Responsable;
            evento.Text = ev.Nombre;
            fecha.Text = ev.Fecha.ToString();
        }
        int validaciones()
        {
            if (!(txtNombreM.Text.All(Char.IsLetter) || txtNombreM.Text == ""))
                return 1;
            else
            {
                if (comboMo.Text == "")
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
