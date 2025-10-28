using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosP.O.O
{
    public class Hospede
    {
        public string nome{ get; set; }
        public string cpf{ get; set; }

        public int telefone{ get; set; }

        public Hospede(string nome, string cpf, int telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;   
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("*** INFORMAÇÕES DO HÓSPEDE ***");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"telefone: {telefone}");
        }
    }
}