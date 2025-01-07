namespace Alterando_controles_a_partir_de_outras_threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(AlteraProgressBar));
            td.Start();
        }

        public void AlteraProgressBar()
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke((MethodInvoker)(() => AlteraProgressBar()));
            }
            else
            {
                for (int i = 0; i <= progressBar1.Maximum; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(20);
                }
            }
        }
    }
}
