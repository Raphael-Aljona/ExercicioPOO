using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogo
{
    public class Mago : Personagem
    {
        public Mago(string nome, int nivel)
        {
            this.nome = nome;
            this.nivel = nivel;
        }

        public override void CalcularPoder()
        {
            poder = nivel * 8 + 20;
        } 
    }
}