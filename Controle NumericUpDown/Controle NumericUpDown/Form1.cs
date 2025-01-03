namespace Controle_NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal valorEscolhido = numericUpDown1.Value;
            MessageBox.Show("O valor escolhido foi: " + valorEscolhido, "Valor Escolhido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
