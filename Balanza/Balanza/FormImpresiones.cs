using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Balanza
{
    public partial class FormImpresiones : Form
    {
        ClsImpresion objImpresion = new ClsImpresion();
        clsMercaderia clsMercaderia = new clsMercaderia();
        ClsImpresion objImpresionTemp;
        bool blnIncicioFormularioSinError = false;
        public FormImpresiones()
        {
            InitializeComponent();
        }

        private void FormImpresiones_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaDesde.Format = DateTimePickerFormat.Custom;
                dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
                dtpFechaHasta.Format = DateTimePickerFormat.Custom;
                dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
                // Cargar los datos en el ComboBox utilizando el DataTable retornado




                DataTable mercaderiasTable = clsMercaderia.ObtenerMercaderia();
                cmbMercaderia.DisplayMember = "Mercaderia"; // Campo que se mostrará en el ComboBox
                cmbMercaderia.ValueMember = "IdMercaderia";   // Campo que se usará como valor
                cmbMercaderia.DataSource = mercaderiasTable;
                blnIncicioFormularioSinError = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(ex.Message)
                , this.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
        }



        private void chkUltimoImpreso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUltimoImpreso.Checked == true)
            {
                chkNroTicket.Enabled = false;
                chkFechas.Enabled = false;
                chkMercaderia.Enabled = false;


                chkNroTicket.Checked = false;
                chkFechas.Checked = false;
                chkMercaderia.Checked = false;

            }
            else
            {
                chkNroTicket.Enabled = true;
                chkFechas.Enabled = true;
                chkMercaderia.Enabled = true;

            }
        }

        private void chkNroTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNroTicket.Checked == true)
            {
                chkUltimoImpreso.Enabled = false;
                chkFechas.Enabled = false;
                chkMercaderia.Enabled = false;

                chkUltimoImpreso.Checked = false;
                chkFechas.Checked = false;
                chkMercaderia.Checked = false;
                txtNrotkBusqueda.Enabled = true;
            }
            else
            {
                chkUltimoImpreso.Enabled = true;
                chkFechas.Enabled = true;
                chkMercaderia.Enabled = true;
                txtNrotkBusqueda.Enabled = false;

            }
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechas.Checked == true)
            {
                chkNroTicket.Checked = false;
                chkUltimoImpreso.Enabled = false;
                //chkMercaderia.Enabled = false;

                chkNroTicket.Checked = false;
                chkUltimoImpreso.Checked = false;
                //chkMercaderia.Checked = false;
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
            else
            {
                chkNroTicket.Enabled = true;
                chkUltimoImpreso.Enabled = true;
                //chkMercaderia.Enabled = true;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;

            }
        }

        private void chkMercaderia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMercaderia.Checked == true)
            {
                chkNroTicket.Checked = false;
                chkUltimoImpreso.Enabled = false;


                chkNroTicket.Checked = false;
                chkUltimoImpreso.Checked = false;
                cmbMercaderia.Enabled = true;

            }
            else
            {
                chkNroTicket.Enabled = true;
                chkUltimoImpreso.Enabled = true;
                cmbMercaderia.Enabled = false;

            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string strSql;
            string strFechaDesde = dtpFechaDesde.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string strFechaHasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd") + " 23:59:59";

            LimpiarCampos();

            if (!chkUltimoImpreso.Checked && !chkNroTicket.Checked && !chkFechas.Checked && !chkMercaderia.Checked)
            {
                MessageBox.Show("Debe seleccionar una opcion de Busqueda"
                    , this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                return;
            }
            //campos
            strSql = "SELECT Impresiones.IdImpresion, Impresiones.NroTk, Impresiones.FechaHora, Empresa.RazonSocial, Empresa.CUIT, Impresiones.CodigoAduana, Impresiones.LotPlanta, Impresiones.LotBalanza, Impresiones.Certificado, Impresiones.ValidadCert, Impresiones.NroPermEmbarque, Impresiones.IdContenedor, Impresiones.IdentificadorBulto, Mercaderia.Mercaderia, Impresiones.Peso";
            //from
            strSql += " FROM (Empresa INNER JOIN Impresiones ON Empresa.IdEmpresa = Impresiones.IdEmpresa) INNER JOIN Mercaderia ON Impresiones.IdMercaderia = Mercaderia.IdMercaderia";

            if (chkUltimoImpreso.Checked)
            {
                strSql += " WHERE Impresiones.NroTk =(select max( Impresiones.NroTk) from  Impresiones);";
            }

            if (chkNroTicket.Checked)
            {
                if (txtNrotkBusqueda.Text == "")
                {
                    MessageBox.Show("El campo ''Nro Ticket'' no puede estar sin datos"
                                    , this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtNrotkBusqueda.Focus();
                    return;
                }
                strSql += " WHERE Impresiones.NroTk =" + txtNrotkBusqueda.Text + ";";


            }

            //if (chkFechas.Checked)
            //{

            //}

            if (chkMercaderia.Checked)
            {
                if (cmbMercaderia.Text == "")
                {
                    MessageBox.Show("El campo ''Mercaderia'' no puede estar sin datos"
                                    , this.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    cmbMercaderia.Focus();
                    return;
                }
            }
            if (chkFechas.Checked && !chkMercaderia.Checked)
            {
                strSql += " WHERE Impresiones.FechaHora >=#" + strFechaDesde + "# and Impresiones.FechaHora <=#" + strFechaHasta + "#  ;";
            }
            if (!chkFechas.Checked && chkMercaderia.Checked)
            {
                strSql = strSql + " WHERE Impresiones.IdMercaderia=" + cmbMercaderia.SelectedValue.ToString() + ";";

                //operativosComboBox.Items[operativosComboBox.SelectedIndex]
            }
            if (chkFechas.Checked && chkMercaderia.Checked)
            {
                strSql += " WHERE Impresiones.IdMercaderia=" + cmbMercaderia.SelectedValue.ToString() + " and ";
                strSql += " Impresiones.FechaHora >=#" + strFechaDesde + "# and Impresiones.FechaHora <=#" + strFechaHasta + "#  ;";
            }


            try
            {
                dgwImpreciones.DataSource = objImpresion.ObtenerImpresiones(strSql);

                //                lblRegistros.Text = dgwConceptos.Rows.Count.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error Realizando la busqueda. Error:{0},{1}", Environment.NewLine, ex.Message)
                                , this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                               );
            }
        }

        private void FormImpresiones_Shown(object sender, EventArgs e)
        {
            if (!blnIncicioFormularioSinError)
            {
                this.Dispose();
            }
        }

        private void txtNrotkBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = false;
                cmdBuscar_Click(null, null);
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }
        private void dgwImpreciones_SelectionChanged(object sender, EventArgs e)
        {
            // Manejar cambio de selección
            if (dgwImpreciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgwImpreciones.SelectedRows[0];
                // Código para manejar la nueva fila seleccionada
                CargarTk(selectedRow);
            }
        }

        private void dgwImpreciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila en la que se hizo clic
                DataGridViewRow selectedRow = dgwImpreciones.Rows[e.RowIndex];
                CargarTk(selectedRow);
            }
        }
        //private void dgwImprecione_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Manejar cualquier clic en una celda
        //    if (e.RowIndex >= 0)
        //    {
        //        // Obtén la fila en la que se hizo clic
        //        DataGridViewRow selectedRow = dgwImpreciones.Rows[e.RowIndex];
        //        CargarTk(selectedRow);
        //    }
        //}

        private void CargarTk(DataGridViewRow selectedRow)
        {
            LimpiarCampos();
            try
            {
                objImpresionTemp = new ClsImpresion();

                // Accede a los valores de las celdas de la fila seleccionada

                objImpresionTemp.NroTk = long.Parse(selectedRow.Cells["NroTk"].Value.ToString());
                objImpresionTemp.IdImpresion = long.Parse(selectedRow.Cells["IdImpresion"].Value.ToString());
                objImpresionTemp.FechaHora = DateTime.Parse(selectedRow.Cells["FechaHora"].Value.ToString());
                //objImpresionTemp.IdEmpresa = selectedRow.Cells["NombreColumna"].Value.ToString();
                objImpresionTemp.RazonSocial = selectedRow.Cells["RazonSocial"].Value.ToString();

                objImpresionTemp.CUIT = selectedRow.Cells["CUIT"].Value.ToString();
                objImpresionTemp.CodigoAduana = selectedRow.Cells["CodigoAduana"].Value.ToString();
                objImpresionTemp.LotPlanta = selectedRow.Cells["LotPlanta"].Value.ToString();
                objImpresionTemp.LotBalanza = selectedRow.Cells["LotBalanza"].Value.ToString();

                objImpresionTemp.Certificado = selectedRow.Cells["Certificado"].Value.ToString();
                objImpresionTemp.ValidadCert = selectedRow.Cells["ValidadCert"].Value.ToString();
                objImpresionTemp.NroPermEmbarque = selectedRow.Cells["NroPermEmbarque"].Value.ToString();
                objImpresionTemp.IdContenedor = selectedRow.Cells["IdentificadorBulto"].Value.ToString();
                objImpresionTemp.IdentificadorBulto = selectedRow.Cells["IdentificadorBulto"].Value.ToString();
                //objImpresionTemp.IdMercaderia = selectedRow.Cells["IdMercaderia"].Value.ToString();
                objImpresionTemp.Mercaderia = selectedRow.Cells["Mercaderia"].Value.ToString();
                objImpresionTemp.Peso = selectedRow.Cells["Peso"].Value.ToString();


                txtNroTicket.Text = objImpresionTemp.NroTk.ToString();
                txtCertificado.Text = objImpresionTemp.Certificado;
                txtValidadCert.Text = objImpresionTemp.ValidadCert;
                txtNroPermisoEmbarque.Text = objImpresionTemp.NroPermEmbarque;
                txtIDContenedor.Text = objImpresionTemp.IdContenedor;
                txtIdentificadorBultoTxt.Text = objImpresionTemp.IdentificadorBulto;
                txtMercaderia.Text = objImpresionTemp.Mercaderia;
                txtPeso.Text = objImpresionTemp.Peso;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error al cargar el tk seleccionado. Error:{0},{1}", Environment.NewLine, ex.Message)
                                , this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                               );
            }
        }

        private void LimpiarCampos()
        {
            txtNroTicket.Clear();
            txtCertificado.Clear();
            txtValidadCert.Clear();
            txtNroPermisoEmbarque.Clear();
            txtIDContenedor.Clear();
            txtIdentificadorBultoTxt.Clear();
            txtMercaderia.Clear();
            txtPeso.Clear();

        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {

            //cargo el reporte 
            FormTK objReporte = new FormTK();

            /*
            DataTable dataTableSP = objRetencion.ObtenerBeneficiosReporte01(97);
            objUtilidadesControlador.ReportesDataTableRenombrarNombreCampo(ref dataTableSP);
            objReporte.Datos = dataTableSP;
            */
            //objReporte.Datos = objUtilidadesControlador.ReportesObtenerDataTableDeDataGridView(dgwBeneficios);
            //objReporte.NombreDataSet = "RptRetencionLiberacion";
            //objReporte.ReportPath = Application.StartupPath + "\\ReportesPlantillas\\Plantillas\\RptRetencionLiberacion.rdlc";
            //objReporte.Titulo = "Reporte Retención / Liberación";
            objReporte.ShowDialog();


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }





        //private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
        //    // Accede a los valores de las celdas de la fila seleccionada
        //    string valorCelda = selectedRow.Cells["NombreColumna"].Value.ToString();
        //    // Haz algo con los valores obtenidos
        //}


        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Manejar el clic en contenido interactivo
        //    if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["BotonColumn"].Index)
        //    {
        //        // Código para manejar el clic en un botón dentro de una celda
        //    }
        //}


        //private void dgwConceptos_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    LimpiarCampos();
        //    if (e.RowIndex > -1 & txtCodigo.Text != dgwConceptos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString())
        //    {
        //        txtCodigo.Text = dgwConceptos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
        //        txtDescripcion.Text = dgwConceptos.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString();

        //    }
        //}

        //private void LimpiarCampos()
        //{
        //    txtCodigo.Clear();
        //    txtDescripcion.Clear();
        //    txtCodigo.Enabled = false;
        //    txtDescripcion.Enabled = false;

        //}

    }
}
