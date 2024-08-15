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



            PtxtFechaHora = objImpresionTemp.FechaHora;

            PtxtNroTk=objImpresionTemp.NroTk;

            PtxtRaznSocial =objImpresionTemp.RazonSocial;

            PtxtCUIL =objImpresionTemp.CUIT;
            PtxtCodigoAduana =objImpresionTemp.CodigoAduana;
            PtxtLotPlanta =objImpresionTemp.LotPlanta;
            PtxtLotBalanza =objImpresionTemp.LotBalanza;

            PtxtCertificado =objImpresionTemp.Certificado;
            PtxtValidadCert =objImpresionTemp.ValidadCert;
            PtxtNroPermEmbarque =objImpresionTemp.NroPermEmbarque;
            PtxtIdContenedor =objImpresionTemp.IdContenedor;
            PtxtIdentificadorBulto =objImpresionTemp.IdentificadorBulto;

            PtxtDescMercaderia =objImpresionTemp.Mercaderia;
            PtxtPeso =objImpresionTemp.Peso;

            reportViewer1.LocalReport.ReportPath = "Report.rdlc";
            this.reportViewer1.RefreshReport();
  
        }
    }
}
