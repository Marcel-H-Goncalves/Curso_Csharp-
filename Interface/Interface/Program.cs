using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface é um protótipo de uma classe(esqueleto/contrato)
//Ela define os métodos que serão implementados pela classe.

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.AbrirPorta();
            meuCarro.FecharPorta();
            meuCarro.Ligar();
            meuCarro.Desligar();
            meuCarro.Acelerar();

            Aviao MeuAviao = new Aviao();
            MeuAviao.AbrirPorta();
            MeuAviao.FecharPorta();
            MeuAviao.Ligar();
            MeuAviao.Desligar();
            MeuAviao.Decolar();

            IVeiculo meuVeiculoCarro = new Carro();
            meuVeiculoCarro.AbrirPorta();
            meuVeiculoCarro.FecharPorta();
            meuVeiculoCarro.Ligar();
            meuVeiculoCarro.Desligar();
           

            IVeiculo meuVeiculoAviao = new Aviao();
            meuVeiculoAviao.AbrirPorta();
            meuVeiculoAviao.FecharPorta();
            meuVeiculoAviao.Ligar();
            meuVeiculoAviao.Desligar();
            

        }
    }
}
