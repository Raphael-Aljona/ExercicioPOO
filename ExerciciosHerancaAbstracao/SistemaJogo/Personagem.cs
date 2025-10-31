using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogo
{
    public abstract class Personagem
    {
        public string nome{ get; set; }
        public int nivel{ get; set; }

        public int poder{ get; set; }

        public abstract void CalcularPoder();
        
        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Nivel: {nivel}");
            CalcularPoder();
            Console.WriteLine($"Poder: {poder}");

        }
    }
}