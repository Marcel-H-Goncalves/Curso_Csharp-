namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void meuBotao_Click(object sender, EventArgs e)
        {
            meuBotao.BackColor = Color.Aquamarine;
        }

        private void meuBotao_MouseEnter(object sender, EventArgs e)
        {
            meuBotao.ForeColor = Color.White;
        }

        private void meuBotao_MouseLeave(object sender, EventArgs e)
        {
            meuBotao.ForeColor = Color.Yellow;
        }
    }
}
