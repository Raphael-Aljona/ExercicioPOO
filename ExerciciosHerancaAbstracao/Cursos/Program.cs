namespace Cursos;

class Program
{
    static void Main(string[] args)
    {
        Tecnico t = new Tecnico("Desenvolvimento de Sistemas", 20);
        Superior s = new Superior("CiberSegurança", 20);

        Console.WriteLine("*** Curso 1 ***");
        t.ExibirResumo();
        Console.WriteLine("*** Curso 2 ***");

        s.ExibirResumo();
    }
}
