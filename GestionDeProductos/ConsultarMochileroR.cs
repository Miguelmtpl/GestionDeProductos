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
    public partial class ConsultarMochileroR : Form
    {
        List<MochileroRefrescos> listaMochilerosR;
        public ConsultarMochileroR(List<MochileroRefrescos> listaMochilerosR)
        {
            InitializeComponent();
            this.listaMochilerosR = listaMochilerosR;
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            int posicion = tabla.CurrentRow.Index;
            tabla.Rows.RemoveAt(posicion);
            listaMochilerosR.RemoveAt(posicion);

        }

        private void ConsultarMochileroR_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Nombre";
            c1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            tabla.Columns.Add(c1);
            


            foreach (MochileroRefrescos cv in listaMochilerosR)
            {
                tabla.Rows.Add(cv.Nombre);
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

       
    }

