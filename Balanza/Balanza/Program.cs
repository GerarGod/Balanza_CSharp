using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza
{
    internal static class Program
    {
        //**************************************************************************************
        //--este codigo es para verificar que no se ejecute dos istancias del aplicativo--------
        //**************************************************************************************
        [STAThread]

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);
        //***************************************************************************************
        //---------------------------------------------------------------------------------------
        //***************************************************************************************

        ////**************************************************************************************



        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //**************************************************************************************
            //--este codigo es para verificar que no se ejecute dos istancias del aplicativo--------
            //**************************************************************************************
            bool nuevaInstancia;
            //Recupero el nombre del proceso de la aplicacion
            string proceso = Process.GetCurrentProcess().ProcessName;

            //Busco si hay alguna instancia activa previa de la aplicacion
            using (System.Threading.Mutex mutex = new Mutex(true, proceso, out nuevaInstancia))
            {
                //Si no se encuentra ninguna instancia previa abro la aplicacion
                if (nuevaInstancia)
                {
                    /// Abrir Aplicacion;
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormBalanzaLG());
                }
                //Si existe una instancia previa
                else
                {
                    //Recupero el proceso de la instancia previa
                    Process p = Process.GetProcessesByName(proceso).Where(it => it.Id != Process.GetCurrentProcess().Id).First();
                    //Muestro la ventana
                    ShowWindow(p.MainWindowHandle, 1);
                    //La activo y la paso a primer plano
                    SetForegroundWindow(p.MainWindowHandle);
                }
            }
            //**************************************************************************************
            //--------------------------------------------------------------------------------------
            //**************************************************************************************


       }
    }
}
