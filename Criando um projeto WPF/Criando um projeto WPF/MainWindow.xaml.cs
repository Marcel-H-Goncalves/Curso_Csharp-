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

namespace Criando_um_projeto_WPF
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
            textBox.Text = "Olá Mundo!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            textBox.Text = "Olá Marcel!";
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            textBox.Text = "Até Logo Marcel!";
        }
    }
}