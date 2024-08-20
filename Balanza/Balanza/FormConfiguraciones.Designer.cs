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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBitsDatos = new System.Windows.Forms.TextBox();
            this.txtBaudios = new System.Windows.Forms.TextBox();
            this.txtPuertoSerie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Puerto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Baudios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bits";
            // 
            // txtBitsDatos
            // 
            this.txtBitsDatos.Location = new System.Drawing.Point(116, 150);
            this.txtBitsDatos.Name = "txtBitsDatos";
            this.txtBitsDatos.Size = new System.Drawing.Size(100, 20);
            this.txtBitsDatos.TabIndex = 22;
            this.txtBitsDatos.Text = "7";
            // 
            // txtBaudios
            // 
            this.txtBaudios.Location = new System.Drawing.Point(116, 117);
            this.txtBaudios.Name = "txtBaudios";
            this.txtBaudios.Size = new System.Drawing.Size(101, 20);
            this.txtBaudios.TabIndex = 21;
            this.txtBaudios.Text = "9600";
            // 
            // txtPuertoSerie
            // 
            this.txtPuertoSerie.Location = new System.Drawing.Point(116, 82);
            this.txtPuertoSerie.Name = "txtPuertoSerie";
            this.txtPuertoSerie.Size = new System.Drawing.Size(101, 20);
            this.txtPuertoSerie.TabIndex = 20;
            this.txtPuertoSerie.Tag = "";
            this.txtPuertoSerie.Text = "COM1";
            // 
            // FormConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBitsDatos);
            this.Controls.Add(this.txtBaudios);
            this.Controls.Add(this.txtPuertoSerie);
            this.Name = "FormConfiguraciones";
            this.Text = "FormConfiguraciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBitsDatos;
        private System.Windows.Forms.TextBox txtBaudios;
        private System.Windows.Forms.TextBox txtPuertoSerie;
    }
}