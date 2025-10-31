using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos
{
    public abstract class Curso
    {
        public string nome { get; set; }
        public int horas { get; set; }

        public abstract void CalcularPreco();
        public void ExibirResumo()
        {
            Console.WriteLine($"Nome do curso: {nome}");
            Console.WriteLine($"Horas Semanais: {horas}");
            CalcularPreco();
        }
    }
}