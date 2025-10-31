namespace SistemaVeiculos;

class Program
{
    static void Main(string[] args)
    {
        Carro c = new Carro("Fiesta", 2020);
        Moto m = new Moto("Pop 100", 2015);

        Console.WriteLine("*** VEICULO 1 ***");
        m.ExibirResumo();
        Console.WriteLine("*** VEICULO 2 ***");
        c.ExibirResumo();
    }
}
