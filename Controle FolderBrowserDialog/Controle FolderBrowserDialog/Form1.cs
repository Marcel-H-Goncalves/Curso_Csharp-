namespace Controle_FolderBrowserDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaPasta = folderBrowserDialog1.SelectedPath;
                MessageBox.Show("O diretório selecionado foi: " + caminhoDaPasta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = "c:\\";
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaPasta = dialog.SelectedPath;
                MessageBox.Show("O diretório selecionado foi: " + caminhoDaPasta);
            }
        }
    }
}
