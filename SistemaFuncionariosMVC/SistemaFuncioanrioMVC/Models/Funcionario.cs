using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFuncioanrioMVC.Models
{
    public abstract class Funcionario
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string nome { get; set; } = string.Empty;

        [Range(0, 10000)]
        public double salarioBase { get; set; }

        //metodo construtor para conversar com o banco
        public Funcionario() { }

        public Funcionario(string nome, double salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }

        public abstract double CalcularSalario();
    }
}