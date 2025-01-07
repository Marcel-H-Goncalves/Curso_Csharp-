namespace Controle_Timer
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timerPorCodigo;
        public Form1()
        {
            InitializeComponent();
            timerPorCodigo = new System.Windows.Forms.Timer();
            timerPorCodigo.Enabled = false;
            timerPorCodigo.Interval = 5000;
            timerPorCodigo.Tick += TimerPorCodigo_Tick;
        }
        private void TimerPorCodigo_Tick(Object? sender, EventArgs e)
        {
            MessageBox.Show("Timer por C�digo: " + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void buttonHabilitaTimerInterfaceGrafica_Click(object sender, EventArgs e)
        {
            timerInterfaceGrafica.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerInterfaceGrafica.Enabled = false;
        }

        private void timerInterfaceGrafica_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Timer interface gr�fica: " + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void buttonHabilitarTimerPorCodigo_Click(object sender, EventArgs e)
        {
            timerPorCodigo.Enabled = true;

        }

        private void buttonDesabilitarTimerPorCodigo_Click(object sender, EventArgs e)
        {
            timerPorCodigo.Enabled = false;
        }
    }
}
