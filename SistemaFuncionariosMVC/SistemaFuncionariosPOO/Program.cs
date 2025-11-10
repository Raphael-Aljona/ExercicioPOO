namespace SistemaFuncionariosMVC;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Gerente("Kessia", 5000),
            new Vendedor("Thiago", 3000)
        };

        foreach(var funcionario in funcionarios)
        {
            funcionario.ExibirResumo();
        }
    }
}
