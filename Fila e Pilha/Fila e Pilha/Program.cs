using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_e_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> FilaDeNomes = new Queue<string>();
            //Adicionando elementos
            FilaDeNomes.Enqueue("Guilherme");
            FilaDeNomes.Enqueue("Maria");
            FilaDeNomes.Enqueue("João");
            FilaDeNomes.Enqueue("Vagner");

            //Removendo Elementos
            string nomeRemovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);
            nomeRemovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeRemovido);

            //Espiando elementos
            Console.WriteLine("-----------------------------");
            string nomeEspiado = FilaDeNomes.Peek();
            Console.WriteLine(nomeEspiado);

            //Stack
            Stack<string> PilhaDeNomes = new Stack<string>();

            //Adicionando elementos
            PilhaDeNomes.Push("Mariana");
            PilhaDeNomes.Push("Joaquina");
            PilhaDeNomes.Push("José");
            PilhaDeNomes.Push("Alana");

            //Removendo elementos
            string nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);
            Console.WriteLine("-----------------------------");

            //Espiar elementos
            string NomeEspiado2 = PilhaDeNomes.Peek();
            Console.WriteLine(NomeEspiado2);

            //Possuem os mesmos metodos das listas
            //Count
            //Clear
            //Concat
            //Contains
            //...


            Console.ReadKey();

        }
    }
}
