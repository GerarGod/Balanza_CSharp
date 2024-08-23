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
    public partial class FormConfiguraciones : Form
    {
        public FormConfiguraciones()
        {
            InitializeComponent();
        }

        private void FormConfiguraciones_Load(object sender, EventArgs e)
        {

            txtPuertoSerie.Text = ConfigurationManager.AppSettings["serialPortName"] ?? "";
            txtBaudios.Text = ConfigurationManager.AppSettings["serialPortBaudios"] ?? "";
            txtBitsDatos.Text = ConfigurationManager.AppSettings["serialPortBitsDatos"] ?? "";
            txtLog.Text = ConfigurationManager.AppSettings["ConfigLogDataReceiving"] ?? "";

            txtValidadCert.Text = ClsGlobalVariables.objImpresion.ValidadCert;
            txtCertificado.Text = ClsGlobalVariables.objImpresion.Certificado;

        }

        private void cmdGuardarPuerto_Click(object sender, EventArgs e)
        {
            if (txtPuertoSerie.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Nro Puerto'' no puede estar sin datos", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPuertoSerie.Focus();
                return;
            }
            if (txtBaudios.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Baudios'' no puede estar sin datos", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBaudios.Focus();
                return;
            }
            if (txtBitsDatos.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Bits'' no puede estar sin datos", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBitsDatos.Focus();
                return;
            }



            try
            {
                ClsGlobalVariables.strConfigSerialPortName = txtPuertoSerie.Text;
                ClsGlobalVariables.strConfigSerialPortBaudios = txtBaudios.Text;
                ClsGlobalVariables.strConfigSerialPortBitsDatos = txtBitsDatos.Text;

                // Cargar la configuración del archivo .config
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["serialPortName"].Value = ClsGlobalVariables.strConfigSerialPortName;
                config.AppSettings.Settings["serialPortBaudios"].Value = ClsGlobalVariables.strConfigSerialPortBaudios;
                config.AppSettings.Settings["serialPortBitsDatos"].Value = ClsGlobalVariables.strConfigSerialPortBitsDatos;

                // Guardar los cambios
                config.Save(ConfigurationSaveMode.Modified);

                // Refrescar la sección para que los cambios tengan efecto
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Configuración Guardada Satisfactoriamente ", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Error Guardando datos. Error:{0},{1}", Environment.NewLine, ex.Message), "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void cmdGuardarLog_Click(object sender, EventArgs e)
        {


            try
            {
                ClsGlobalVariables.strConfigLogDataReceiving = txtLog.Text;
                // Cargar la configuración del archivo .config
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["ConfigLogDataReceiving"].Value = ClsGlobalVariables.strConfigLogDataReceiving;


                // Guardar los cambios
                config.Save(ConfigurationSaveMode.Modified);

                // Refrescar la sección para que los cambios tengan efecto
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Configuración Guardada Satisfactoriamente ", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Error Guardando datos. Error:{0},{1}", Environment.NewLine, ex.Message), "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void cmdGuardarTK_Click(object sender, EventArgs e)
        {
            if (txtCertificado.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Certificado'' no puede estar sin datos", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCertificado.Focus();
                return;
            }
            if (txtValidadCert.Text.Length == 0)
            {
                MessageBox.Show("El campo ''Validad Cert'' no puede estar sin datos", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValidadCert.Focus();
                return;
            }
            
                ClsGlobalVariables.objImpresion.ValidadCert = txtValidadCert.Text;
                ClsGlobalVariables.objImpresion.Certificado = txtCertificado.Text;
            if (ClsGlobalVariables.objImpresion.GurdarParametros())
            {
                MessageBox.Show("Configuración Guardada Satisfactoriamente ", "Guardando Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void txtPuertoSerie_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtPuertoSerie.Text = txtPuertoSerie.Text.ToUpper();
            // txtPuertoSerie el cursor al final del texto
            txtCertificado.SelectionStart = txtPuertoSerie.Text.Length;
        }

        private void txtPuertoSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y algunas teclas especiales
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'C' && e.KeyChar != 'c' &&
                e.KeyChar != 'O' && e.KeyChar != 'm' && e.KeyChar != 'M' &&
                e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void txtBaudios_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números 
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void txtBitsDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void txtLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y algunas teclas especiales
            if (e.KeyChar != 'S' && e.KeyChar != 's' &&
                e.KeyChar != 'n' && e.KeyChar != 'N' &&  e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            ////Convertir el texto a mayúsculas
            txtLog.Text = txtLog.Text.ToUpper();
            // txtPuertoSerie el cursor al final del texto
            txtLog.SelectionStart = txtLog.Text.Length;
        }
    }
}
