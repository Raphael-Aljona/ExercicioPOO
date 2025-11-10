using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }

        public Veiculo(string marca, string modelo, int ano)
        {
            this.ano = ano;
            this.modelo = modelo;
            this.marca = marca;
        }

        public virtual void Ligar()
        {
            Console.WriteLine($"O veiculo {modelo} está ligado!");
        }

    }
}