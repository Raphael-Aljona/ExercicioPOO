using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos
{
    public class Superior : Curso
    {
        
        public double valor { get; set; }

        public Superior(string nome, int horas)
        {
            this.nome = nome;
            this.horas = horas;
        }

        public override void CalcularPreco()
        {
            valor = horas * 40;
        }     
    }
}