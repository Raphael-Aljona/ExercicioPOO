namespace SistemaJogo;

class Program
{
    static void Main(string[] args)
    {
        Guerreiro g = new Guerreiro("Bárbaro", 20);
        Mago m = new Mago("Mago de Fogo", 22);

        m.ExibirStatus();
        g.ExibirStatus();
    }
}
