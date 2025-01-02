namespace ComboBox
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecione uma plataforma ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Resultado.Text = comboBox1.Text;
                Resultado.Enabled = true;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("O usuário selecionou a opção: " + comboBox1.SelectedItem.ToString(), "Plataforma Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
