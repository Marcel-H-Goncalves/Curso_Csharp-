﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Manipulacao_de_arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando caminhos de arquivo
            //Primeiro método
            string caminho1 = "C:\\Users\\marce\\source\\repos\\Manipulacao de arquivos\\Manipulacao de arquivos\\bin\\Debug\\teste.txt";
            //Segunda maneira
            string caminho2 = @"C:\Users\marce\source\repos\Manipulacao de arquivos\Manipulacao de arquivos\bin\Debug\teste.txt";



            //Criando um arquivo
            FileStream meuArquivo = File.Create(caminho1);
            meuArquivo.Close();



            //Verificando se um arquivo existe
            bool arquivoExiste = File.Exists(caminho1);
            if (arquivoExiste)
            {
                Console.WriteLine("O arquivo existe");
            }
            else
            {
                Console.WriteLine("O arquivo NÂO existe");
            }

            //Deletando arquivos
            File.Delete(caminho1);

            
            
            //Renomeando ou movendo arquivo
            string caminho3 = @"C:\Users\marce\source\repos\Manipulacao de arquivos\Manipulacao de arquivos\bin\Debug\teste2.txt";
            FileStream meuArquivo2 = File.Create(caminho3);
            meuArquivo2.Close();
            string caminho4 = @"C:\Users\marce\source\repos\Manipulacao de arquivos\Manipulacao de arquivos\bin\Debug\teste3.txt";
            File.Move(caminho3, caminho4);

            File.Delete(caminho4);



            //Escrevendo em um arquivo de texto
            string caminho5 = @"C:\Users\marce\source\repos\Manipulacao de arquivos\Manipulacao de arquivos\bin\Debug\nomes.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();

            string conteudo = "Marcel é um cara muito legal \r\n Marcel é um cara muito inteligente";
            File.WriteAllText(caminho5, conteudo);



            //Escrevendo um array de strings no nosso arquivo
            string[] conteudoArray = { "Regilaine", "Marcel", "Yasmin", "Guilherme" };
            File.WriteAllLines(caminho5, conteudoArray);



            //Lendo todo o conteudo de um arquivo
            string conteudoLido = File.ReadAllText(caminho5);
            Console.WriteLine(conteudoLido);



            //Lendo o conteudo de um arquivo e gravando num array de string
            Console.WriteLine("-------------------------------------");
            string[] conteudoLidoArray = File.ReadAllLines(caminho5);
            foreach (string nome in conteudoLidoArray)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}