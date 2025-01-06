namespace Controle_MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dataInicial = monthCalendar1.SelectionStart;
            DateTime dataFinal = monthCalendar1.SelectionEnd;
            MessageBox.Show("A primeira data é: " + dataInicial.ToString("dd/MM/yyyy") + "\r\n" + "A data final é: " + dataFinal.ToString("dd/MM/yyyy"));
        }
    }
}
