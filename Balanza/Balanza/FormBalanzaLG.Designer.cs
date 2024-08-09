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
            menuStrip1 = new MenuStrip();
            menuItemBalanza = new ToolStripMenuItem();
            menuItemImpresiones = new ToolStripMenuItem();
            menuItemConfiguraciones = new ToolStripMenuItem();
            menuItemAcercaDe = new ToolStripMenuItem();
            panelPrincipalBalanza = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItemBalanza, menuItemImpresiones, menuItemConfiguraciones, menuItemAcercaDe });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1038, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItemBalanza
            // 
            menuItemBalanza.Name = "menuItemBalanza";
            menuItemBalanza.Size = new Size(59, 20);
            menuItemBalanza.Text = "Balanza";
            menuItemBalanza.Click += menuItemBalanza_Click;
            // 
            // menuItemImpresiones
            // 
            menuItemImpresiones.Name = "menuItemImpresiones";
            menuItemImpresiones.Size = new Size(83, 20);
            menuItemImpresiones.Text = "Impresiones";
            // 
            // menuItemConfiguraciones
            // 
            menuItemConfiguraciones.Name = "menuItemConfiguraciones";
            menuItemConfiguraciones.Size = new Size(106, 20);
            menuItemConfiguraciones.Text = "Configuraciones";
            // 
            // menuItemAcercaDe
            // 
            menuItemAcercaDe.Name = "menuItemAcercaDe";
            menuItemAcercaDe.Size = new Size(72, 20);
            menuItemAcercaDe.Text = "Acerca De";
            menuItemAcercaDe.Click += menuItemAcercaDe_Click;
            // 
            // panelPrincipalBalanza
            // 
            panelPrincipalBalanza.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPrincipalBalanza.Location = new Point(0, 27);
            panelPrincipalBalanza.Name = "panelPrincipalBalanza";
            panelPrincipalBalanza.Size = new Size(1038, 537);
            panelPrincipalBalanza.TabIndex = 1;
            // 
            // FormBalanzaLG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 564);
            Controls.Add(panelPrincipalBalanza);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormBalanzaLG";
            Text = "Balanza LG";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
