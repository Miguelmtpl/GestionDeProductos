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
    public partial class GestionProductos : Form
    {
        String nombre;
        private List<MochileroRefrescos> listaMochilerosR;
        private List<MochileroCerveza> listaMochilerosC;
        public GestionProductos( String nombre,List<MochileroRefrescos> listaMochilerosR, List<MochileroCerveza> listaMochilerosC)
        {
            InitializeComponent();
            this.listaMochilerosR = listaMochilerosR;
            this.listaMochilerosC = listaMochilerosC;
            this.nombre = nombre;
            productosMochilero();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGestion vg=new VentanaGestion(listaMochilerosR,listaMochilerosC);
            vg.Show();
        }
        private void productosMochilero()
        {
            foreach (var v in listaMochilerosR)
            {
                if (v.Nombre.Equals(nombre))
                {
                    foreach (var x in v.ListaProductos)
                    {
                        comboProductos.Items.Add(x.Nombre);
                    }
                }
            }
            foreach(var v in listaMochilerosC)
            {
                if (v.Nombre.Equals(nombre))
                {
                    comboProductos.Items.Add("Tanqueta");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var v in listaMochilerosR)
            {
                if (v.Nombre.Equals(nombre))
                {
                    foreach(var x in v.ListaProductos)
                    {
                        if (x.Nombre.Equals(comboProductos.Text))
                        {
                            x.Cantidad = x.Cantidad + 1;
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var v in listaMochilerosR)
            {
                if (v.Nombre.Equals(nombre))
                {
                    foreach (var x in v.ListaProductos)
                    {
                        if (x.Nombre.Equals(comboProductos.SelectedText))
                        {
                            x.Cantidad = x.Cantidad - 1;
                        }
                    }
                }

            }

        }

       
    }
}
