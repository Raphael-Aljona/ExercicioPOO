using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosP.O.O
{
    public class Reserva
    {
        public ReservaVip reservaVip;
        public Hospede hospede{ get; set; }
        public Quarto quarto{ get; set; }

        public int dias{ get; set; }

        public double valorTotal{ get; set; }

        public Reserva(Hospede hospede, Quarto quarto, int dias, double valorTotal)
        {
            this.hospede = hospede;
            this.quarto = quarto;
            this.dias = dias;
            this.valorTotal = valorTotal;   
        }

        public virtual void CalcularTotal()
        {
            valorTotal = quarto.precoDiaria * dias;
            Console.WriteLine($"O valor total da reserva é: {valorTotal}");
        }

        public void ResumoReserva()
        {

            Console.WriteLine("*** INFORMAÇÔES DA RESERVA ***");
            Console.WriteLine($"Hospede: {hospede.nome}");
            Console.WriteLine($"Quarto: {quarto.numero}");
            Console.WriteLine($"Dias reservados: {dias}");
            CalcularTotal();


        }
    }
}