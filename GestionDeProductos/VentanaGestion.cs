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
        Evento ev;
        Cerveza c;
        List<MochileroRefrescos> listaMochilerosR;
        List<MochileroCerveza> listaMochilerosC;

        public VentanaGestion(List<MochileroRefrescos> mochilerosR, List<MochileroCerveza> mochilerosC, Cerveza c,Evento ev)
        {
            this.listaMochilerosR = mochilerosR;
            this.listaMochilerosC = mochilerosC;
            InitializeComponent();
            rellenarCombo();
            this.c = c;
            this.ev=ev;
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
        private void generarReporte()
        {
            SaveFileDialog guardar=new SaveFileDialog();
            guardar.FileName =  "_evento.pdf"+".pdf";
           
            String html=Properties.Resources.Plantilla.ToString();
            //html=html.Replace(@)

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

        private void boton1_Click(object sender, EventArgs e)
        {
            if (comboNombres.Text == ""){
                errorProvider1.SetError(comboNombres, "Por favor seleccione un mochilero");
            }
            else
            {
                this.Hide();
                GestionProductos gestionDeProductos = new GestionProductos(comboNombres.Text, listaMochilerosR, listaMochilerosC, c,ev);
                gestionDeProductos.Show();
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (comboNombres.Text == "")
            {
                errorProvider1.SetError(comboNombres, "Por favor seleccione un mochilero");
            }
            else
            {
                this.Hide();
                Liquidacion vent8 = new Liquidacion(comboNombres.Text, listaMochilerosR, listaMochilerosC, c,ev);
                vent8.Show();
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            generarReporte();
        }

        private void VentanaGestion_Load(object sender, EventArgs e)
        {
            responsable.Text = ev.Responsable;
            evento.Text = ev.Nombre;
            fecha.Text = ev.Fecha.ToString();
        }
    }
}
