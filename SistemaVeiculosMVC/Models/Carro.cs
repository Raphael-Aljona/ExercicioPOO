using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVeiculosMVC.Models
{

   public class Carro : Veiculo
    {
        public double custoRevisao = 500;

        public Carro()
        {
            
        }

        public Carro(string modelo, int ano) : base (modelo, ano)
        {
        
        }

        public override double CalcularRevisao()
        {
            return custoRevisao;
        } 
    }
}