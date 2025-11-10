using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace SistemaVeiculosMVC.Models
{
    public class Moto : Veiculo
    {
        public double custoRevisao = 300;

        public Moto()
        {

        }
        public Moto(string modelo, int ano) : base(modelo, ano)
        {

        }

        public override double CalcularRevisao()
        {
            return custoRevisao;
        }
    }
}