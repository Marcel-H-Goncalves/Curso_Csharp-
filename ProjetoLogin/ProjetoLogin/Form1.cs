namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (buttonLogin.Text == "Login")
            {
                if (textBoxUsuario.Text == "")
                    MessageBox.Show("Digite o nome do usuário! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (textBoxUsuario.Text == "Marcel")
                    {
                        if (maskedTextBoxSenha.Text == "")
                            MessageBox.Show("Digite a senha! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (maskedTextBoxSenha.Text == "1234")
                            {
                                MessageBox.Show("Usuário Logado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                labelLogin.Text = "Logado!";
                                labelLogin.ForeColor = Color.Green;
                                textBoxUsuario.Text = "";
                                maskedTextBoxSenha.Text = "";
                                buttonLogin.Text = "Logout";
                            }
                            else
                                MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Usuário incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                labelLogin.Text = "Login!";
                labelLogin.ForeColor = Color.Black;
                buttonLogin.Text = "Login";
            }
        }
    }
}
