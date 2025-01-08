namespace VariosFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeuFomulario2 form2 = (MeuFomulario2)Application.OpenForms["xyz"];
            if (form2 == null)
            {
                form2 = new MeuFomulario2();
                form2.Name = "xyz";
                form2.Show();
            }
            else
            {
                MessageBox.Show("Formulário já aberto! ", "Aviso", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }
    }
}
