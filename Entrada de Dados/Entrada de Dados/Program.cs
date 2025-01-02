using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");// esse comando mostra o que for escrito 
            string Nome = Console.ReadLine();// aqui foi atribuido a variavel Nome o que for digitado no comando de cima
            Console.WriteLine("Olá " + Nome);//comando para escrever o que o usuario digitou no comando usando a variavel nome 

            Console.WriteLine("Digite a sua idade:");//uma linha de dados solicitando dados para o usuario
            string Idade = Console.ReadLine();//captura a linha de cima em uma variavel string
            Console.WriteLine("Você tem " + Idade + " anos de idade");
            int idadeInt = Convert.ToInt32(Idade);//para converter uma string e um inteiro 

            Console.WriteLine("Pressione qualquer tecla: ");
            char TeclaPressionada = Console.ReadKey(true).KeyChar;// comando para capturar uma tecla apertada usar true para a tecla aparecer depois do texto

            string TeclaPressionadaString = Convert.ToString(Console.ReadKey(true).KeyChar);//converter a tecla em uma string 
            string TeclaPressionadaString = Console.ReadKey(true).KeyChar.ToString();//outro modo de converter uma tecla 

            Console.WriteLine("Olá. A tecla que você pressionou foi: " + TeclaPressionada);//mostra a tecla que foi apertada no console

            Console.WriteLine("Pressione qualquer tecla para sair");

            Console.ReadKey();
        }
    }
}
