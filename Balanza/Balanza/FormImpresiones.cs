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
    public partial class FormImpresiones : Form
    {
        public FormImpresiones()
        {
            InitializeComponent();
        }

        private void FormImpresiones_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            // Cargar los datos en el ComboBox utilizando el DataTable retornado
            clsMercaderia clsMercaderia = new clsMercaderia();


            DataTable mercaderiasTable = clsMercaderia.ObtenerMercaderia();
            cmbMercaderia.DisplayMember = "Mercaderia"; // Campo que se mostrará en el ComboBox
            cmbMercaderia.ValueMember = "IdMercaderia";   // Campo que se usará como valor
            cmbMercaderia.DataSource = mercaderiasTable;


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
                dtpFechaDesde.Enabled= true;
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
                cmbMercaderia.Enabled= true;

            }
            else
            {
                chkNroTicket.Enabled = true;
                chkUltimoImpreso.Enabled = true;
                cmbMercaderia.Enabled = false;

            }
        }
    }
}
