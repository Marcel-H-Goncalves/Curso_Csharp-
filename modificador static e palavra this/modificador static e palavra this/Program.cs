using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificador_static_e_palavra_this
{
    //modificador static (estatico ou fixo) - Ele é sempre usado após o modificador de acesso
    //O static transforma o que esta sendo modificado por ele em pertencente a classe e não ao objeto;
    //Pode ser usado
    //atributo
    //propriedade
    //metodo
    //struct
    //classe
    //...

    //Não tem nada estatico na classe Pessoa

    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void ImprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }

        public Pessoa(string pNOme)
        {
            nome = pNOme;
        }
    }

    //A classe calculadora possui o modificador static 

    public class Calculadora
    {
        public static double PI = 3.1415;
        public static double CalculaAreaCircunferencia(double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }

    //Palavra this(este) - é utilizado para se referir aquilo que pertence a nossa classe
    public class MinhaPessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void ImprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }
        public MinhaPessoa(string nome)
        {
            this.nome = nome;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Pedro");
            pessoa1.ImprimeNome();
            pessoa1.Nome = "Maria";

            Console.WriteLine("O valor de PI é: " + Calculadora.PI);
            Console.WriteLine("A área é: " + Calculadora.CalculaAreaCircunferencia(2));
        }
    }
}
