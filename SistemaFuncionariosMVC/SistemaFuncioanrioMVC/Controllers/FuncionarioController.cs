using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaFuncioanrioMVC.Data;
using SistemaFuncioanrioMVC.Models;

namespace SistemaFuncioanrioMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly AppDbContext _context;

        public FuncionarioController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaFuncionario.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string nome, double salarioBase, string cargo)
        {
            Funcionario? novoFuncionario = null;
            if (cargo == "Gerente")
            {
                novoFuncionario = new Gerente(nome, salarioBase);
            }
            else if (cargo == "Vendedor")
            {
                novoFuncionario = new Vendedor(nome, salarioBase);
            }
            else
            {
                return BadRequest("Cargo invalido.");
            }
            _context.TabelaFuncionario.Add(novoFuncionario);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //Excluir
        public async Task<IActionResult> Deletar(int id)
        {
            var funcionario = await _context.TabelaFuncionario.FindAsync(id);
            if (funcionario == null) return NotFound();

            _context.TabelaFuncionario.Remove(funcionario);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}