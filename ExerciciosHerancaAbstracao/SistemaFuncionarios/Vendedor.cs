using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    public class Vendedor : Funcionario
    {
        public double bonus = 0.2;

        public Vendedor(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public override void CalcularSalario()
        {
            double salarioBonificado = salario * (bonus + 1);
            Console.WriteLine($"O salário do Gerente é:{salarioBonificado}");
        }
    }
}