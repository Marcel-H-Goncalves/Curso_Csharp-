﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exemplo
{
    internal class Aviao : veiculo
    {
        private uint altitude;
        public uint Altitude
        {
            get { return altitude; }
        }
        public void Decolar(uint pVelocidade, uint pAltitude)
        {
            if (EstaLigado == true)
            {
                Console.WriteLine("Avião decolando...");
                altitude = pAltitude;
                Velocidade = pVelocidade;
                Console.WriteLine("Velocidade do avião: " + Velocidade);
                Console.WriteLine("Altitude do avião: " + altitude);
            }
            else
                Console.WriteLine("Avião desligado!");
        }
        public void Pousar()
        {
            Console.WriteLine("Avião pousando...");
            altitude = 0;
            Velocidade = 0;
            Console.WriteLine("Velocidade do avião: " + Velocidade);
            Console.WriteLine("Altitude do avião: " + altitude);
        }
        public Aviao(uint pNumeroRodas, uint pNumeroPortas) : base(pNumeroRodas, pNumeroPortas)
        {
            altitude = 0;
        }


    }
}
