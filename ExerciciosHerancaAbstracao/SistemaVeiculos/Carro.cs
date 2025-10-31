using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
   public class Carro : Veiculo
    {
        public double custoRevisao = 500;

        public Carro (string modelo, int ano){
            this.ano = ano;
            this.modelo = modelo;
        }

        public override void CalcularRevisao()
        {
            Console.WriteLine($"O custo da revisão é: {custoRevisao}");
        } 
    }
}