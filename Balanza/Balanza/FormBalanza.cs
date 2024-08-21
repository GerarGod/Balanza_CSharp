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


namespace Balanza
{
    public partial class FormBalanza : Form
    {
        bool blnIncicioFormularioSinError=false;
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

            txtIDContenedor.Text =   "";//objTicket.IdContenedor;
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
            

            if (intTipoLectura == 1)
            {
                try
                {
                    //; Configurar la velocidad de transmisión, paridad, bits de datos y bits de parada.ej:9600,E,7,2
                    //Settings = 9600,E,7,2
                    serialPort = new SerialPort();
                    serialPort.PortName = ClsGlobalVariables.strConfigSerialPortName;
                    serialPort.BaudRate = int.Parse(ClsGlobalVariables.strConfigSerialPortBaudios);
                    serialPort.Parity = (Parity)int.Parse(ClsGlobalVariables.strConfigSerialPortParity);
                    serialPort.DataBits = int.Parse(ClsGlobalVariables.strConfigSerialPortBitsDatos);
                    serialPort.StopBits = (StopBits)int.Parse(ClsGlobalVariables.strConfigserialPortBitsStopBits);
                
                    //serialPort.Handshake = Handshake.None;
                    serialPort.Handshake = Handshake.RequestToSend; // Configuración de Hardware Flow Control
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    serialPort.ReadTimeout = 500;
                    serialPort.WriteTimeout = 500;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error Configurando el Puerto. Error:{0},{1}", Environment.NewLine, ex.Message)
                        , "Comfiguracion del Puerto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                       );
                    return;
                }

                try
                {
                    ComenzarLectura();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error al Abrier el puerto. Error:{0},{1}", Environment.NewLine, ex.Message)
                        , "Iniciando Comunicacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                       );
                    return;
                }
            }
            else
            {
                try
                {
                    //; Configurar la velocidad de transmisión, paridad, bits de datos y bits de parada.ej:9600,E,7,2
                    //Settings = 9600,E,7,2
                    serialPort = new SerialPort();
                    serialPort.PortName = ClsGlobalVariables.strConfigSerialPortName;
                    serialPort.BaudRate = int.Parse(ClsGlobalVariables.strConfigSerialPortBaudios);
                    serialPort.Parity = (Parity)int.Parse(ClsGlobalVariables.strConfigSerialPortParity);
                    serialPort.DataBits = int.Parse(ClsGlobalVariables.strConfigSerialPortBitsDatos);
                    serialPort.StopBits = (StopBits)int.Parse(ClsGlobalVariables.strConfigserialPortBitsStopBits);

                    ////serialPort.Handshake = Handshake.None;
                    //serialPort.Handshake = Handshake.RequestToSend; // Configuración de Hardware Flow Control
                    //serialPort.ReadTimeout = 500;
                    //serialPort.WriteTimeout = 500;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error Configurando el Puerto. Error:{0},{1}", Environment.NewLine, ex.Message)
                        , "Comfiguracion del Puerto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                       );
                    return;
                }

                try
                {
                    
                    ComenzarLectura();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error al Abrier el puerto. Error:{0},{1}", Environment.NewLine, ex.Message)
                        , "Iniciando Comunicacion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                       );
                    return;
                }
            }

            IniciarCampos();
        }

        /*************************************/
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            Application.DoEvents();
            
            
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    int bytesToRead = serialPort.BytesToRead;
                    byte[] buffer = new byte[bytesToRead];
                    serialPort.Read(buffer, 0, bytesToRead);
                    string data = Encoding.ASCII.GetString(buffer);

                    //-----receivedData.Append(data);
                    // Escribe los datos recibidos en el archivo de texto
                    LogDatosRecividos("NroLinea:" + lngNroLinea.ToString() + "-receivedData:" + data);

