using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Aviao : IVeiculo
    {
        public void Ligar()
        {
            Console.WriteLine("O Avião está ligado!");
        }
        public void Desligar()
        {
            Console.WriteLine("O Avião está desligado");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("A porta do Avião está aberta!");
        }
        public void FecharPorta()
        {
            Console.WriteLine("A porta do Avião está fechada!");
        }
        public void Decolar()
        {
            Console.WriteLine("O avião decolou!");
        }



     }
}
