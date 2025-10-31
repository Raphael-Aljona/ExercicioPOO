using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogo
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int nivel)
        {
            this.nome = nome;
            this.nivel = nivel;
        }

        public override void CalcularPoder()
        {
            poder = nivel * 10;
        } 
    }
}