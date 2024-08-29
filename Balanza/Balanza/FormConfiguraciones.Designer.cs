namespace Balanza
{
    partial class FormConfiguraciones
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdGuardarPuerto = new System.Windows.Forms.Button();
            this.txtBitsDatos = new System.Windows.Forms.TextBox();
            this.txtBaudios = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPuertoSerie = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValidadCert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.cmdGuardarTK = new System.Windows.Forms.Button();
            this.cmdGuardarLog = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdGuardarLog);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLog);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(18, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 62);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datos Recibidos:";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLog.Location = new System.Drawing.Point(128, 27);
            this.txtLog.MaxLength = 1;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(43, 25);
            this.txtLog.TabIndex = 4;
            this.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            this.txtLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLog_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdGuardarPuerto);
            this.groupBox1.Controls.Add(this.txtBitsDatos);
            this.groupBox1.Controls.Add(this.txtBaudios);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtPuertoSerie);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(18, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 123);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdGuardarPuerto
            // 
            this.cmdGuardarPuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.cmdGuardarPuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardarPuerto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(37)))));
            this.cmdGuardarPuerto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(81)))));
            this.cmdGuardarPuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardarPuerto.ForeColor = System.Drawing.Color.White;
            this.cmdGuardarPuerto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardarPuerto.Location = new System.Drawing.Point(258, 43);
            this.cmdGuardarPuerto.Name = "cmdGuardarPuerto";
            this.cmdGuardarPuerto.Size = new System.Drawing.Size(95, 73);
            this.cmdGuardarPuerto.TabIndex = 16;
            this.cmdGuardarPuerto.Text = "Guardar";
            this.cmdGuardarPuerto.UseVisualStyleBackColor = false;
            this.cmdGuardarPuerto.Click += new System.EventHandler(this.cmdGuardarPuerto_Click);
            // 
            // txtBitsDatos
            // 
            this.txtBitsDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBitsDatos.Location = new System.Drawing.Point(93, 91);
            this.txtBitsDatos.MaxLength = 1;
            this.txtBitsDatos.Name = "txtBitsDatos";
            this.txtBitsDatos.Size = new System.Drawing.Size(78, 25);
            this.txtBitsDatos.TabIndex = 14;
            this.txtBitsDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBitsDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBitsDatos_KeyPress);
            // 
            // txtBaudios
            // 
            this.txtBaudios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBaudios.Location = new System.Drawing.Point(93, 59);
            this.txtBaudios.MaxLength = 6;
            this.txtBaudios.Name = "txtBaudios";
            this.txtBaudios.Size = new System.Drawing.Size(78, 25);
            this.txtBaudios.TabIndex = 13;
            this.txtBaudios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBaudios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaudios_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(11, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Bits";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(11, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Baudios";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(11, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Nro Puerto:";
            // 
            // txtPuertoSerie
            // 
            this.txtPuertoSerie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPuertoSerie.Location = new System.Drawing.Point(93, 28);
            this.txtPuertoSerie.MaxLength = 6;
            this.txtPuertoSerie.Name = "txtPuertoSerie";
            this.txtPuertoSerie.Size = new System.Drawing.Size(78, 25);
            this.txtPuertoSerie.TabIndex = 4;
            this.txtPuertoSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPuertoSerie.TextChanged += new System.EventHandler(this.txtPuertoSerie_TextChanged);
            this.txtPuertoSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuertoSerie_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtValidadCert);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCertificado);
            this.groupBox2.Controls.Add(this.cmdGuardarTK);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 111);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores Ticket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(4, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Validad Cert:";
            // 
            // txtValidadCert
            // 
            this.txtValidadCert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtValidadCert.Location = new System.Drawing.Point(97, 62);
            this.txtValidadCert.MaxLength = 30;
            this.txtValidadCert.Name = "txtValidadCert";
            this.txtValidadCert.Size = new System.Drawing.Size(155, 25);
            this.txtValidadCert.TabIndex = 18;
            this.txtValidadCert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValidadCert.TextChanged += new System.EventHandler(this.txtValidadCert_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(4, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Certificado:";
            // 
            // txtCertificado
            // 
            this.txtCertificado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCertificado.Location = new System.Drawing.Point(97, 31);
            this.txtCertificado.MaxLength = 30;
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(155, 25);
            this.txtCertificado.TabIndex = 16;
            this.txtCertificado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCertificado.TextChanged += new System.EventHandler(this.txtCertificado_TextChanged);
            // 
            // cmdGuardarTK
            // 
            this.cmdGuardarTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.cmdGuardarTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardarTK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(37)))));
            this.cmdGuardarTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(81)))));
            this.cmdGuardarTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardarTK.ForeColor = System.Drawing.Color.White;
            this.cmdGuardarTK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardarTK.Location = new System.Drawing.Point(258, 50);
            this.cmdGuardarTK.Name = "cmdGuardarTK";
            this.cmdGuardarTK.Size = new System.Drawing.Size(95, 36);
            this.cmdGuardarTK.TabIndex = 10;
            this.cmdGuardarTK.Text = "Guardar";
            this.cmdGuardarTK.UseVisualStyleBackColor = false;
            this.cmdGuardarTK.Click += new System.EventHandler(this.cmdGuardarTK_Click);
            // 
            // cmdGuardarLog
            // 
            this.cmdGuardarLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.cmdGuardarLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGuardarLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(37)))));
            this.cmdGuardarLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(81)))));
            this.cmdGuardarLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardarLog.ForeColor = System.Drawing.Color.White;
            this.cmdGuardarLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardarLog.Location = new System.Drawing.Point(258, 16);
            this.cmdGuardarLog.Name = "cmdGuardarLog";
            this.cmdGuardarLog.Size = new System.Drawing.Size(95, 36);
            this.cmdGuardarLog.TabIndex = 11;
            this.cmdGuardarLog.Text = "Guardar";
            this.cmdGuardarLog.UseVisualStyleBackColor = false;
            this.cmdGuardarLog.Click += new System.EventHandler(this.cmdGuardarLog_Click);
            // 
            // FormConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 333);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(416, 372);
            this.Name = "FormConfiguraciones";
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.FormConfiguraciones_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdGuardarLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdGuardarPuerto;
        private System.Windows.Forms.TextBox txtBitsDatos;
        private System.Windows.Forms.TextBox txtBaudios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPuertoSerie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValidadCert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.Button cmdGuardarTK;
    }
}