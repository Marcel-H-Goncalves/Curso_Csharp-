using metodo_de_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_de_classes
{
    public class ContaBancaria
    {
        //atributos 
        private double saldo;
        private string senha;
        private string nomeDoCliente;

        //Métodos 
        /* MODIFICADOR_DE_ACESSO TIPO_DE_SAIDA NOME_DO_METODO (TIPO_PAR1 NOME_PAR1, TIPO_PAR2 NOME_PAR2, ...)
         * {
         * CONTEUDO_DO_METODO
         * return VALOR_DE_SAIDA;
         * }

           MODIFICADOR_DE_ACESSO
            public (publico) - Todos podem acessar o nossos metodos
            private (privado) - Somente a nossa propria classe pode acessar o metodo

            TIPO_DE_SAIDA
            EXEMPLO: int, string, bool, class, List....
            
            PARAMETRS_DE_ENTRADA
            TIPO_PAR: int, string, class, List....
            NOME_PAR:
         */
        public double Sacar(double pValorSacado, string pSenha)
        {
            if(senha == pSenha)
            {
                if (saldo > pValorSacado)
                {
                    saldo -= pValorSacado;
                    Console.WriteLine("O valor sacado foi de: " + pValorSacado);
                    return pValorSacado;
                }
                else
                {
                    Console.WriteLine("O saldo é insuficiente");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("A senha está incorreta");
                return 0;
            }
        }

        public void Depositar(double pValorDepositado)
        {
            saldo += pValorDepositado;
            Console.WriteLine("O valor depositado foi de: " + pValorDepositado);
        }

        public void ConsultaSaldo(string pSenha)
        {
            if (senha == pSenha)
            {
                Console.WriteLine("O saldo da conta é: " + saldo);
            }
            else
            {
                Console.WriteLine("A senha está incorreta");
            }
        }

        //Esse é o método construtor 
        //primeiro metodo a ser executado quando (instanciamos a classe) / (criamos um objeto)
        //construtor não possui parametro de saida
        //o construtor sempre é public
        //Normalmente o construtor é usado para fazer as configurações iniciais do nosso objeto 
        public ContaBancaria(string pSenha, string pNomeDoCliente)
        {
            saldo = 0;
            senha = pSenha;
            nomeDoCliente = pNomeDoCliente;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaDoPedro = new ContaBancaria("12345" , "MarcelHenrique");
         

            double valorSacado = contaDoPedro.Sacar(10, "12345");
            contaDoPedro.Depositar(1000);
            contaDoPedro.ConsultaSaldo("12345");
            valorSacado = contaDoPedro.Sacar(10, "12345");
        }
    }
}

















/*namespace metodo_de_classes
{
    public class ContaBancaria
    {
        //atributos 
        public double saldo;
        public string senha;
        public string nomeDoCliente;

        //Métodos 
            MODIFICADOR_DE_ACESSO TIPO_DE_SAIDA NOME_DO_METODO (TIPO_PAR1 NOME_PAR1, TIPO_PAR2 NOME_PAR2, ...)
         * {
         * CONTEUDO_DO_METODO
         * return VALOR_DE_SAIDA;
         * }

           MODIFICADOR_DE_ACESSO
            public (publico) - Todos podem acessar o nossos metodos
            private (privado) - Somente a nossa propria classe pode acessar o metodo

            TIPO_DE_SAIDA
            EXEMPLO: int, string, bool, class, List....
            
            PARAMETRS_DE_ENTRADA
            TIPO_PAR: int, string, class, List....
            NOME_PAR:
         
public double Sacar(double pValorSacado, string pSenha)
{
    if (senha == pSenha)
    {
        if (saldo > pValorSacado)
        {
            saldo -= pValorSacado;
            Console.WriteLine("O valor sacado foi de: " + pValorSacado);
            return pValorSacado;
        }
        else
        {
            Console.WriteLine("O saldo é insuficiente");
            return 0;
        }
    }
    else
    {
        Console.WriteLine("A senha está incorreta");
        return 0;
    }
}

public void Depositar(double pValorDepositado)
{
    saldo += pValorDepositado;
    Console.WriteLine("O valor depositado foi de: " + pValorDepositado);
}

public void ConsultaSaldo(string pSenha)
{
    if (senha == pSenha)
    {
        Console.WriteLine("O saldo da conta é: " + saldo);
    }
    else
    {
        Console.WriteLine("A senha está incorreta");
    }
}

    }

    internal class Program
{
    static void Main(string[] args)
    {
        ContaBancaria contaDoPedro = new ContaBancaria();
        contaDoPedro.saldo = 0;
        contaDoPedro.senha = "12345";
        contaDoPedro.nomeDoCliente = "Pedro Santos";

        double valorSacado = contaDoPedro.Sacar(10, "12345");
        contaDoPedro.Depositar(1000);
        contaDoPedro.ConsultaSaldo("12345");
        valorSacado = contaDoPedro.Sacar(10, "12345");
    }
}
}*/