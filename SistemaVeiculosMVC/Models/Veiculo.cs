using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVeiculosMVC.Models
{
    public abstract class Veiculo
    {
        [Key]
        public int id { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string modelo, int ano)
        {
            this.modelo = modelo;
            this.ano = ano;
        }

        public abstract double CalcularRevisao();


        public void ExibirResumo()
        {
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano: {ano}");
            CalcularRevisao();
        }

    }

}