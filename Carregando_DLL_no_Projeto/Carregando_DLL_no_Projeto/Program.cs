using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Criando_um_projeto_DLL;

namespace Carregando_DLL_no_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A soma de 5 e 6 é: " + Matematica.Soma(5, 6));
            Console.WriteLine("A multiplicação de 5 e 6 é: " + Matematica.Multiplica(5, 6));
            Console.ReadKey();
        }
    }
}
