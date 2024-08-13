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
            groupBox1.SuspendLayout();
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
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones de búsqueda";
            // 
            // cmbMercaderia
            // 
            cmbMercaderia.Enabled = false;
            cmbMercaderia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMercaderia.FormattingEnabled = true;
            cmbMercaderia.Location = new Point(138, 118);
            cmbMercaderia.Name = "cmbMercaderia";
            cmbMercaderia.Size = new Size(328, 25);
            cmbMercaderia.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(313, 90);
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
            dtpFechaHasta.Location = new Point(364, 86);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(104, 25);
            dtpFechaHasta.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(151, 92);
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
            dtpFechaDesde.Location = new Point(202, 88);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(104, 25);
            dtpFechaDesde.TabIndex = 8;
            // 
            // txtNrotkBusqueda
            // 
            txtNrotkBusqueda.Enabled = false;
            txtNrotkBusqueda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNrotkBusqueda.Location = new Point(151, 58);
            txtNrotkBusqueda.Name = "txtNrotkBusqueda";
            txtNrotkBusqueda.Size = new Size(155, 25);
            txtNrotkBusqueda.TabIndex = 7;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(493, 39);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(95, 90);
            cmdBuscar.TabIndex = 6;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // chkMercaderia
            // 
            chkMercaderia.AutoSize = true;
            chkMercaderia.Enabled = false;
            chkMercaderia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMercaderia.ForeColor = SystemColors.ControlText;
            chkMercaderia.Location = new Point(22, 120);
            chkMercaderia.Name = "chkMercaderia";
            chkMercaderia.Size = new Size(95, 21);
            chkMercaderia.TabIndex = 5;
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
            chkFechas.Location = new Point(22, 93);
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
            chkNroTicket.Location = new Point(22, 66);
            chkNroTicket.Name = "chkNroTicket";
            chkNroTicket.Size = new Size(91, 21);
            chkNroTicket.TabIndex = 3;
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
            chkUltimoImpreso.Location = new Point(22, 39);
            chkUltimoImpreso.Name = "chkUltimoImpreso";
            chkUltimoImpreso.Size = new Size(123, 21);
            chkUltimoImpreso.TabIndex = 2;
            chkUltimoImpreso.Text = "Ultimo Impreso";
            chkUltimoImpreso.UseVisualStyleBackColor = true;
            chkUltimoImpreso.CheckedChanged += chkUltimoImpreso_CheckedChanged;
            // 
            // FormImpresiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormImpresiones";
            Text = "Impresiones";
            Load += FormImpresiones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}