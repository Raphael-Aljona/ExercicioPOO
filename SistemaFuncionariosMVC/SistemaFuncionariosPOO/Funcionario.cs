using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SistemaFuncionariosMVC
{
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public double salarioBase { get; set; }

        public Funcionario(string nome, double salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }

        public abstract double CalcularSalario();
        
        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário base: R${salarioBase}");
            Console.WriteLine($"Salário final: R${CalcularSalario():F2}");
        }

    }
}