                    ObtenerCodigosAscii(data);
                    this.BeginInvoke(new DelegadoAcceso(si_DataReceived), new object[] { data });
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer del puerto: " + ex.Message);
            }
        }

        private void si_DataReceived(string strMensaje)
        {
            // Definir el carácter STX usando su valor ASCII
            char stx = (char)2;
            // Definir el carácter Chr(13) usando su valor ASCII
            char chr13 = (char)13;
            int intStxPosIni;
            int intPosFinMsj;
            string strMensajeCompleto = "";
            string strPeso = "";
            string strTara = "";
            string strTmpLog = "";



            string srtBufferIndexOf;//prueba  IndexOf
            int lastIndexIndexOf;//prueba  IndexOf

            // ' guardo los datos recividos en el buffer
            this.srtBuffer = this.srtBuffer + strMensaje;
            // Escribe los datos recibidos en el archivo de texto
            LogDatosRecividos("NroLinea:" + lngNroLinea.ToString() + "-srtBuffer:" + srtBuffer);

            srtBufferIndexOf = this.srtBuffer;//prueba  IndexOf

            //' Buscar el inicio de un mensaje válido,dato comienza con <STX>
            //' El carácter \u0002 es un carácter de control en la tabla ASCII y se denomina "Start of Text" (STX).
            //' ASCII del carácter \u0002 es 2
            //' Verificar si el dato comienza con <STX> == Chr(2)
            //'If Asc(Mid(incomingData, 1, 1)) = &H2 Then

            intStxPosIni = srtBuffer.IndexOf(stx);
            if (intStxPosIni > -1)
            {
                intPosFinMsj = srtBuffer.IndexOf(chr13, intStxPosIni);
                if (intPosFinMsj > -1)
                {
                    try
                    {
                        strMensajeCompleto = this.srtBuffer.Substring(intStxPosIni, intPosFinMsj - intStxPosIni);
                        //"\u0002\u0002\u0002*BC123456ABCDEF"
                        // Encuentra la posición del último '\u0002'
                        int lastIndex = strMensajeCompleto.LastIndexOf(stx);
                        strMensajeCompleto = strMensajeCompleto.Substring(lastIndex);

                        strPeso = strMensajeCompleto.Substring(4, 6);
                        strTara = strMensajeCompleto.Substring(10, 6);
                        txtPeso.Text = strPeso;
                        txtTara.Text = strTara;
                        try
                        {
                            txtPesoTotal.Text = (long.Parse(strPeso.ToString()) + long.Parse(strTara.ToString())).ToString();
                        }
                        catch (Exception ex) {
                            txtPesoTotal.Text = "0";
                            //LogDatosRecividos("Error obteniendo pesos: " + ex.Message);
                        }
                        txtPesoTk.Text = txtPesoTotal.Text;

                    }
                    catch (Exception ex)
                    {
                        LogDatosRecividos("Error obteniendo strMensajeCompleto: " + ex.Message);
                        
                    }
                    // Aquí puedes procesar los datos recibidos según el protocolo de la balanza
                    strTmpLog = "NroLinea:" + lngNroLinea.ToString()
                                + "|strMensajeCompleto:" + strMensajeCompleto
                                + "|strMensajeCompletoLength:" + strMensajeCompleto.Length.ToString()
                                + "|strPeso:" + strPeso
                                + "|strPesoLength:" + strPeso.Length.ToString()
                                + "|strTara:" + strTara
                                + "|strTaraLength:" + strTara.Length.ToString()
                                + "|intStxPosIni:" + intStxPosIni.ToString()
                                + "|intPosFinMsj:" + intPosFinMsj.ToString();

                   //logFile.WriteLine
                    LogDatosRecividos(strTmpLog);
                    this.srtBuffer = "";
                    ++this.lngNroLinea;
                }
            }
            //////////seccion prueba IndexOf
            ////////lastIndexIndexOf = srtBufferIndexOf.IndexOf(stx);

            ////////if (lastIndexIndexOf > -1)
            ////////{
            ////////    srtBufferIndexOf = srtBufferIndexOf.Substring(lastIndexIndexOf);
            ////////    if (srtBufferIndexOf.Length >= 17)
            ////////    {
            ////////        srtBufferIndexOf = srtBufferIndexOf.Substring(0, 16);
            ////////        strTmpLog = "seccion prueba IndexOf," + lngNroLinea.ToString()
            ////////                    + "|srtBufferIndexOf:" + srtBufferIndexOf
            ////////                    + "|srtBufferIndexOfLength:" + srtBufferIndexOf.Length.ToString();

            ////////        LogDatosRecividos(strTmpLog);

            ////////    }
            ////////}
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

            if (logFile != null)
            {
                logFile.Close();
            }
            //MessageBox.Show("Lectura del puerto terminada.");
            // Cierra el archivo de texto cuando la aplicación se cierre

        }
        private void CerrarPrueto() {
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
        private void ComenzarLectura() {
            serialPort.Open();
            continuarLeyendo = true;
            if (intTipoLectura == 0) {
                Task.Run(() => leerDatosBalanzaAsync());
                //await leerDatosBalanzaAsync();



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
        {                    // Definir el carácter STX usando su valor ASCII
            char stx = (char)2;
            // Definir el carácter Chr(13) usando su valor ASCII
            char chr13 = (char)13;
            string strMensajeCompleto = "";
            string strPeso = "";
            string strTara = "";
            string strTmpLog = "";
            string strMensaje = "";
            this.srtBuffer = "";

            while (continuarLeyendo)
            {
                try
                {
                    int intStxPosIni;
                    int intPosFinMsj;
                    // Leer datos disponibles en el buffer de entrada
                    strMensaje = serialPort.ReadLine();
                    LogDatosRecividos("NroLinea:" + lngNroLinea.ToString() + "-receivedData:" + strMensaje);

                    ObtenerCodigosAscii(strMensaje);

                    // ' guardo los datos recividos en el buffer
                    this.srtBuffer = this.srtBuffer + strMensaje;
                    // Escribe los datos recibidos en el archivo de texto
                    LogDatosRecividos("NroLinea:" + lngNroLinea.ToString() + "-srtBuffer:" + srtBuffer);

                    //' Buscar el inicio de un mensaje válido,dato comienza con <STX>
                    //' El carácter \u0002 es un carácter de control en la tabla ASCII y se denomina "Start of Text" (STX).
                    //' ASCII del carácter \u0002 es 2
                    //' Verificar si el dato comienza con <STX> == Chr(2)
                    //'If Asc(Mid(incomingData, 1, 1)) = &H2 Then

                    intStxPosIni = srtBuffer.IndexOf(stx);
                    if (intStxPosIni > -1)
                    {
                        intPosFinMsj = srtBuffer.IndexOf(chr13, intStxPosIni);
                        if (intPosFinMsj > -1)
                        {
                            try
                            {
                                strMensajeCompleto = this.srtBuffer.Substring(intStxPosIni, intPosFinMsj - intStxPosIni);
                                //"\u0002\u0002\u0002*BC123456ABCDEF"
                                // Encuentra la posición del último '\u0002'
                                int lastIndex = strMensajeCompleto.LastIndexOf(stx);
                                strMensajeCompleto = strMensajeCompleto.Substring(lastIndex);

                                strPeso = strMensajeCompleto.Substring(4, 6);
                                strTara = strMensajeCompleto.Substring(10, 6);
                                this.Invoke((Action)(() =>
                                {
                                    txtPeso.Text = strPeso;
                                    txtTara.Text = strTara;
                                    try
                                    {
                                        txtPesoTotal.Text = (long.Parse(strPeso.ToString()) + long.Parse(strTara.ToString())).ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        txtPesoTotal.Text = "0";
                                        //LogDatosRecividos("Error obteniendo pesos: " + ex.Message);
                                    }
                                    txtPesoTk.Text = txtPesoTotal.Text;

                                }));

                            }
                            catch (Exception ex)
                            {
                                LogDatosRecividos("Error obteniendo strMensajeCompleto: " + ex.Message);

                            }
                            // Aquí puedes procesar los datos recibidos según el protocolo de la balanza
                            strTmpLog = "NroLinea:" + lngNroLinea.ToString()
                                        + "|strMensajeCompleto:" + strMensajeCompleto
                                        + "|strMensajeCompletoLength:" + strMensajeCompleto.Length.ToString()
                                        + "|strPeso:" + strPeso
                                        + "|strPesoLength:" + strPeso.Length.ToString()
                                        + "|strTara:" + strTara
                                        + "|strTaraLength:" + strTara.Length.ToString()
                                        + "|intStxPosIni:" + intStxPosIni.ToString()
                                        + "|intPosFinMsj:" + intPosFinMsj.ToString();

                            //logFile.WriteLine
                            LogDatosRecividos(strTmpLog);
                            this.srtBuffer = "";
                            ++this.lngNroLinea;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //ex.StackTrace.
                    if (continuarLeyendo)
                    {
                        Console.WriteLine("Error al leer datos: " + ex.Message);
                        MessageBox.Show("Error al leer datos, error: " + ex.Message, "Error leerDatosBalanzaAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmdStop_Click(null, null);
                    }

                }

            }
        }

    }
}
