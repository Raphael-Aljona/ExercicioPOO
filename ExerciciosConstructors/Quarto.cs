using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosP.O.O
{
    public class Quarto
    {
        public int numero{ get; set; }
        public string tipo{ get; set; }

        public double precoDiaria{ get; set; }

        public bool disponivel{ get; set; }

        public Quarto(int numero, string tipo, double precoDiaria)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.precoDiaria = precoDiaria;
            disponivel = false;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("*** INFORMAÇÔES DO QUARTO ***");
            Console.WriteLine($"Numero do quarto: {numero}");
            Console.WriteLine($"Tipo do quarto: {tipo}");
            Console.WriteLine($"Preco da diária: {precoDiaria}");
            Console.WriteLine($"Disponibilidade do quarto: {disponivel}");
        }

        public void Ocupar()
        {
            disponivel = false;
            Console.WriteLine($"O quarto: {numero}, foi reservado com sucesso");
        }
        
        public void Liberar()
        {
            disponivel = true;
            Console.WriteLine($"O quarto: {numero}, foi liberado com sucesso");
        }
    }
}