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

namespace TextBlock_e_Label
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

        private void label_MouseEnter(object sender, MouseEventArgs e)
        {
            label.FontSize = 20;
            label.Background = new SolidColorBrush(Colors.Red);
        }

        private void label_MouseLeave(object sender, MouseEventArgs e)
        {
            label.FontSize = 15;
            label.Background = new SolidColorBrush(Colors.White);
        }
    }
}