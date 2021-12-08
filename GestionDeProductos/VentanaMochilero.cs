﻿using System;
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
        Cerveza c;
        List<Producto> listaProductos = new List<Producto>();
        public VentanaMochilero(List<Producto> listaProductos, Cerveza c)
        {

            InitializeComponent();
            this.listaProductos = listaProductos;
            this.c = c;
        }
        List <MochileroRefrescos> listaMochilerosR = new List<MochileroRefrescos>();
        List<MochileroCerveza> listaMochilerosC = new List<MochileroCerveza>();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGestion vent6  = new VentanaGestion(listaMochilerosR,listaMochilerosC,c);
            vent6.Show();
        }

        

        private void boton1_Click(object sender, EventArgs e)
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

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGestion vent6 = new VentanaGestion(listaMochilerosR, listaMochilerosC, c);
            vent6.Show();
        }
    }
}
