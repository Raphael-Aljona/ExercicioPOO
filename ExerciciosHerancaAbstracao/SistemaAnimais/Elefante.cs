using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public class Elefante : Animal
    {
        public Elefante(string nome)
        {
            this.nome = nome;
        }

         public override void Alimentacao()
        {
            Console.WriteLine("Alimentação: Herbivoro");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Som: Barrito");
        }
    }
}