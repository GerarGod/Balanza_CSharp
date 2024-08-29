using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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
        public void SetearReporte() {
            reportViewer1.LocalReport.ReportPath = "Report.rdlc";
            // Crea una lista de parámetros
            List<ReportParameter> parametros = new List<ReportParameter>();

            // Agrega múltiples parámetros

            parametros.Add(new ReportParameter("PtxtFechaHora", objTicket.FechaHora.ToString()));
            parametros.Add(new ReportParameter("PtxtNroTk", objTicket.NroTk.ToString("0000000000")));

            parametros.Add(new ReportParameter("PtxtRaznSocial", objTicket.RazonSocial));

            parametros.Add(new ReportParameter("PtxtCUIL", objTicket.CUIT));
            parametros.Add(new ReportParameter("PtxtCodigoAduana", objTicket.CodigoAduana));
            parametros.Add(new ReportParameter("PtxtLotPlanta", objTicket.LotPlanta));
            parametros.Add(new ReportParameter("PtxtLotBalanza", objTicket.LotBalanza));

            parametros.Add(new ReportParameter("PtxtCertificado", objTicket.Certificado));
            parametros.Add(new ReportParameter("PtxtValidadCert", objTicket.ValidadCert));
            parametros.Add(new ReportParameter("PtxtNroPermEmbarque", objTicket.NroPermEmbarque));
            parametros.Add(new ReportParameter("PtxtIdContenedor", objTicket.IdContenedor));
            parametros.Add(new ReportParameter("PtxtIdentificadorBulto", objTicket.IdentificadorBulto));

            parametros.Add(new ReportParameter("PtxtDescMercaderia", objTicket.Mercaderia));
            parametros.Add(new ReportParameter("PtxtPeso", objTicket.Peso));
            // Asigna los parámetros al ReportViewer
            reportViewer1.LocalReport.SetParameters(parametros);
        }
        
        private void FormTK_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

        }


        private void SaveReportToPdf()
        {
            try
            {
                string fileName = "Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
                string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName); // Save to Desktop by default

                // Configure PDF rendering options (optional)
                string mimeType;
                string encoding;
                string extension;
                string[] streamIds;
                Warning[] warnings;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    format: "PDF",
                    deviceInfo: null, // Use default device settings
                    out mimeType,
                    out encoding,
                    out extension,
                    out streamIds,
                    out warnings);

                if (warnings.Length > 0)
                {
                    // Handle warnings if necessary (optional)
                    StringBuilder warningMessage = new StringBuilder();
                    foreach (Warning warning in warnings)
                    {
                        warningMessage.AppendLine(warning.ToString());
                    }
                    MessageBox.Show("Warning(s) during report rendering:\n" + warningMessage.ToString(), "Report Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                File.WriteAllBytes(savePath, bytes);
                MessageBox.Show("Report saved successfully to: " + savePath, "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving report to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveReportToPdf2()
        {
            try
            {
                // Renderizar el informe a PDF
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string[] streamids;
                Warning[] warnings;
                
                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF",
                    null,
                    out mimeType,
                    out encoding,
                    out extension,
                    out streamids,
                    out warnings);


                // Construir la ruta completa del archivo PDF
                string carpetaTickets = "Tickets"; // Ajusta la ruta si es necesario
                string nombreArchivo = objTicket.NroTk.ToString("0000000000") + ".pdf";//$"Ticket_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"; // Nombre dinámico con fecha y hora
                string rutaCompleta = Path.Combine(carpetaTickets, nombreArchivo);

                // Crear la carpeta si no existe
                Directory.CreateDirectory(carpetaTickets);

                // Guardar el PDF en la ruta especificada
                using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                MessageBox.Show(String.Format("Se generó el archivo {0} , satisfactoriamente ", nombreArchivo)
                , "Guardando Ticket",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepción que pueda ocurrir
                Console.WriteLine("Error al generar el PDF: " + ex.Message);
                // Aquí puedes agregar lógica adicional para manejar la excepción,
                // como registrar el error en un log, mostrar un mensaje al usuario,
                // etc.
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
