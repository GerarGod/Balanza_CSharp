namespace Balanza
{
    public partial class FormBalanzaLG : Form
    {
        public FormBalanzaLG()
        {
            InitializeComponent();
        }

        private void menuItemBalanza_Click(object sender, EventArgs e)
        {



        }

        private void menuItemAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAcercaDe>();
        }


        // METODO PARA ABRIR UN FORMULARIO DENTRO DEL PANEL.
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;

            formulario = panelPrincipalBalanza.Controls.OfType<MiForm>().FirstOrDefault();
            // si el formulario / instancia no existe

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelPrincipalBalanza.Controls.Add(formulario);
                panelPrincipalBalanza.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

    }
}
