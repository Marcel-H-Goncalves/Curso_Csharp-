namespace Controle_MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Para números nós usamos os caracteres # ou 0
            //Se usarmos o # o número é opcional. Se usarmos o 0 o número é obrigatório
            maskedTextBoxNumeros.Mask = "0000";

            //Para letras usamos os caracteres L ou ?
            //Se usarmos L a letra é obrigatória. Se usarmos ? a letra é opcional
            maskedTextBoxLetras.Mask = "LLLLLLLL";

            //Para datas 
            maskedTextBoxData.Mask = "00/00/0000";

            //Para placas de carro
            maskedTextBoxPlacaDeCarro.Mask = "LLL - 0000";

            //Para horas
            maskedTextBoxHora.Mask = "00:00:00";

            //Para números decimais. O marcador decimal é o ponto.
            maskedTextBoxDecimais.Mask = "00.0000";

            //Para Senhas
            maskedTextBoxSenha.Mask = "0000";
            maskedTextBoxSenha.PasswordChar = '*';


        }

        private void botaoVerifica_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumeros.MaskCompleted)
                MessageBox.Show("O usuário digitou todos os números obrigatórios " + maskedTextBoxNumeros.Text);
            else
                MessageBox.Show("O usuário NÃO digitou todos os números obrigatórios ");
        }
    }

}
