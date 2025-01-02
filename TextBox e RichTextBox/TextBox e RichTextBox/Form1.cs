namespace TextBox_e_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoInverte_Click(object sender, EventArgs e)
        {
            string textbox = MeuTextBox.Text;
            string richtextbox = MeuRichTextBox.Text;

            MeuTextBox.Text = richtextbox;
            MeuRichTextBox.Text = textbox;


        }
    }
}
