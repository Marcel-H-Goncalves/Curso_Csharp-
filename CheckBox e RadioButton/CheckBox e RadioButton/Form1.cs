namespace CheckBox_e_RadioButton
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Playstation.Checked)
                MessageBox.Show("Playstation selecionado", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Playstation não selecionado", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Xbox.Checked)
                MessageBox.Show("Xbox selecionado", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Xbox não selecionado", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Nintendo.Checked)
                MessageBox.Show("Nintendo selecionada", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nintendo não selecionada", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (Steam.Checked)
                MessageBox.Show("Steam selecionada", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Steam não selecionada", "Plataforma selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Playstation selecionado";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Xbox selecionado";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Nintendo selecionado";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Steam selecionada";
        }

        private void botaoAplicar_Click(object sender, EventArgs e)
        {
            List<RadioButton> listRadioButton = groupBox1.Controls.OfType<RadioButton>().ToList();
            foreach (RadioButton rb in listRadioButton)
            {
                if (rb.Checked == true)
                {
                    MessageBox.Show("Plataforma selecionada: " + rb.Text, "Plataforma Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
    }
}
