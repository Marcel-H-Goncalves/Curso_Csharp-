using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Matematicos_avançados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Potenciação
            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine(potenciacao);

            //Radiciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1 / raiz);

            //Máximo e o mínimo
            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);

            double minimo = Math.Min(4, 8);
            Console.WriteLine(minimo);

            //Módulo
            double modulo = Math.Abs(-10); //numero negativo para numero positivo absoluto

            //Operações trigonométricas
            double angulo = 30 * (2 * Math.PI) / 360;//graus para radiano
            //Seno - Sin
            //Cosseno - Cos
            //Tangente - Tan
            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);

            //ArcSeno - Asin
            //ArcCosseno - Acon
            //ArcTangente Atan
            double arseno = Math.Asin(seno);
            Console.WriteLine(arseno);
            double arcsenoGraus = arseno * 360 / (2 * Math.PI); //para voltar para graus
            Console.WriteLine(arcsenoGraus);

            //Arredondamento números
            double numero = 3.33;
            double arredondamentoParaCima = Math.Ceiling(numero);
            Console.WriteLine(arredondamentoParaCima);

            double arredondamentoParaBaixo = Math.Floor(numero);
            Console.WriteLine(arredondamentoParaBaixo);

            //Logaritmo
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);

            double BaseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(BaseE);

            Console.ReadKey();
        }
    }
}
