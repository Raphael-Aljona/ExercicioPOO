using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    public class Gerente : Funcionario
    {
        public double bonus = 0.5;

        public Gerente(string nome ,double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public override void CalcularSalario()
        {
            Console.WriteLine($"O salário do Gerente é:{salario * (bonus + 1)}");
        }
}
    }