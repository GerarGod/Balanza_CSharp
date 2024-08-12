using Microsoft.Win32;
using System.Configuration;
using System.Windows.Forms;

namespace Balanza
{
    public partial class FormBalanzaLG : Form
    {
        string strDB_Source;
        string strDB_Provider;
        public FormBalanzaLG()
        {
            InitializeComponent();
            ReadAllSettings();
            ClsGlobalVariables.objdDB = new ClsAccesoDatos(strDB_Source, strDB_Provider);

        }

        private void ReadAllSettings()
        {
            try
            {   
                // Leer configuraciones desde App.config
                ClsGlobalVariables.strConfigPuertoNroCommPort = ConfigurationManager.AppSettings["ConfigPuertoNroCommPort"] ?? "";
                ClsGlobalVariables.strConfigLogDataReceiving = ConfigurationManager.AppSettings["ConfigLogDataReceiving"] ?? "";

                if (ClsGlobalVariables.strConfigPuertoNroCommPort.Length==0)
                {
                    MessageBox.Show("Error reading app settings,no pudo reculerar el valor de strConfigPuertoNroCommPort");
                }
                if (ClsGlobalVariables.strConfigLogDataReceiving.Length == 0)
                {
                    MessageBox.Show("Error reading app settings,no pudo reculerar el valor de strConfigLogDataReceiving");
                }
                this.strDB_Source = ConfigurationManager.AppSettings["DB_Provider"] ?? "";
                this.strDB_Provider = ConfigurationManager.AppSettings["DB_Source"] ?? "";

                if (strDB_Source.Length == 0)
                {
                    MessageBox.Show("Error reading app settings,no pudo reculerar el valor de strDB_Source");
                }
                if (strDB_Provider.Length == 0)
                {
                    MessageBox.Show("Error reading app settings,no pudo reculerar el valor de strDB_Provider");
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Error reading app settings");
                MessageBox.Show("Error reading app settings, error : " + ex.Message);

                
            }
        }
        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");


            }
        }




        private void menuItemBalanza_Click(object sender, EventArgs e)
        {



        }

        private void menuItemAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAcercaDe>();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        // METODO PARA ABRIR UN FORMULARIO DENTRO DEL PANEL.
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = panelPrincipalBalanza.Controls.OfType<MiForm>().FirstOrDefault();
            // si el formulario / instancia no existe

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelPrincipalBalanza.Controls.Add(formulario);
                panelPrincipalBalanza.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }


        private void FormBalanzaLG_Load(object sender, EventArgs e)
        {

        }
    }
}
//https://www.microsoft.com/en-us/microsoft-365/blog/2010/05/10/download-access-2010-runtime-database-engine-redistributable-and-source-code-control/
//Si no tienes instalado Microsoft Access pero deseas trabajar con archivos de base de datos Access (.mdb o .accdb) en tu sistema, puedes seguir estos pasos para configurar tu entorno y asegurarte de que puedas conectarte a la base de datos:

//1.Instalar el Controlador de Access Database Engine
//Para poder trabajar con bases de datos de Access sin tener Microsoft Access instalado, necesitas instalar el controlador de Microsoft Access Database Engine. Este controlador permite a las aplicaciones acceder a datos almacenados en archivos de Access. Aquí te explico cómo hacerlo:

//Descargar el Access Database Engine:
//Access Database Engine 2010: Puedes descargar el controlador desde el Centro de descarga de Microsoft.
//Access Database Engine 2016: También está disponible en el Centro de descarga de Microsoft.
//2. Consideraciones de instalación
//Compatibilidad de versiones: Asegúrate de descargar la versión que sea compatible con la arquitectura de tu sistema operativo (32 bits o 64 bits). También asegúrate de que la versión del controlador sea compatible con la versión de Office instalada (si la tienes).

//Conflictos de instalación: Si ya tienes una versión de Office instalada que no coincide con la arquitectura del controlador que intentas instalar (por ejemplo, Office de 32 bits con un controlador de 64 bits), puede que necesites desinstalar Office temporalmente o usar el parámetro de instalación Passive para forzar la instalación del controlador.

//Ejemplo de comando para instalar en modo pasivo:

///Microsoft Access 2013 Runtime https://www.microsoft.com/es-es/download/details.aspx?id=39358