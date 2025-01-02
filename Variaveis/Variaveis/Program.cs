using System;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade = 18;
            Idade = 18;
            Console.WriteLine(Idade);
            Idade = 20;
            Console.WriteLine(Idade);



            string NomeCompleto = "Marcel Henrique";
            Console.WriteLine("Marcel Henrique");
            Console.WriteLine(NomeCompleto);
            NomeCompleto = "Regilaine Gonçalves";
            Console.WriteLine(NomeCompleto);



            var Salario = 10000;
            var NomeDaMae = "Marli";
            //byte b = 10000; O valor 10000 é muito grande para uma variável do tipo byte. Vai dar ERRO
            //NomeDaMae = 10000; Isso não é possivel, pois o compilador já atribuiu o tipo string para a nossa variavel 


            DateTime DataDeNascimento = new DateTime(1989, 8, 19, 17, 34, 27);
            Console.WriteLine(DataDeNascimento.Day);
            Console.WriteLine(DataDeNascimento.Month);
            Console.WriteLine(DataDeNascimento.Year);
            Console.WriteLine(DataDeNascimento.Hour);
            Console.WriteLine(DataDeNascimento.Minute);
            Console.WriteLine(DataDeNascimento.Second);




            string NumeroDaCasa = "65";
            int NumeroDaCasaInt = Convert.ToInt32(NumeroDaCasa);
            Console.WriteLine(NumeroDaCasaInt);

            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaInt);
            Console.WriteLine(NumeroDaCasa2);

            byte b = 50;
            char c = Convert.ToChar(b); //Utiliza a tabela ASCII
            Console.WriteLine(c);

            int charC = Convert.ToInt32(c);
            Console.WriteLine(charC);

            double d = 1.3;
            Console.WriteLine(d);

            int conversaoDoDouble = Convert.ToInt32(d);
            Console.WriteLine(conversaoDoDouble);

            int NumeroGrande = 10;
            byte NumeroPequeno = Convert.ToByte(NumeroGrande);
            Console.WriteLine(NumeroPequeno);

            Console.ReadKey();
        }
    }
}
