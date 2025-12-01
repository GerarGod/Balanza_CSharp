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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValidadCert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.cmdGuardarTK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // FormConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 126);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(416, 372);
            this.Name = "FormConfiguraciones";
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.FormConfiguraciones_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValidadCert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.Button cmdGuardarTK;
    }
}