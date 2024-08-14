namespace Balanza
{
    partial class FormImpresiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImpresiones));
            groupBox1 = new GroupBox();
            cmbMercaderia = new ComboBox();
            label2 = new Label();
            dtpFechaHasta = new DateTimePicker();
            label1 = new Label();
            dtpFechaDesde = new DateTimePicker();
            txtNrotkBusqueda = new TextBox();
            cmdBuscar = new Button();
            chkMercaderia = new CheckBox();
            chkFechas = new CheckBox();
            chkNroTicket = new CheckBox();
            chkUltimoImpreso = new CheckBox();
            dgwImpreciones = new DataGridView();
            IdImpresion = new DataGridViewTextBoxColumn();
            NroTk = new DataGridViewTextBoxColumn();
            FechaHora = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CUIT = new DataGridViewTextBoxColumn();
            CodigoAduana = new DataGridViewTextBoxColumn();
            LotPlanta = new DataGridViewTextBoxColumn();
            LotBalanza = new DataGridViewTextBoxColumn();
            Certificado = new DataGridViewTextBoxColumn();
            ValidadCert = new DataGridViewTextBoxColumn();
            NroPermEmbarque = new DataGridViewTextBoxColumn();
            IdContenedor = new DataGridViewTextBoxColumn();
            IdentificadorBulto = new DataGridViewTextBoxColumn();
            Mercaderia = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtPeso = new TextBox();
            label10 = new Label();
            txtMercaderia = new TextBox();
            label8 = new Label();
            txtIdentificadorBultoTxt = new TextBox();
            label9 = new Label();
            txtIDContenedor = new TextBox();
            label3 = new Label();
            txtNroPermisoEmbarque = new TextBox();
            label7 = new Label();
            txtValidadCert = new TextBox();
            label6 = new Label();
            txtCertificado = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNroTicket = new TextBox();
            cmdImprimir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwImpreciones).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbMercaderia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpFechaHasta);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpFechaDesde);
            groupBox1.Controls.Add(txtNrotkBusqueda);
            groupBox1.Controls.Add(cmdBuscar);
            groupBox1.Controls.Add(chkMercaderia);
            groupBox1.Controls.Add(chkFechas);
            groupBox1.Controls.Add(chkNroTicket);
            groupBox1.Controls.Add(chkUltimoImpreso);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1054, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones de búsqueda";
            // 
            // cmbMercaderia
            // 
            cmbMercaderia.Enabled = false;
            cmbMercaderia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMercaderia.FormattingEnabled = true;
            cmbMercaderia.Location = new Point(127, 114);
            cmbMercaderia.Name = "cmbMercaderia";
            cmbMercaderia.Size = new Size(328, 25);
            cmbMercaderia.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(302, 86);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 11;
            label2.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            dtpFechaHasta.Enabled = false;
            dtpFechaHasta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaHasta.Location = new Point(353, 82);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(104, 25);
            dtpFechaHasta.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(140, 88);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 9;
            label1.Text = "Desde:";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            dtpFechaDesde.Enabled = false;
            dtpFechaDesde.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaDesde.Location = new Point(191, 84);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(104, 25);
            dtpFechaDesde.TabIndex = 5;
            // 
            // txtNrotkBusqueda
            // 
            txtNrotkBusqueda.Enabled = false;
            txtNrotkBusqueda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNrotkBusqueda.Location = new Point(140, 54);
            txtNrotkBusqueda.Name = "txtNrotkBusqueda";
            txtNrotkBusqueda.Size = new Size(155, 25);
            txtNrotkBusqueda.TabIndex = 3;
            txtNrotkBusqueda.KeyPress += txtNrotkBusqueda_KeyPress;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(937, 35);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(95, 75);
            cmdBuscar.TabIndex = 9;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // chkMercaderia
            // 
            chkMercaderia.AutoSize = true;
            chkMercaderia.Enabled = false;
            chkMercaderia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMercaderia.ForeColor = SystemColors.ControlText;
            chkMercaderia.Location = new Point(11, 116);
            chkMercaderia.Name = "chkMercaderia";
            chkMercaderia.Size = new Size(95, 21);
            chkMercaderia.TabIndex = 7;
            chkMercaderia.Text = "Mercaderia";
            chkMercaderia.UseVisualStyleBackColor = true;
            chkMercaderia.CheckedChanged += chkMercaderia_CheckedChanged;
            // 
            // chkFechas
            // 
            chkFechas.AutoSize = true;
            chkFechas.Enabled = false;
            chkFechas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkFechas.ForeColor = SystemColors.ControlText;
            chkFechas.Location = new Point(11, 89);
            chkFechas.Name = "chkFechas";
            chkFechas.Size = new Size(68, 21);
            chkFechas.TabIndex = 4;
            chkFechas.Text = "Fechas";
            chkFechas.UseVisualStyleBackColor = true;
            chkFechas.CheckedChanged += chkFechas_CheckedChanged;
            // 
            // chkNroTicket
            // 
            chkNroTicket.AutoSize = true;
            chkNroTicket.Enabled = false;
            chkNroTicket.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNroTicket.ForeColor = SystemColors.ControlText;
            chkNroTicket.Location = new Point(11, 62);
            chkNroTicket.Name = "chkNroTicket";
            chkNroTicket.Size = new Size(91, 21);
            chkNroTicket.TabIndex = 2;
            chkNroTicket.Text = "Nro Ticket";
            chkNroTicket.UseVisualStyleBackColor = true;
            chkNroTicket.CheckedChanged += chkNroTicket_CheckedChanged;
            // 
            // chkUltimoImpreso
            // 
            chkUltimoImpreso.AutoSize = true;
            chkUltimoImpreso.Checked = true;
            chkUltimoImpreso.CheckState = CheckState.Checked;
            chkUltimoImpreso.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkUltimoImpreso.ForeColor = SystemColors.ControlText;
            chkUltimoImpreso.Location = new Point(11, 35);
            chkUltimoImpreso.Name = "chkUltimoImpreso";
            chkUltimoImpreso.Size = new Size(123, 21);
            chkUltimoImpreso.TabIndex = 1;
            chkUltimoImpreso.Text = "Ultimo Impreso";
            chkUltimoImpreso.UseVisualStyleBackColor = true;
            chkUltimoImpreso.CheckedChanged += chkUltimoImpreso_CheckedChanged;
            // 
            // dgwImpreciones
            // 
            dgwImpreciones.AllowUserToAddRows = false;
            dgwImpreciones.AllowUserToDeleteRows = false;
            dgwImpreciones.AllowUserToOrderColumns = true;
            dgwImpreciones.BackgroundColor = Color.FromArgb(140, 200, 255);
            dgwImpreciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 158, 81);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwImpreciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwImpreciones.ColumnHeadersHeight = 30;
            dgwImpreciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwImpreciones.Columns.AddRange(new DataGridViewColumn[] { IdImpresion, NroTk, FechaHora, RazonSocial, CUIT, CodigoAduana, LotPlanta, LotBalanza, Certificado, ValidadCert, NroPermEmbarque, IdContenedor, IdentificadorBulto, Mercaderia, Peso });
            dgwImpreciones.Cursor = Cursors.Hand;
            dgwImpreciones.EnableHeadersVisualStyles = false;
            dgwImpreciones.GridColor = Color.FromArgb(0, 122, 204);
            dgwImpreciones.Location = new Point(11, 170);
            dgwImpreciones.Name = "dgwImpreciones";
            dgwImpreciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(29, 84, 148);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 195, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgwImpreciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgwImpreciones.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(140, 200, 255);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(29, 84, 148);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(140, 240, 250);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(29, 84, 148);
            dgwImpreciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgwImpreciones.Size = new Size(1054, 236);
            dgwImpreciones.TabIndex = 10;
            dgwImpreciones.CellClick += dgwImpreciones_CellContentClick;
            dgwImpreciones.CellContentClick += dgwImpreciones_CellContentClick;
            dgwImpreciones.SelectionChanged += dgwImpreciones_SelectionChanged;
            // 
            // IdImpresion
            // 
            IdImpresion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            IdImpresion.DataPropertyName = "IdImpresion";
            IdImpresion.HeaderText = "Id Impresion";
            IdImpresion.Name = "IdImpresion";
            IdImpresion.ReadOnly = true;
            IdImpresion.Visible = false;
            // 
            // NroTk
            // 
            NroTk.DataPropertyName = "NroTk";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            NroTk.DefaultCellStyle = dataGridViewCellStyle2;
            NroTk.HeaderText = "Nro Tk";
            NroTk.Name = "NroTk";
            NroTk.ReadOnly = true;
            // 
            // FechaHora
            // 
            FechaHora.DataPropertyName = "FechaHora";
            FechaHora.HeaderText = "Fecha Hora";
            FechaHora.Name = "FechaHora";
            FechaHora.ReadOnly = true;
            FechaHora.Width = 110;
            // 
            // RazonSocial
            // 
            RazonSocial.DataPropertyName = "RazonSocial";
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Visible = false;
            // 
            // CUIT
            // 
            CUIT.DataPropertyName = "CUIT";
            CUIT.HeaderText = "CUIT";
            CUIT.Name = "CUIT";
            CUIT.ReadOnly = true;
            CUIT.Visible = false;
            // 
            // CodigoAduana
            // 
            CodigoAduana.DataPropertyName = "CodigoAduana";
            CodigoAduana.HeaderText = "Codigo Aduana";
            CodigoAduana.Name = "CodigoAduana";
            CodigoAduana.ReadOnly = true;
            CodigoAduana.Visible = false;
            // 
            // LotPlanta
            // 
            LotPlanta.DataPropertyName = "LotPlanta";
            LotPlanta.HeaderText = "Lot Planta";
            LotPlanta.Name = "LotPlanta";
            LotPlanta.ReadOnly = true;
            LotPlanta.Visible = false;
            // 
            // LotBalanza
            // 
            LotBalanza.DataPropertyName = "LotBalanza";
            LotBalanza.HeaderText = "Lot Balanza";
            LotBalanza.Name = "LotBalanza";
            LotBalanza.ReadOnly = true;
            LotBalanza.Visible = false;
            // 
            // Certificado
            // 
            Certificado.DataPropertyName = "Certificado";
            Certificado.HeaderText = "Certificado";
            Certificado.Name = "Certificado";
            Certificado.ReadOnly = true;
            // 
            // ValidadCert
            // 
            ValidadCert.DataPropertyName = "ValidadCert";
            ValidadCert.HeaderText = "Validad Cert";
            ValidadCert.Name = "ValidadCert";
            ValidadCert.ReadOnly = true;
            // 
            // NroPermEmbarque
            // 
            NroPermEmbarque.DataPropertyName = "NroPermEmbarque";
            NroPermEmbarque.HeaderText = "Nro Permso Embarque";
            NroPermEmbarque.Name = "NroPermEmbarque";
            NroPermEmbarque.ReadOnly = true;
            NroPermEmbarque.Width = 150;
            // 
            // IdContenedor
            // 
            IdContenedor.DataPropertyName = "IdContenedor";
            IdContenedor.HeaderText = "Id Contenedor";
            IdContenedor.Name = "IdContenedor";
            IdContenedor.ReadOnly = true;
            // 
            // IdentificadorBulto
            // 
            IdentificadorBulto.DataPropertyName = "IdentificadorBulto";
            IdentificadorBulto.HeaderText = "Identificador Bulto";
            IdentificadorBulto.Name = "IdentificadorBulto";
            IdentificadorBulto.ReadOnly = true;
            IdentificadorBulto.Width = 150;
            // 
            // Mercaderia
            // 
            Mercaderia.DataPropertyName = "Mercaderia";
            Mercaderia.HeaderText = "Mercaderia";
            Mercaderia.Name = "Mercaderia";
            Mercaderia.ReadOnly = true;
            Mercaderia.Width = 150;
            // 
            // Peso
            // 
            Peso.DataPropertyName = "Peso";
            Peso.HeaderText = "Peso";
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPeso);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtMercaderia);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtIdentificadorBultoTxt);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtIDContenedor);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNroPermisoEmbarque);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtValidadCert);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCertificado);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNroTicket);
            groupBox2.Controls.Add(cmdImprimir);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.MenuHighlight;
            groupBox2.Location = new Point(11, 412);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1054, 154);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ticket";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(210, 121);
            txtPeso.Name = "txtPeso";
            txtPeso.ReadOnly = true;
            txtPeso.Size = new Size(202, 25);
            txtPeso.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.InfoText;
            label10.Location = new Point(11, 124);
            label10.Name = "label10";
            label10.Size = new Size(41, 17);
            label10.TabIndex = 24;
            label10.Text = "Peso:";
            // 
            // txtMercaderia
            // 
            txtMercaderia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMercaderia.Location = new Point(611, 88);
            txtMercaderia.Name = "txtMercaderia";
            txtMercaderia.ReadOnly = true;
            txtMercaderia.Size = new Size(202, 25);
            txtMercaderia.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.InfoText;
            label8.Location = new Point(412, 91);
            label8.Name = "label8";
            label8.Size = new Size(190, 17);
            label8.TabIndex = 22;
            label8.Text = "Descripcion de la Mercaderia:";
            // 
            // txtIdentificadorBultoTxt
            // 
            txtIdentificadorBultoTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdentificadorBultoTxt.Location = new Point(210, 88);
            txtIdentificadorBultoTxt.Name = "txtIdentificadorBultoTxt";
            txtIdentificadorBultoTxt.ReadOnly = true;
            txtIdentificadorBultoTxt.Size = new Size(202, 25);
            txtIdentificadorBultoTxt.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.InfoText;
            label9.Location = new Point(11, 91);
            label9.Name = "label9";
            label9.Size = new Size(147, 17);
            label9.TabIndex = 20;
            label9.Text = "Identificador de Bulto:";
            // 
            // txtIDContenedor
            // 
            txtIDContenedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIDContenedor.Location = new Point(611, 57);
            txtIDContenedor.Name = "txtIDContenedor";
            txtIDContenedor.ReadOnly = true;
            txtIDContenedor.Size = new Size(202, 25);
            txtIDContenedor.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(412, 60);
            label3.Name = "label3";
            label3.Size = new Size(122, 17);
            label3.TabIndex = 18;
            label3.Text = "ID de Contenedor:";
            // 
            // txtNroPermisoEmbarque
            // 
            txtNroPermisoEmbarque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNroPermisoEmbarque.Location = new Point(210, 57);
            txtNroPermisoEmbarque.Name = "txtNroPermisoEmbarque";
            txtNroPermisoEmbarque.ReadOnly = true;
            txtNroPermisoEmbarque.Size = new Size(202, 25);
            txtNroPermisoEmbarque.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(518, 33);
            label7.Name = "label7";
            label7.Size = new Size(87, 17);
            label7.TabIndex = 16;
            label7.Text = "Validad Cert:";
            // 
            // txtValidadCert
            // 
            txtValidadCert.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValidadCert.Location = new Point(611, 26);
            txtValidadCert.Name = "txtValidadCert";
            txtValidadCert.ReadOnly = true;
            txtValidadCert.Size = new Size(155, 25);
            txtValidadCert.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.InfoText;
            label6.Location = new Point(258, 34);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 14;
            label6.Text = "Certificado:";
            // 
            // txtCertificado
            // 
            txtCertificado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCertificado.Location = new Point(340, 27);
            txtCertificado.Name = "txtCertificado";
            txtCertificado.ReadOnly = true;
            txtCertificado.Size = new Size(155, 25);
            txtCertificado.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(11, 35);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 12;
            label5.Text = "Nro Ticket:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(11, 60);
            label4.Name = "label4";
            label4.Size = new Size(193, 17);
            label4.TabIndex = 9;
            label4.Text = "Nro de Permiso de Embarque:";
            // 
            // txtNroTicket
            // 
            txtNroTicket.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNroTicket.Location = new Point(93, 28);
            txtNroTicket.Name = "txtNroTicket";
            txtNroTicket.ReadOnly = true;
            txtNroTicket.Size = new Size(155, 25);
            txtNroTicket.TabIndex = 3;
            // 
            // cmdImprimir
            // 
            cmdImprimir.Image = (Image)resources.GetObject("cmdImprimir.Image");
            cmdImprimir.ImageAlign = ContentAlignment.TopCenter;
            cmdImprimir.Location = new Point(937, 40);
            cmdImprimir.Name = "cmdImprimir";
            cmdImprimir.Size = new Size(95, 73);
            cmdImprimir.TabIndex = 9;
            cmdImprimir.Text = "Imprimir";
            cmdImprimir.UseVisualStyleBackColor = true;
            // 
            // FormImpresiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 572);
            Controls.Add(groupBox2);
            Controls.Add(dgwImpreciones);
            Controls.Add(groupBox1);
            Name = "FormImpresiones";
            Text = "Impresiones";
            Load += FormImpresiones_Load;
            Shown += FormImpresiones_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwImpreciones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkMercaderia;
        private CheckBox chkFechas;
        private CheckBox chkNroTicket;
        private CheckBox chkUltimoImpreso;
        private TextBox txtNrotkBusqueda;
        private Button cmdBuscar;
        private DateTimePicker dtpFechaDesde;
        private Label label2;
        private DateTimePicker dtpFechaHasta;
        private Label label1;
        private ComboBox cmbMercaderia;
        private DataGridView dgwImpreciones;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtValidadCert;
        private Label label6;
        private TextBox txtCertificado;
        private Label label5;
        private Label label4;
        private TextBox txtNroTicket;
        private Button cmdImprimir;
        private TextBox txtPeso;
        private Label label10;
        private TextBox txtMercaderia;
        private Label label8;
        private TextBox txtIdentificadorBultoTxt;
        private Label label9;
        private TextBox txtIDContenedor;
        private Label label3;
        private TextBox txtNroPermisoEmbarque;
        private DataGridViewTextBoxColumn IdImpresion;
        private DataGridViewTextBoxColumn NroTk;
        private DataGridViewTextBoxColumn FechaHora;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CUIT;
        private DataGridViewTextBoxColumn CodigoAduana;
        private DataGridViewTextBoxColumn LotPlanta;
        private DataGridViewTextBoxColumn LotBalanza;
        private DataGridViewTextBoxColumn Certificado;
        private DataGridViewTextBoxColumn ValidadCert;
        private DataGridViewTextBoxColumn NroPermEmbarque;
        private DataGridViewTextBoxColumn IdContenedor;
        private DataGridViewTextBoxColumn IdentificadorBulto;
        private DataGridViewTextBoxColumn Mercaderia;
        private DataGridViewTextBoxColumn Peso;
    }
}