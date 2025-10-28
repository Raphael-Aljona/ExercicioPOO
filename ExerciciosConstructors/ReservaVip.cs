using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosP.O.O
{
    public class ReservaVip : Reserva
    {
        public double desconto{ get; set; }

        public ReservaVip(Hospede hospede, Quarto quarto, int dias, double valorTotal, double desconto) : base(hospede, quarto, dias, valorTotal)
        {
            this.desconto = desconto;
        }

        public override void CalcularTotal()
        {
            valorTotal = quarto.precoDiaria * dias * (1 - desconto);
            Console.WriteLine($"Desconto: {desconto * 100}%");
            Console.WriteLine($"O valor total da reserva é: {valorTotal:F2}");
        }   
    }
}