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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImpresiones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmbMercaderia = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNrotkBusqueda = new System.Windows.Forms.TextBox();
            this.chkMercaderia = new System.Windows.Forms.CheckBox();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.chkNroTicket = new System.Windows.Forms.CheckBox();
            this.chkUltimoImpreso = new System.Windows.Forms.CheckBox();
            this.dgwImpreciones = new System.Windows.Forms.DataGridView();
            this.IdImpresion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAduana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotBalanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Certificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidadCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPermEmbarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdContenedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorBulto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mercaderia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMercaderia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDContenedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValidadCert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtIdentificadorBultoTxt = new System.Windows.Forms.TextBox();
            this.txtNroPermisoEmbarque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImpreciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscar);
            this.groupBox1.Controls.Add(this.cmbMercaderia);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNrotkBusqueda);
            this.groupBox1.Controls.Add(this.chkMercaderia);
            this.groupBox1.Controls.Add(this.chkFechas);
            this.groupBox1.Controls.Add(this.chkNroTicket);
            this.groupBox1.Controls.Add(this.chkUltimoImpreso);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.Image")));
            this.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBuscar.Location = new System.Drawing.Point(935, 51);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(95, 73);
            this.cmdBuscar.TabIndex = 10;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmbMercaderia
            // 
            this.cmbMercaderia.Enabled = false;
            this.cmbMercaderia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMercaderia.FormattingEnabled = true;
            this.cmbMercaderia.Location = new System.Drawing.Point(147, 114);
            this.cmbMercaderia.Name = "cmbMercaderia";
            this.cmbMercaderia.Size = new System.Drawing.Size(328, 25);
            this.cmbMercaderia.TabIndex = 9;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpFechaHasta.Location = new System.Drawing.Point(371, 84);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(104, 25);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpFechaDesde.Location = new System.Drawing.Point(205, 84);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(104, 25);
            this.dtpFechaDesde.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(315, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(144, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desde:";
            // 
            // txtNrotkBusqueda
            // 
            this.txtNrotkBusqueda.Enabled = false;
            this.txtNrotkBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNrotkBusqueda.Location = new System.Drawing.Point(147, 52);
            this.txtNrotkBusqueda.Name = "txtNrotkBusqueda";
            this.txtNrotkBusqueda.Size = new System.Drawing.Size(155, 25);
            this.txtNrotkBusqueda.TabIndex = 4;
            this.txtNrotkBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNrotkBusqueda.TextChanged += new System.EventHandler(this.txtNrotkBusqueda_TextChanged);
            this.txtNrotkBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrotkBusqueda_KeyPress);
            // 
            // chkMercaderia
            // 
            this.chkMercaderia.AutoSize = true;
            this.chkMercaderia.Enabled = false;
            this.chkMercaderia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkMercaderia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMercaderia.Location = new System.Drawing.Point(18, 117);
            this.chkMercaderia.Name = "chkMercaderia";
            this.chkMercaderia.Size = new System.Drawing.Size(95, 21);
            this.chkMercaderia.TabIndex = 3;
            this.chkMercaderia.Text = "Mercaderia";
            this.chkMercaderia.UseVisualStyleBackColor = true;
            this.chkMercaderia.CheckedChanged += new System.EventHandler(this.chkMercaderia_CheckedChanged);
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Enabled = false;
            this.chkFechas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkFechas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFechas.Location = new System.Drawing.Point(18, 87);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(68, 21);
            this.chkFechas.TabIndex = 2;
            this.chkFechas.Text = "Fechas";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // chkNroTicket
            // 
            this.chkNroTicket.AutoSize = true;
            this.chkNroTicket.Enabled = false;
            this.chkNroTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkNroTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkNroTicket.Location = new System.Drawing.Point(18, 54);
            this.chkNroTicket.Name = "chkNroTicket";
            this.chkNroTicket.Size = new System.Drawing.Size(91, 21);
            this.chkNroTicket.TabIndex = 1;
            this.chkNroTicket.Text = "Nro Ticket";
            this.chkNroTicket.UseVisualStyleBackColor = true;
            this.chkNroTicket.CheckedChanged += new System.EventHandler(this.chkNroTicket_CheckedChanged);
            // 
            // chkUltimoImpreso
            // 
            this.chkUltimoImpreso.AutoSize = true;
            this.chkUltimoImpreso.Checked = true;
            this.chkUltimoImpreso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUltimoImpreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkUltimoImpreso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUltimoImpreso.Location = new System.Drawing.Point(18, 26);
            this.chkUltimoImpreso.Name = "chkUltimoImpreso";
            this.chkUltimoImpreso.Size = new System.Drawing.Size(123, 21);
            this.chkUltimoImpreso.TabIndex = 0;
            this.chkUltimoImpreso.Text = "Ultimo Impreso";
            this.chkUltimoImpreso.UseVisualStyleBackColor = true;
            this.chkUltimoImpreso.CheckedChanged += new System.EventHandler(this.chkUltimoImpreso_CheckedChanged);
            // 
            // dgwImpreciones
            // 
            this.dgwImpreciones.AllowUserToAddRows = false;
            this.dgwImpreciones.AllowUserToDeleteRows = false;
            this.dgwImpreciones.AllowUserToOrderColumns = true;
            this.dgwImpreciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgwImpreciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwImpreciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.dgwImpreciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwImpreciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwImpreciones.ColumnHeadersHeight = 30;
            this.dgwImpreciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwImpreciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdImpresion,
            this.NroTk,
            this.FechaHora,
            this.RazonSocial,
            this.CUIT,
            this.CodigoAduana,
            this.LotPlanta,
            this.LotBalanza,
            this.Certificado,
            this.ValidadCert,
            this.NroPermEmbarque,
            this.IdContenedor,
            this.IdentificadorBulto,
            this.Mercaderia,
            this.Peso});
            this.dgwImpreciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwImpreciones.EnableHeadersVisualStyles = false;
            this.dgwImpreciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgwImpreciones.Location = new System.Drawing.Point(11, 170);
            this.dgwImpreciones.Name = "dgwImpreciones";
            this.dgwImpreciones.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwImpreciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwImpreciones.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.dgwImpreciones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwImpreciones.Size = new System.Drawing.Size(1054, 236);
            this.dgwImpreciones.TabIndex = 1;
            this.dgwImpreciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwImpreciones_CellContentClick);
            this.dgwImpreciones.SelectionChanged += new System.EventHandler(this.dgwImpreciones_SelectionChanged);
            // 
            // IdImpresion
            // 
            this.IdImpresion.DataPropertyName = "IdImpresion";
            this.IdImpresion.HeaderText = "Id Impresion";
            this.IdImpresion.Name = "IdImpresion";
            this.IdImpresion.ReadOnly = true;
            this.IdImpresion.Visible = false;
            this.IdImpresion.Width = 98;
            // 
            // NroTk
            // 
            this.NroTk.DataPropertyName = "NroTk";
            this.NroTk.HeaderText = "Nro Tk";
            this.NroTk.Name = "NroTk";
            this.NroTk.ReadOnly = true;
            this.NroTk.Width = 66;
            // 
            // FechaHora
            // 
            this.FechaHora.DataPropertyName = "FechaHora";
            this.FechaHora.HeaderText = "Fecha Hora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            this.FechaHora.Width = 91;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "RazonSocial";
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Visible = false;
            this.RazonSocial.Width = 98;
            // 
            // CUIT
            // 
            this.CUIT.DataPropertyName = "CUIT";
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Visible = false;
            this.CUIT.Width = 57;
            // 
            // CodigoAduana
            // 
            this.CodigoAduana.DataPropertyName = "CodigoAduana";
            this.CodigoAduana.HeaderText = "Codigo Aduana";
            this.CodigoAduana.Name = "CodigoAduana";
            this.CodigoAduana.ReadOnly = true;
            this.CodigoAduana.Visible = false;
            this.CodigoAduana.Width = 115;
            // 
            // LotPlanta
            // 
            this.LotPlanta.DataPropertyName = "LotPlanta";
            this.LotPlanta.HeaderText = "Lot Planta";
            this.LotPlanta.Name = "LotPlanta";
            this.LotPlanta.ReadOnly = true;
            this.LotPlanta.Visible = false;
            this.LotPlanta.Width = 85;
            // 
            // LotBalanza
            // 
            this.LotBalanza.DataPropertyName = "LotBalanza";
            this.LotBalanza.HeaderText = "Lot Balanza";
            this.LotBalanza.Name = "LotBalanza";
            this.LotBalanza.ReadOnly = true;
            this.LotBalanza.Visible = false;
            this.LotBalanza.Width = 92;
            // 
            // Certificado
            // 
            this.Certificado.DataPropertyName = "Certificado";
            this.Certificado.HeaderText = "Certificado";
            this.Certificado.Name = "Certificado";
            this.Certificado.ReadOnly = true;
            this.Certificado.Width = 89;
            // 
            // ValidadCert
            // 
            this.ValidadCert.DataPropertyName = "ValidadCert";
            this.ValidadCert.HeaderText = "Validad Cert";
            this.ValidadCert.Name = "ValidadCert";
            this.ValidadCert.ReadOnly = true;
            this.ValidadCert.Width = 94;
            // 
            // NroPermEmbarque
            // 
            this.NroPermEmbarque.DataPropertyName = "NroPermEmbarque";
            this.NroPermEmbarque.HeaderText = "Nro Permso Embarquev";
            this.NroPermEmbarque.Name = "NroPermEmbarque";
            this.NroPermEmbarque.ReadOnly = true;
            this.NroPermEmbarque.Width = 157;
            // 
            // IdContenedor
            // 
            this.IdContenedor.DataPropertyName = "IdContenedor";
            this.IdContenedor.HeaderText = "Id Contenedor";
            this.IdContenedor.Name = "IdContenedor";
            this.IdContenedor.ReadOnly = true;
            this.IdContenedor.Width = 107;
            // 
            // IdentificadorBulto
            // 
            this.IdentificadorBulto.DataPropertyName = "IdentificadorBulto";
            this.IdentificadorBulto.HeaderText = "Identificador Bulto";
            this.IdentificadorBulto.Name = "IdentificadorBulto";
            this.IdentificadorBulto.ReadOnly = true;
            this.IdentificadorBulto.Width = 129;
            // 
            // Mercaderia
            // 
            this.Mercaderia.DataPropertyName = "Mercaderia";
            this.Mercaderia.HeaderText = "Mercaderia";
            this.Mercaderia.Name = "Mercaderia";
            this.Mercaderia.ReadOnly = true;
            this.Mercaderia.Width = 90;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtMercaderia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIDContenedor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtValidadCert);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCertificado);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Controls.Add(this.txtIdentificadorBultoTxt);
            this.groupBox2.Controls.Add(this.txtNroPermisoEmbarque);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmdImprimir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNroTicket);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMercaderia
            // 
            this.txtMercaderia.Enabled = false;
            this.txtMercaderia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMercaderia.Location = new System.Drawing.Point(611, 88);
            this.txtMercaderia.Name = "txtMercaderia";
            this.txtMercaderia.ReadOnly = true;
            this.txtMercaderia.Size = new System.Drawing.Size(202, 25);
            this.txtMercaderia.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(418, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Descripcion de la Mercaderia:";
            // 
            // txtIDContenedor
            // 
            this.txtIDContenedor.Enabled = false;
            this.txtIDContenedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtIDContenedor.Location = new System.Drawing.Point(611, 57);
            this.txtIDContenedor.Name = "txtIDContenedor";
            this.txtIDContenedor.ReadOnly = true;
            this.txtIDContenedor.Size = new System.Drawing.Size(202, 25);
            this.txtIDContenedor.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(418, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Id de Contenedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(518, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Validad Cert:";
            // 
            // txtValidadCert
            // 
            this.txtValidadCert.Enabled = false;
            this.txtValidadCert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtValidadCert.Location = new System.Drawing.Point(611, 26);
            this.txtValidadCert.Name = "txtValidadCert";
            this.txtValidadCert.ReadOnly = true;
            this.txtValidadCert.Size = new System.Drawing.Size(155, 25);
            this.txtValidadCert.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(258, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Certificado:";
            // 
            // txtCertificado
            // 
            this.txtCertificado.Enabled = false;
            this.txtCertificado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCertificado.Location = new System.Drawing.Point(340, 27);
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.ReadOnly = true;
            this.txtCertificado.Size = new System.Drawing.Size(155, 25);
            this.txtCertificado.TabIndex = 16;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPeso.Location = new System.Drawing.Point(210, 119);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(202, 25);
            this.txtPeso.TabIndex = 15;
            // 
            // txtIdentificadorBultoTxt
            // 
            this.txtIdentificadorBultoTxt.Enabled = false;
            this.txtIdentificadorBultoTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtIdentificadorBultoTxt.Location = new System.Drawing.Point(210, 88);
            this.txtIdentificadorBultoTxt.Name = "txtIdentificadorBultoTxt";
            this.txtIdentificadorBultoTxt.ReadOnly = true;
            this.txtIdentificadorBultoTxt.Size = new System.Drawing.Size(202, 25);
            this.txtIdentificadorBultoTxt.TabIndex = 14;
            // 
            // txtNroPermisoEmbarque
            // 
            this.txtNroPermisoEmbarque.Enabled = false;
            this.txtNroPermisoEmbarque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNroPermisoEmbarque.Location = new System.Drawing.Point(210, 57);
            this.txtNroPermisoEmbarque.Name = "txtNroPermisoEmbarque";
            this.txtNroPermisoEmbarque.ReadOnly = true;
            this.txtNroPermisoEmbarque.Size = new System.Drawing.Size(202, 25);
            this.txtNroPermisoEmbarque.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(11, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Identificador de Bulto:";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Enabled = false;
            this.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdImprimir.Location = new System.Drawing.Point(935, 51);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(95, 73);
            this.cmdImprimir.TabIndex = 10;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro de Permiso de Embarque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nro Ticket:";
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Enabled = false;
            this.txtNroTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNroTicket.Location = new System.Drawing.Point(93, 28);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.ReadOnly = true;
            this.txtNroTicket.Size = new System.Drawing.Size(155, 25);
            this.txtNroTicket.TabIndex = 4;
            this.txtNroTicket.TextChanged += new System.EventHandler(this.txtNroTicket_TextChanged);
            // 
            // FormImpresiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwImpreciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormImpresiones";
            this.Text = "FormImpresiones";
            this.Load += new System.EventHandler(this.FormImpresiones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwImpreciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMercaderia;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.CheckBox chkNroTicket;
        private System.Windows.Forms.CheckBox chkUltimoImpreso;
        private System.Windows.Forms.TextBox txtNrotkBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMercaderia;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView dgwImpreciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdImpresion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTk;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAduana;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotBalanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidadCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPermEmbarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContenedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorBulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mercaderia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.TextBox txtNroPermisoEmbarque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValidadCert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtIdentificadorBultoTxt;
        private System.Windows.Forms.TextBox txtMercaderia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDContenedor;
        private System.Windows.Forms.Label label9;
    }
}