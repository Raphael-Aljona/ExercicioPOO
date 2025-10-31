using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    public abstract class Funcionario
    {
        public double salario { get; set; }
        public string nome { get; set; }

        public abstract void CalcularSalario();
        public void ExibirResumo()
        {
            Console.WriteLine($"Nome do Funcionário: {nome}");
            Console.WriteLine($"Salario sem bonificação: {salario}");
            CalcularSalario();
        }
    }
}