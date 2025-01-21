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

namespace Controle_Button
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicaram no Botão!", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information)  ;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            button.Margin = new Thickness(4, 4, 4, 4);
            button.Content = "Mouse sobre o botão";
            button.FontSize = 16;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            button.Margin = new Thickness(30, 30, 30, 30);
            button.Content = "Mouse deixou o botão";
            button.FontSize = 10;
        }
    }
}