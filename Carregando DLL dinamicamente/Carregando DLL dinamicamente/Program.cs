using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;


namespace Carregando_DLL_dinamicamente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly minhaDll = Assembly.LoadFile(@"C:\Users\marce\source\repos\Criando_um_projeto_DLL\Criando_um_projeto_DLL\bin\Debug\Criando_um_projeto_DLL.dll");
            Type classeMatematica = minhaDll.GetType("Criando_um_projeto_DLL.Matematica");
            dynamic instanciaMatematica = Activator.CreateInstance(classeMatematica);
            var metodoSoma = classeMatematica.GetMethod("Soma");
            double resultado = (double)metodoSoma.Invoke(instanciaMatematica, new object[] { 10, 20 });
            Console.WriteLine("O resultado da soma de 10 e 20 é " + resultado);
            Console.ReadKey();
            

        }
    }
}
