using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Decisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());
            //if(se)... else(senão)...
            if (Idade >= 18/*Condição booleana, que pode ser true ou false*/)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else //opcional//
            {
                Console.WriteLine("Você não é maior de idade");
            }

            Console.WriteLine("Digite o seu salário");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());
            //if... else... if...
            if (Salario < 1000 /*Condição booleana, que pode ser true ou false*/)//Sempre precisa ter
            {
                Console.WriteLine("Você ganha menos que 1 salário mínimo");
            }
            else if(Salario < 2000/*Condição booleana, que pode ser true ou false*/)//Quantos a gente quiser
            {
                Console.WriteLine("Você ganha menos que 2 salários mínimo");
            }
            else if (Salario < 5000/*Condição booleana, que pode ser true ou false*/)//Quantos a gente quiser
            {
                Console.WriteLine("Você ganha menos que 5 salários mínimo");
            }
            else //opcional
            {
                Console.WriteLine("Você é Rico!");
            }


            Console.WriteLine("Pressione uma tecla do seu teclado");
            char tecla = Console.ReadKey(true).KeyChar;
            //switch(comutador)
            switch(tecla/*Variavel*/)
            {
                case 'a'/*Valores*/://Caso
                    Console.WriteLine("Você pressionou A");
                    break;//Pare
                case 'b' /*Valores*/://Caso
                    Console.WriteLine("Você pressionou B");
                    break;//Pare
                default://Padrão - opcional
                    Console.WriteLine("Eu não conheço essa tecla!");
                    break;
            }



            Console.ReadKey();
        }

    }
}
