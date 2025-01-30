using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheckBox_e_RadioButton_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void radioButton11_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton11 selecionado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void radioButton12_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton12 selecionado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void radioButton13_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton13 selecionado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void radioButton14_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton14 selecionado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void radioButton11_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton11 desmarcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void radioButton12_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton12 desmarcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void radioButton13_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton13 desmarcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void radioButton14_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("RadioButton14 desmarcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButtonSelecionadoGrupo1 = grid.Children.OfType<RadioButton>().Where(x => (x.IsChecked == true && x.GroupName == "Grupo1")).First();
            MessageBox.Show(radioButtonSelecionadoGrupo1.Content.ToString());
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("checkBox1 Marcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CheckBox2 Marcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CheckBox1 desmarcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void checkBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CheckBox2 desmarcado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<CheckBox> listaCheckBox = grid.Children.OfType<CheckBox>().Where(x => (x.IsChecked == true));
            foreach (CheckBox cb in listaCheckBox)
            {
                MessageBox.Show(cb.Content.ToString());
            }
        }
    }
}