namespace Controle_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if(!listBoxPlataforma.Items.Contains("Nintendo"))
            listBoxPlataforma.Items.Add("Nintendo");
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPlataforma.Items.Contains("Nintendo"))
                listBoxPlataforma.Items.Remove("Nintendo");
        }

        private void listBoxPlataforma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlataforma.SelectedItem != null)
                MessageBox.Show("O usuário selecionou a opção " + listBoxPlataforma.SelectedItem.ToString(), "Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
