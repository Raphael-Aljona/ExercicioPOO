using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAnimais
{
    public abstract class Animal
    {
        public string nome { get; set; }

        public abstract void EmitirSom();
        public abstract void Alimentacao();
    }
}