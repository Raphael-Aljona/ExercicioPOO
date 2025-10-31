using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public class Moto : Veiculo
    {
        public double custoRevisao = 300;

        public Moto (string modelo, int ano){
            this.ano = ano;
            this.modelo = modelo;
        }

        public override void CalcularRevisao()
        {
            Console.WriteLine($"O custo da revisão é: {custoRevisao}");
        } 
    }
}