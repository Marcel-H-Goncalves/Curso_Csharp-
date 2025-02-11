using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_WebService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuServidorWebService meuServidorLocal = new MeuServidorWebService("http://192.168.1.219:80/MeuServidorLocal");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
