using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Carro : Veiculo
    {
        public override void Anda()
        {
            base.Anda();
            Console.WriteLine("O carro está andando");
        }
    }
}
