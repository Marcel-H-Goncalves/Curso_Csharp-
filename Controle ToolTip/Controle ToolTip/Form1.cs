namespace Controle_ToolTip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Isto é um ToolTip botão 1 ", button1);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Isto é um ToolTip botão 2 ", button2);
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Isto é um CheckBox ", checkBox1);
        }
    }
}
