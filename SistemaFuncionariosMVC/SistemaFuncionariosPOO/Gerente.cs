using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFuncionariosMVC
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salarioBase) : base(nome, salarioBase)
        {

        }

        public override double CalcularSalario()
        {
            return salarioBase * 1.5;
        }
    }
}