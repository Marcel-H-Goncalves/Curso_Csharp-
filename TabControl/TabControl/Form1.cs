namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoTab1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void botaoTab2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void botaoMudaFundoTab1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].BackColor = Color.Aqua;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].BackColor = Color.Red;
        }
    }
}
