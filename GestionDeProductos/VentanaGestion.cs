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
    public partial class VentanaGestion : Form
    {
        List<MochileroRefrescos> listaMochilerosR;
        List<MochileroCerveza> listaMochilerosC;

        public VentanaGestion(List<MochileroRefrescos> mochilerosR, List<MochileroCerveza> mochilerosC)
        {
            this.listaMochilerosR = mochilerosR;
            this.listaMochilerosC = mochilerosC;
            InitializeComponent();
            rellenarCombo();

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Ventana8 vent8=new Ventana8();
            vent8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionProductos gestionDeProductos=new GestionProductos(comboNombres.Text,listaMochilerosR,listaMochilerosC);
            gestionDeProductos.Show();

            

        }
        private void rellenarCombo()
        {
            foreach(var v in listaMochilerosR){
                comboNombres.Items.Add(v.Nombre);

            }
            foreach (var w in listaMochilerosC)
            {
                comboNombres.Items.Add(w.Nombre);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaMochilerosR[0].ListaProductos[0].Nombre);
            int x = listaMochilerosR[0].ListaProductos[0].Cantidad;
            MessageBox.Show(x.ToString());

        }
    }
}
