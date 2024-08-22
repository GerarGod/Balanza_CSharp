using System.Drawing;
using System.Windows.Forms;

namespace Balanza
{
    partial class FormBalanzaLG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemBalanza = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImpresiones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConfiguraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipalBalanza = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBalanza,
            this.menuItemImpresiones,
            this.menuItemConfiguraciones,
            this.menuItemAcercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1085, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuItemBalanza
            // 
            this.menuItemBalanza.Name = "menuItemBalanza";
            this.menuItemBalanza.Size = new System.Drawing.Size(59, 20);
            this.menuItemBalanza.Text = "Balanza";
            this.menuItemBalanza.Click += new System.EventHandler(this.menuItemBalanza_Click);
            // 
            // menuItemImpresiones
            // 
            this.menuItemImpresiones.Name = "menuItemImpresiones";
            this.menuItemImpresiones.Size = new System.Drawing.Size(83, 20);
            this.menuItemImpresiones.Text = "Impresiones";
            this.menuItemImpresiones.Click += new System.EventHandler(this.menuItemImpresiones_Click);
            // 
            // menuItemConfiguraciones
            // 
            this.menuItemConfiguraciones.Name = "menuItemConfiguraciones";
            this.menuItemConfiguraciones.Size = new System.Drawing.Size(106, 20);
            this.menuItemConfiguraciones.Text = "Configuraciones";
            // 
            // menuItemAcercaDe
            // 
            this.menuItemAcercaDe.Name = "menuItemAcercaDe";
            this.menuItemAcercaDe.Size = new System.Drawing.Size(72, 20);
            this.menuItemAcercaDe.Text = "Acerca De";
            this.menuItemAcercaDe.Click += new System.EventHandler(this.menuItemAcercaDe_Click);
            // 
            // panelPrincipalBalanza
            // 
            this.panelPrincipalBalanza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipalBalanza.Location = new System.Drawing.Point(0, 31);
            this.panelPrincipalBalanza.Name = "panelPrincipalBalanza";
            this.panelPrincipalBalanza.Size = new System.Drawing.Size(1085, 655);
            this.panelPrincipalBalanza.TabIndex = 1;
            this.panelPrincipalBalanza.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipalBalanza_Paint);
            // 
            // FormBalanzaLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 687);
            this.Controls.Add(this.panelPrincipalBalanza);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBalanzaLG";
            this.Text = "Balanza LG";
            this.Load += new System.EventHandler(this.FormBalanzaLG_Load_1);
            this.Shown += new System.EventHandler(this.FormBalanzaLG_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemBalanza;
        private ToolStripMenuItem menuItemImpresiones;
        private ToolStripMenuItem menuItemConfiguraciones;
        private ToolStripMenuItem menuItemAcercaDe;
        private Panel panelPrincipalBalanza;
    }
}
