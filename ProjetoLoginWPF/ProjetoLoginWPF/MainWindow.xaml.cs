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

namespace ProjetoLoginWPF
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

        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {
            passwordBoxSenha.Visibility = Visibility.Collapsed;
            textBoxSenha.Visibility = Visibility.Visible;
            textBoxSenha.Text = passwordBoxSenha.Password;
        }

        private void buttonShow_MouseLeave(object sender, MouseEventArgs e)
        {
            textBoxSenha.Visibility = Visibility.Collapsed;
            passwordBoxSenha.Visibility = Visibility.Visible;
            textBoxSenha.Text = "";
        }

        private void buttonEntrar_Click(object sender, RoutedEventArgs e)
        {
            if (buttonEntrar.Content.ToString() == "Entrar")
            {
                if (textBoxUsuario.Text == "Marcel")
                {
                    if (passwordBoxSenha.Password == "1234")
                    {
                        //Usuário logado no sistema
                        MessageBox.Show("Usuário logado com sucesso", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                        buttonEntrar.Content = "Sair";
                        buttonEntrar.Background = new SolidColorBrush(Colors.Green);
                        passwordBoxSenha.Password = "";
                        MeuPrograma meuPrograma = new MeuPrograma();
                        meuPrograma.Show();
                    }
                    else
                    {
                        //Senha está incorreta
                        MessageBox.Show("Senha está incorreta!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    //Usuário incorreto
                    MessageBox.Show("Usuário está incorreto!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                buttonEntrar.Content = "Entrar";
                buttonEntrar.Background = new SolidColorBrush(Color.FromArgb(221, 221, 221, 221));
            }
        }
    }
}