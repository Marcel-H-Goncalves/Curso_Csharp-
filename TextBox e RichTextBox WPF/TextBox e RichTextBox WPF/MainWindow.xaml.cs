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

namespace TextBox_e_RichTextBox_WPF
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

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox1.Background = new SolidColorBrush(Colors.Red);
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox1.Background = new SolidColorBrush(Colors.White);
            MessageBox.Show("A tecla pressionada foi:" + e.Key.ToString());
            e.Key.ToString();

        }
    }
}