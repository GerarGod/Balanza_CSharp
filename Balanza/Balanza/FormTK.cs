using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza
{
    public partial class FormTK : Form
    {
        public ClsTicketEntidad objTicket;
        public FormTK()
        {
            InitializeComponent();
        }

        private void FormTK_Load(object sender, EventArgs e)
        {

            //  this.Text = this.strTitulo;

            //  string strLogoReportes = default(string);

            //  strLogoReportes = ConfigurationManager.AppSettings["LogoReportes"].ToString();
            //  strLogoReportes = System.IO.Path.Combine(Application.StartupPath + strLogoReportes);

            //reportViewer1.LocalReport.ReportPath = this.strReportPath;

            //objReporte.ReportPath = Application.StartupPath + "\\ReportesPlantillas\\Plantillas\\RptRetencionLiberacion.rdlc"

            //  /*ReportParameter[] reportParameters = new ReportParameter[1];
            //reportParameters[0] = new ReportParameter("Imagen", Application.StartupPath + strLogoReportes, false);
            // reportViewer1.LocalReport.SetParameters(reportParameters[0]);
            // */

            //  this.reportViewer1.LocalReport.EnableExternalImages = true;
            //  ReportParameter rpLogoReporteParametro = new ReportParameter("Imagen", strLogoReportes);
            //  this.reportViewer1.LocalReport.SetParameters(rpLogoReporteParametro);

            //  ReportDataSource source = new ReportDataSource("DataSet1", dtDatos);
            //  ReportDataSource source = new ReportDataSource(NombreDataSet, dtDatos);
            //  this.reportViewer1.LocalReport.DataSources.Clear();

            //  this.reportViewer1.LocalReport.DataSources.Add(source);

            //  this.reportViewer1.RefreshReport();

            reportViewer1.LocalReport.ReportPath = "Report.rdlc";
            
                        // Crea una lista de parámetros
                        List<ReportParameter> parametros = new List<ReportParameter>();

                        // Agrega múltiples parámetros

                        parametros.Add(new ReportParameter("PtxtFechaHora", objTicket.FechaHora.ToString() ));
                        parametros.Add(new ReportParameter("PtxtNroTk", objTicket.NroTk.ToString("0000000000"))); 

                        parametros.Add(new ReportParameter("PtxtRaznSocial",objTicket.RazonSocial));

                        parametros.Add(new ReportParameter("PtxtCUIL", objTicket.CUIT));
                        parametros.Add(new ReportParameter("PtxtCodigoAduana", objTicket.CodigoAduana));
                        parametros.Add(new ReportParameter("PtxtLotPlanta", objTicket.LotPlanta));
                        parametros.Add(new ReportParameter("PtxtLotBalanza",  objTicket.LotBalanza));

                        parametros.Add(new ReportParameter("PtxtCertificado",  objTicket.Certificado));
                        parametros.Add(new ReportParameter("PtxtValidadCert",objTicket.ValidadCert));
                        parametros.Add(new ReportParameter("PtxtNroPermEmbarque", objTicket.NroPermEmbarque));
                        parametros.Add(new ReportParameter("PtxtIdContenedor", objTicket.IdContenedor));
                        parametros.Add(new ReportParameter("PtxtIdentificadorBulto", objTicket.IdentificadorBulto));

                        parametros.Add(new ReportParameter("PtxtDescMercaderia", objTicket.Mercaderia));
                        parametros.Add(new ReportParameter("PtxtPeso", objTicket.Peso));
                        // Asigna los parámetros al ReportViewer
                        reportViewer1.LocalReport.SetParameters(parametros);
                     


            this.reportViewer1.RefreshReport();

           // return reportViewer.LocalReport.Render("PDF");

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
