namespace Controle_MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Para n�meros n�s usamos os caracteres # ou 0
            //Se usarmos o # o n�mero � opcional. Se usarmos o 0 o n�mero � obrigat�rio
            maskedTextBoxNumeros.Mask = "0000";

            //Para letras usamos os caracteres L ou ?
            //Se usarmos L a letra � obrigat�ria. Se usarmos ? a letra � opcional
            maskedTextBoxLetras.Mask = "LLLLLLLL";

            //Para datas 
            maskedTextBoxData.Mask = "00/00/0000";

            //Para placas de carro
            maskedTextBoxPlacaDeCarro.Mask = "LLL - 0000";

            //Para horas
            maskedTextBoxHora.Mask = "00:00:00";

            //Para n�meros decimais. O marcador decimal � o ponto.
            maskedTextBoxDecimais.Mask = "00.0000";

            //Para Senhas
            maskedTextBoxSenha.Mask = "0000";
            maskedTextBoxSenha.PasswordChar = '*';


        }

        private void botaoVerifica_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumeros.MaskCompleted)
                MessageBox.Show("O usu�rio digitou todos os n�meros obrigat�rios " + maskedTextBoxNumeros.Text);
            else
                MessageBox.Show("O usu�rio N�O digitou todos os n�meros obrigat�rios ");
        }
    }

}
