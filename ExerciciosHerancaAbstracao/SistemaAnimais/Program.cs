namespace SistemaAnimais;

class Program
{
    static void Main(string[] args)
    {
        Elefante e = new Elefante("Elefante");
        Leoa l = new Leoa("Leoa");

        Console.WriteLine("Animal 1");
        l.EmitirSom();
        l.Alimentacao();
        Console.WriteLine("Animal 2");
        e.EmitirSom();
        e.Alimentacao();
    }
}
