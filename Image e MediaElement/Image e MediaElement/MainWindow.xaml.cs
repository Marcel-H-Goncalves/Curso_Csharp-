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

namespace Image_e_MediaElement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Uri enderecoImagem = new Uri(@"C:\Users\marce\source\repos\Image e MediaElement\Need for Speed™ Unbound 26_11_2023 14_41_57.png");
            BitmapImage imagem = new BitmapImage(enderecoImagem);
            image.Source = imagem;

            
            Uri enderecoVideo = new Uri(@"C:\Users\marce\source\repos\Image e MediaElement\cod.exe 2025.01.26 - 08.49.14.01.mp4");
            mediaElement.Source = enderecoVideo;
            mediaElement.LoadedBehavior = MediaState.Manual;
            mediaElement.Pause();
            mediaElement.Play();
           
        }
    }
}