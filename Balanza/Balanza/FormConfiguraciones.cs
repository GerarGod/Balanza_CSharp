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
            txtValidadCert.Text = ClsGlobalVariables.objImpresion.ValidadCert;
            txtCertificado.Text = ClsGlobalVariables.objImpresion.Certificado;
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


/*

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

        private void txtPuertoSerie_TextChanged(object sender, EventArgs e)
        {

        }
*/
    }
}
