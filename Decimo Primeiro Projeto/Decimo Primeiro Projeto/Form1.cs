using CadastroBiblioteca;
using System.Windows.Forms;

namespace Decimo_Primeiro_Projeto
{
    public partial class Form1 : Form
    {
        BaseDeDados baseDeDados;

        public Form1()
        {
            InitializeComponent();
            baseDeDados = new BaseDeDados("BaseDeDados.xml");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(textBoxNomeCompleto.Text, textBoxNumeroDocumento.Text, Convert.ToDateTime(textBoxDataNascimento.Text), textBoxNomeRua.Text, Convert.ToUInt32(textBoxNumeroCasa.Text));
            baseDeDados.AdicionarPessoa(cadastroPessoa);
            MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro Concluido",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.PesquisaPessoaPorDoc(textBoxBuscaNumeroDocumento.Text);
            if (listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroCasa.Text = Convert.ToString(listaPessoas[0].NumeroDaCasa);
            }
            else
            {
                MessageBox.Show("Usuário não Localizado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            List<CadastroPessoa> listaPessoas = baseDeDados.RemoverPessoaPorDoc(textBoxBuscaNumeroDocumento.Text);
            if(listaPessoas != null && listaPessoas.Count > 0)
            {
                labelNomeCompleto.Text = listaPessoas[0].Nome;
                labelDataNascimento.Text = listaPessoas[0].DataDeNascimento.ToString();
                labelNomeRua.Text = listaPessoas[0].NomeDaRua;
                labelNumeroCasa.Text = Convert.ToString(listaPessoas[0].NumeroDaCasa);
                MessageBox.Show("Usuário removido com sucesso", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário não Localizado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
