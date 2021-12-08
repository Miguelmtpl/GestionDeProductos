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
    public partial class Consultar_Mochilero : Form
    {
        List<MochileroCerveza> listaMochilerosC;
        
        public Consultar_Mochilero(List<MochileroCerveza> listaMochilerosC)
        {
            InitializeComponent();
            this.listaMochilerosC = listaMochilerosC;
            
        }

        private void Consultar_Mochilero_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Nombre";
            

            tabla.Columns.Add(c1);
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            foreach (MochileroCerveza cv in listaMochilerosC)
            {
                tabla.Rows.Add(cv.Nombre);
            }
            
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            int posicion = tabla.CurrentRow.Index;
            tabla.Rows.RemoveAt(posicion);
            listaMochilerosC.RemoveAt(posicion);
        }
    }
}
