using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Carro : Veiculo
    {
        public int qtdPortas { get; set; }

        public Carro(string marca, string modelo, int ano, int qtdPortas) : base(marca, modelo, ano)
        {
            this.qtdPortas = qtdPortas;
        }
        
        public override void Ligar()
        {
            
        }
    }
}