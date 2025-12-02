using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Balanza
{
    public partial class FormBalanza : Form
    {
        bool blnIncicioFormularioSinError = false;
        int intTipoLectura = 0;//0= 


        private SerialPort serialPort;
        //private StringBuilder receivedData = new StringBuilder();
        private delegate void DelegadoAcceso(string accion);
        string nombreArchivo;
        private StreamWriter logFile;

        string srtBuffer;

        long lngNroLinea = 0;

        bool continuarLeyendo = false;


        public FormBalanza()
        {
            InitializeComponent();
        }

        private void FormBalanza_Load(object sender, EventArgs e)
        {
            try
            {
                clsMercaderia clsMercaderia = new clsMercaderia();
                DataTable mercaderiasTable = clsMercaderia.ObtenerMercaderia();
                cmbMercaderia.DisplayMember = "Mercaderia"; // Campo que se mostrará en el ComboBox
                cmbMercaderia.ValueMember = "IdMercaderia";   // Campo que se usará como valor
                cmbMercaderia.DataSource = mercaderiasTable;
                blnIncicioFormularioSinError = true;
            }
            catch (Exception ex) {

                MessageBox.Show(String.Format("Error al obtener las Mercaderias. Error:{0},{1}", Environment.NewLine, ex.Message)
                    , this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
                return;
            }

            if (!ClsGlobalVariables.objImpresion.ObtenerProximoNroTk()) {
                return;
            }

            blnIncicioFormularioSinError = true;
        }


        private void FormBalanza_Shown(object sender, EventArgs e)
        {
            if (!blnIncicioFormularioSinError)
            {
                this.Dispose();
            }
        }
        private void IniciarCampos()
        {
            grbDatosVariables.Enabled = true;
            cmdStop.Enabled = true;
            cmdStart.Enabled = false;

            txtNroTicket.Text = ClsGlobalVariables.objImpresion.NroTk.ToString("0000000000");
            txtCertificado.Text = ClsGlobalVariables.objImpresion.Certificado;
            txtValidadCert.Text = ClsGlobalVariables.objImpresion.ValidadCert;
            txtNroPermisoEmbarque.Text = "";// objTicket.NroPermEmbarque;

            txtIDContenedor.Text = "";//objTicket.IdContenedor;
            txtIdentificadorBultoNro.Text = "";
            //txtIdentificadorBulto.Text = "";// objTicket.IdentificadorBulto;            
            //txtMercaderia.Text = "";// objTicket.Mercaderia;
            txtPesoTk.Text = "";// objTicket.Peso;
            txtPeso.Text = "";
            txtTara.Text = "";
            txtPesoTotal.Text = "";
        }


        private void cmdStart_Click(object sender, EventArgs e)
        {
            SerialConfig cfg;

            try
            {
                // 1️⃣ Cargar configuración del App.config
                cfg = SerialConfigManager.Load();
                ClsGlobalVariables.strConfigLogDataReceiving = cfg.ConfigLogDataReceiving;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error leyendo configuración:{Environment.NewLine}{ex.Message}",
                    "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3️⃣ Crear y configurar el puerto serie
                serialPort = new SerialPort
                {
                    PortName = cfg.PortName,
                    BaudRate = cfg.BaudRate,
                    DataBits = cfg.DataBits,
                    Parity = cfg.Parity,
                    StopBits = cfg.StopBits,
                    Handshake = cfg.Handshake,
                    Encoding = Encoding.GetEncoding(cfg.EncodingName),
                    ReadTimeout = cfg.ReadTimeout,
                    NewLine = SerialConfigManager.HexToAscii(cfg.NewLineHex)
                };

                // 🟢 4️⃣ Abrir puerto y comenzar lectura
                ComenzarLectura();
                IniciarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error abriendo el puerto:{Environment.NewLine}{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
        }
        private void ComenzarLectura()
        {
            serialPort.Open();
            continuarLeyendo = true;
            Task.Run(() => leerDatosBalanzaAsync());

        }

        /**************/

        private void ObtenerCodigosAscii(string cadena)
        {
            char[] caracteres = cadena.ToCharArray();
            int[] codigosAscii = new int[caracteres.Length];
            string srtcadena;

            for (int i = 0; i < caracteres.Length; i++)
            {
                codigosAscii[i] = Convert.ToInt32(caracteres[i]);
                srtcadena = "caracteres:" + caracteres[i] + "-codigosAscii:" + codigosAscii[i].ToString();
                LogDatosRecividos(srtcadena);

            }

        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            continuarLeyendo = false;
            grbDatosVariables.Enabled = false;
            cmdStop.Enabled = false;
            cmdStart.Enabled = true;
            CerrarPrueto();

        }
        private void CerrarPrueto()
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar el puerto: " + ex.Message);
            }
        }


        private void LogDatosRecividos(string strDatos) {
            try
            {
                if (ClsGlobalVariables.strConfigLogDataReceiving == "S")
                {
                    if (logFile == null)
                    {
                        // Obtener la fecha y hora actual
                        DateTime now = DateTime.Now;
                        string strArchivo = $"{now:yyyyMMdd_HHmmss}";
                        nombreArchivo = $"{strArchivo}.txt";

                        // Abre el archivo de texto para registro continuo de datos
                        logFile = new StreamWriter($"{strArchivo}_log.txt", true); // 'true' para añadir datos al final del archivo existente
                        logFile.AutoFlush = true; // Asegura que los datos se escriban inmediatamente en el archivo
                    }

                    logFile.WriteLine(strDatos);

                }
               

            }
            catch (Exception ex)
            {
                // Manejar excepciones si ocurre un error al escribir en el archivo
                Console.WriteLine("Error al escribir en el archivo de log: " + ex.Message);
            }
        }

        /**************************************************Lectura Asincrona ********************************/

        private async Task leerDatosBalanzaAsync()
        {
            char STX = (char)2;   // Inicio de texto
            char CR = (char)13;   // Carriage Return (fin de mensaje)

            string buffer = "";
            string mensaje = "";
            string peso = "";
            string tara = "";
            string Total = "";

            while (continuarLeyendo)
            {
                try
                {
                    int byteLeido = serialPort.ReadByte(); // lectura bloqueante
                    if (byteLeido == -1) continue;

                    char c = (char)byteLeido;

                    if (c == STX)
                    {
                        // Nuevo mensaje
                        mensaje = "";
                        mensaje += c;
                    }
                    else if (c == CR)
                    {
                        // Fin de mensaje
                        LogDatosRecividos("Mensaje recibido: " + mensaje);
                        ObtenerCodigosAscii(mensaje);

                        // Ejemplo: *0 000006000000
                        if (mensaje.Length >= 14)
                        {
                            try
                            {
                                peso = mensaje.Substring(4, 6);
                                tara = mensaje.Substring(10, 6);
                                try
                                {
                                    Total = (long.Parse(peso) + long.Parse(tara)).ToString();
                                }
                                catch
                                {
                                    Total = "0";
                                }
                                this.Invoke((Action)(() =>
                                {
                                    txtPeso.Text = peso;
                                    txtTara.Text = tara;
                                    txtPesoTotal.Text = Total;
                                    txtPesoTk.Text = txtPesoTotal.Text;

                                }));
                                /*
                                if (lstLectura.InvokeRequired)
                                {
                                    lstLectura.Invoke(new Action(() =>
                                    {
                                        lstLectura.Items.Add("   " + peso + "   -     " + tara + "    -   " + Total);
                                        lstLectura.TopIndex = lstResultados.Items.Count - 1;
                                    }));
                                }
                                else
                                {
                                    lstLectura.Items.Add(peso + " - " + tara);
                                    lstLectura.TopIndex = lstResultados.Items.Count - 1;
                                }
                                */
                                LogDatosRecividos($"Peso:{peso} Tara:{tara}");
                            }
                            catch (Exception ex)
                            {
                                LogDatosRecividos("Error parseando mensaje: " + ex.Message);
                            }
                        }

                        mensaje = "";
                    }
                    else
                    {
                        mensaje += c;
                    }
                }
                catch (TimeoutException)
                {
                    // no hay datos, continuar leyendo
                }
                catch (Exception ex)
                {
                    if (continuarLeyendo)
                    {
                        LogDatosRecividos("Error al leer: " + ex.Message);
                    }
                }
            }
        }

        private void cmdGenerarTK_Click(object sender, EventArgs e)
        {

            if (txtCertificado.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Certificado'' no puede estar sin datos", "Generarndo Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCertificado.Focus();
                return;
            }
            if (txtValidadCert.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Validad Cert'' no puede estar sin datos", "Generarndo Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValidadCert.Focus();
                return;
            }

            if (txtNroPermisoEmbarque.Text.Length == 0)
            {

                MessageBox.Show("El campo ''Nro de Permiso de Embarque'' no puede estar sin datos", "Generarndo Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNroPermisoEmbarque.Focus();
                return;
            }
            if (txtIDContenedor.Text.Length == 0)
            {
                MessageBox.Show("El campo ''ID de Contenedor'' no puede estar sin datos", "Generarndo Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDContenedor.Focus();
                return;
            }
            if ((txtIdentificadorBulto.Text.Length + txtIdentificadorBultoNro.Text.Length) == 0)
            {
                MessageBox.Show("El campo ''Identificador de Bulto'' no puede estar sin datos", "Generarndo Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdentificadorBulto.Focus();
                return;
            }
            if (cmbMercaderia.Text.Length == 0)
            {

                MessageBox.Show("El campo ''Descripcion de la Mercaderia'' no puede estar sin datos", "Generarndo Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMercaderia.Focus();
                return;
            }

            if (txtPeso.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Peso (KG)'' no puede estar sin datos", "Generarndo Impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cmdStop_Click(null, null);
            try { 
                // ClsTicketEntidad objTicket;
                ClsGlobalVariables.objImpresion.FechaHora = DateTime.Now;
                ClsGlobalVariables.objImpresion.NroPermEmbarque = txtNroPermisoEmbarque.Text;
                ClsGlobalVariables.objImpresion.IdContenedor = txtIDContenedor.Text;
                ClsGlobalVariables.objImpresion.IdentificadorBulto = txtIdentificadorBulto.Text + txtIdentificadorBultoNro.Text;
                ClsGlobalVariables.objImpresion.IdMercaderia = cmbMercaderia.SelectedValue.ToString();
                ClsGlobalVariables.objImpresion.Mercaderia = cmbMercaderia.Text;
                ClsGlobalVariables.objImpresion.Peso = txtPeso.Text;


                if (!ClsGlobalVariables.objImpresion.InsertarImpresion()) {
                    MessageBox.Show("No pudo guardar los datos del Ticket en la base de datos", "Guardando Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //cargo el reporte 
                FormTK objReporte = new FormTK();

                objReporte.objTicket = ClsGlobalVariables.objImpresion;

                objReporte.SetearReporte();

                if (rdbGenerarArchivo.Checked) {
                    objReporte.SaveReportToPdf2();
                }
                if (rdbGenerarArchivoVisualizar.Checked)
                {
                    objReporte.SaveReportToPdf2();
                    objReporte.ShowDialog();

                }
                if (rdbVisualizar.Checked)
                {
                    objReporte.ShowDialog();
                }
                
                if (!ClsGlobalVariables.objImpresion.ObtenerProximoNroTk())
                {
                    return;
                }

            }
            catch(Exception ex) {
      
                    MessageBox.Show(String.Format("Error Generardo Ticket. Error:{0},{1}", Environment.NewLine, ex.Message), "Generando Impresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            finally {
                cmdStart_Click(null, null);
            }

        }

        private void txtCertificado_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtCertificado.Text = txtCertificado.Text.ToUpper();
            // Colocar el cursor al final del texto
            txtCertificado.SelectionStart = txtCertificado.Text.Length;
        }

        private void txtValidadCert_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtValidadCert.Text = txtValidadCert.Text.ToUpper();
            // Colocar el cursor al final del texto
            txtValidadCert.SelectionStart = txtValidadCert.Text.Length;
        }

        private void txtNroPermisoEmbarque_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtNroPermisoEmbarque.Text = txtNroPermisoEmbarque.Text.ToUpper();
            // Colocar el cursor al final del texto
            txtNroPermisoEmbarque.SelectionStart = txtNroPermisoEmbarque.Text.Length;
        }

        private void txtIDContenedor_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtIDContenedor.Text = txtIDContenedor.Text.ToUpper();
            // Colocar el cursor al final del texto
            txtIDContenedor.SelectionStart = txtIDContenedor.Text.Length;
        }

        private void txtIdentificadorBulto_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtIdentificadorBulto.Text = txtIdentificadorBulto.Text.ToUpper();
            // Colocar el cursor al final del texto
            txtIdentificadorBulto.SelectionStart = txtIdentificadorBulto.Text.Length;
        }

        private void txtIdentificadorBultoNro_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtIdentificadorBultoNro.Text = txtIdentificadorBultoNro.Text.ToUpper();
            // Colocar el cursor al final del texto
            txtIdentificadorBultoNro.SelectionStart = txtIdentificadorBultoNro.Text.Length;
        }

        private void FormBalanza_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmdStop_Click(null, null);
            if (logFile != null)
            {
                logFile.Close();
            }
        }
    }
}
