namespace SistemaFuncionarios;

class Program
{
    static void Main(string[] args)
    {
        Gerente g = new Gerente("Lauro", 5000);
        Vendedor v = new Vendedor("Fabia", 1500);

        v.ExibirResumo();
        g.ExibirResumo();
    }
}
