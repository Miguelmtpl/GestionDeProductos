﻿using System;
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
        Cerveza c;
        public GestionProductos(String nombre, List<MochileroRefrescos> listaMochilerosR, List<MochileroCerveza> listaMochilerosC, Cerveza c)
        {
            InitializeComponent();
            this.listaMochilerosR = listaMochilerosR;
            this.listaMochilerosC = listaMochilerosC;
            this.nombre = nombre;
            productosMochilero();
            this.c = c;
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
            foreach (var v in listaMochilerosC)
            {
                if (v.Nombre.Equals(nombre))
                {
                    v.Tanquetas = v.Tanquetas + 1;
                }

            }
        }


        private void boton1_Click(object sender, EventArgs e)
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
            foreach (var v in listaMochilerosC)
            {
                if (v.Nombre.Equals(nombre))
                {
                    v.Tanquetas = v.Tanquetas - 1;
                }

            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            foreach (var v in listaMochilerosR)
            {
                if (v.Nombre.Equals(nombre))
                {
                    foreach (var x in v.ListaProductos)
                    {
                        if (x.Nombre.Equals(comboProductos.Text))
                        {
                            x.Cantidad = x.Cantidad + 1;
                        }
                    }
                }

            }
            foreach (var v in listaMochilerosC)
            {
                if (v.Nombre.Equals(nombre))
                {
                    v.Tanquetas = v.Tanquetas + 1;
                }

            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGestion vg = new VentanaGestion(listaMochilerosR, listaMochilerosC, c);
            vg.Show();
        }
    }
}
