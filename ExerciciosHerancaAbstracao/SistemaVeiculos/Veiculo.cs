using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVeiculos
{
    public abstract class Veiculo
    {
        public string modelo { get; set; }
        public int ano { get; set; }

        public abstract void CalcularRevisao();
        public void ExibirResumo()
        {
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano: {ano}");
            CalcularRevisao();   
        }
    
    }
}