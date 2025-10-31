using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Leoa : Animal
    {
        public Leoa(string nome)
        {
            this.nome = nome;
        }

        public override void Alimentacao()
        {
            Console.WriteLine("Alimentação: Carnivoro");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Som: Rugido");
        }
    }
}