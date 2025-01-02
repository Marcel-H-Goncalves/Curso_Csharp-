using System;
using System.Windows.Forms;

namespace TrackBar_e_ProgressBar
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // Especificando o namespace completo

        public Form1()
        {
            InitializeComponent();

            // Inicializa o Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Define o intervalo de 0.5 segundos (500 ms)
            timer.Tick += Timer_Tick; // Associa o evento ao Tick do Timer
            timer.Start(); // Inicia o Timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Incrementa o valor da TrackBar
            if (trackBarAtiva.Value < trackBarAtiva.Maximum)
            {
                trackBarAtiva.Value += 5; // Incrementa 5
            }
            else
            {
                timer.Stop(); // Para o Timer ao atingir o valor máximo
                MessageBox.Show("TrackBar atingiu o valor máximo!");
            }
        }

        private void trackBarAtiva_ValueChanged(object sender, EventArgs e)
        {
            // Sincroniza a ProgressBar com o valor da TrackBar
            progressBarPassivo.Value = trackBarAtiva.Value;
        }
    }
}