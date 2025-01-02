using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_classe_abstrata
{
    //Modificador abstract
    //A classe com o modificador abstract só podera ser herdada.Ou seja, não poderemos criar instancia/objetos dessa classe
    internal class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void MostraNome()
        {
            Console.WriteLine("O nome da pessoa é: " + nome);
        }
        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }
}
