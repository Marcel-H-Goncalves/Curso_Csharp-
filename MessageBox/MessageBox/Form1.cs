namespace MessageBox
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoMessageBox_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Eu sou um MessageBox", "Meu primeiro MessageBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                //Clicou em OK
                MessageBox.Show("O usuário clicou em OK", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Clicou em Cancelar
                MessageBox.Show("O usuário clicou em CANCELAR", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
