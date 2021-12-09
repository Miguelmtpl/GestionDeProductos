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
            html = html.Replace("@RESPONSABLE",ev.Responsable);
            html = html.Replace("@EVENTO", ev.Nombre);
            html = html.Replace("@FECHA", ev.Fecha.ToString("dd/MM/yyyy"));
            string filas = string.Empty;
            String pro=String.Empty;
            
            foreach (MochileroCerveza c in listaMochilerosC)
            {
                
                filas += "<tr>";
                filas += "<td>" + c.Nombre + "</td>";
                filas += "<td>" + "Tanquetas "+c.Tanquetas + "</td>";
                filas += "<td>" + c.Dinero.ToString()+"€" + "</td>";
                filas += "<td>" + c.DineroEntregado.ToString()+"€" + "</td>";
                filas += "<td>" + (c.DineroEntregado- c.Dinero) + "€" + "</td>";
                filas += "</tr>";
               
            }
           
            foreach (MochileroRefrescos r in listaMochilerosR)
            {
                
                filas += "<tr>";
                filas += "<td>" + r.Nombre + "</td>";
                filas += "<td>";
                foreach (Producto p in r.ListaProductos ){
                    filas += "\n"+ p.Nombre +"  "+ p.Cantidad.ToString();
                }
                filas += "</td>";
                filas += "<td>" + r.Dinero + "€" + "</td>";
                filas += "<td>" + r.DineroEntregado + "€" + "</td>";
                filas += "<td>" + (r.DineroEntregado - r.Dinero) + "€" + "</td>";
                filas += "</tr>";

            }
            html = html.Replace("@FILAS", filas);
            

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
                VentanaGestionProductos gestionDeProductos = new VentanaGestionProductos(comboNombres.Text, listaMochilerosR, listaMochilerosC, c,ev);
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
                VentanaLiquidacion vent8 = new VentanaLiquidacion(comboNombres.Text, listaMochilerosR, listaMochilerosC, c,ev);
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
