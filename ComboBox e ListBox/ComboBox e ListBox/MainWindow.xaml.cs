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

namespace ComboBox_e_ListBox
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((ComboBoxItem)(comboBox.SelectedItem)).Content.ToString(),"Seleção",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Você clicou no primero botão", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Você clicou no segundo botão", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(((ListBoxItem)(listBox.SelectedItem)).Content.ToString(), "Seleção", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}