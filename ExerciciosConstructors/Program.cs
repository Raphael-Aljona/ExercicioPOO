namespace ExerciciosP.O.O;

class Program
{
    static public List<Reserva> reservas = new List<Reserva>();

    static void Main(string[] args)
    {
        Hospede hospede = new Hospede("Raphael", "123.456.789-00", 912345678);
        Hospede hospede2 = new Hospede("Vitor", "987.654.321-00", 987654321);

        Quarto quarto = new Quarto(1, "Suíte", 199.99);
        Quarto quarto2= new Quarto(2, "Suíte", 399.99);

        Reserva reserva1 = new Reserva(hospede, quarto, 3, 0);
        ReservaVip reserva2 = new ReservaVip(hospede2, quarto2, 5, 0, 0.1);

        reservas.Add(reserva1);
        reservas.Add(reserva2);

        foreach(Reserva reserva in reservas)
        {
            reserva.ResumoReserva();
        }
    }


}

