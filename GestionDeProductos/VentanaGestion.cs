using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace GestionDeProductos
{
    public partial class VentanaGestion : Form
    {
        Cerveza c;
        List<MochileroRefrescos> listaMochilerosR;
        List<MochileroCerveza> listaMochilerosC;

        public VentanaGestion(List<MochileroRefrescos> mochilerosR, List<MochileroCerveza> mochilerosC, Cerveza c)
        {
            this.listaMochilerosR = mochilerosR;
            this.listaMochilerosC = mochilerosC;
            InitializeComponent();
            rellenarCombo();
            this.c = c;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Liquidacion vent8=new Liquidacion(comboNombres.Text, listaMochilerosR, listaMochilerosC,c);
            vent8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionProductos gestionDeProductos=new GestionProductos(comboNombres.Text,listaMochilerosR,listaMochilerosC,c);
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
            generarReporte();

        }
        private void generarReporte()
        {
            SaveFileDialog guardar=new SaveFileDialog();
            guardar.FileName =  "_evento.pdf"+".pdf";
           
            String html=Properties.Resources.Plantilla.ToString();
            html=html.Replace(@)

            if (guardar.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create)) {
                    Document report = new Document(PageSize.A4,25,25,25,25);

                    PdfWriter writer = PdfWriter.GetInstance(report,stream);
                    report.Open();
                   
                    using (StringReader reader = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, report, reader);
                    }

                        report.Close();  
                    stream.Close();
            }
            }
        }
    }
}
