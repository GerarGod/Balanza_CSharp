using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Balanza
{
    public partial class FormBalanza : Form
    {
        bool blnIncicioFormularioSinError=false;
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
            }
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
            txtIdentificadorBulto.Text = "";// objTicket.IdentificadorBulto;            
            //txtMercaderia.Text = "";// objTicket.Mercaderia;
            txtPeso.Text = "";// objTicket.Peso;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            IniciarCampos();
        }
    }
}
