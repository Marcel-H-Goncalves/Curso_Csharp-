namespace Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MinhaLabel_Click(object sender, EventArgs e)
        {
            MinhaLabel.Font = new Font("Arial", 18);
        }

        private void MinhaLabel_DoubleClick(object sender, EventArgs e)
        {
            MinhaLabel.Font = new Font("Arial", 36);
        }

        private void MinhaLabel_MouseEnter(object sender, EventArgs e)
        {
            MinhaLabel.Text = "Mouse sobre a label";
        }

        private void MinhaLabel_MouseLeave(object sender, EventArgs e)
        {
            MinhaLabel.Text = "Mouse deixou a label";
        }
    }
}
