using System.Diagnostics;

namespace Adicionando_controles_programaticamente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label minhaLabel = new Label();
            minhaLabel.Location = new Point(20, 40);
            minhaLabel.Name = "minhaLabel";
            minhaLabel.Text = "Minha Label";
            this.Controls.Add(minhaLabel);

            Button meuBotao = new Button();
            meuBotao.Location = new Point(20, 80);
            meuBotao.Name = "meuBotao";
            meuBotao.Size = new Size(100, 25);
            meuBotao.Text = "meu botão";
            meuBotao.Click += MeuBotao_Click;
            this.Controls.Add(meuBotao);

            TextBox meuTextBox = new TextBox();
            meuTextBox.Location = new Point(20, 120);
            meuTextBox.Name = "meuTextBox";
            meuTextBox.Size = new Size(100, 25);
            this.Controls.Add(meuTextBox);

            CheckBox meuCheckBox = new CheckBox();
            meuCheckBox.Location = new Point(20, 160);
            meuCheckBox.Name = "meuCheckBox";
            meuCheckBox.Checked = false;
            meuCheckBox.Text = "Meu checkBox";
            this.Controls.Add(meuCheckBox);

            //Groupbox
            GroupBox meuGroupBox = new GroupBox();
            meuGroupBox.Location = new Point(20, 200);
            meuGroupBox.Name = "meuGroupBox";
            meuGroupBox.Size = new Size(150, 150);
            meuGroupBox.Text = "Meu groupbox";

            Button meuBotao2 = new Button();
            meuBotao2.Location = new Point(20, 20);
            meuBotao2.Name = "meuBotao2";
            meuBotao2.Size = new Size(100, 25);
            meuBotao2.Text = "meu botão";
            meuGroupBox.Controls.Add(meuBotao2);
            this.Controls.Add(meuGroupBox);
        }

        private void MeuBotao_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Olá do evento click", "Olá Mundo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
