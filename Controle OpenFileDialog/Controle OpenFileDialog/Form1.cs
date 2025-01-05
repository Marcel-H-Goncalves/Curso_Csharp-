namespace Controle_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog janelaDeArquivos = new OpenFileDialog();
            janelaDeArquivos.InitialDirectory = "C:\\"; //Selecionar o diretorio inicial
            janelaDeArquivos.Filter = "Arquivos txt|*.txt|Arquivos jpg|*.jpg|Todos os arquivos|*.*";

            if (janelaDeArquivos.ShowDialog() == DialogResult.OK)
            {
                string localDoArquivo = janelaDeArquivos.FileName;
                MessageBox.Show(localDoArquivo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog janelaDeArquivos = new OpenFileDialog();
            janelaDeArquivos.InitialDirectory = "C:\\"; //Selecionar o diretorio inicial
            janelaDeArquivos.Filter = "Arquivos txt|*.txt|Arquivos jpg|*.jpg|Todos os arquivos|*.*";
            janelaDeArquivos.Multiselect = true;

            if (janelaDeArquivos.ShowDialog() == DialogResult.OK)
            {
                string[] localDoArquivos = janelaDeArquivos.FileNames;
                foreach(string localDoArquivo in localDoArquivos)
                {
                    MessageBox.Show(localDoArquivo);
                }
                
            }
        }
    }
}
