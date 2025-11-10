using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SistemaVeiculosMVC.Data;
using SistemaVeiculosMVC.Models;

namespace SistemaVeiculosMVC.Controllers
{

    public class VeiculoController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaVeiculo.ToListAsync();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string modelo, int ano, string veiculo)
        {
            Veiculo? novoVeiculo = null;
            if (veiculo == "Carro")
            {
                novoVeiculo = new Carro(modelo, ano);
            }
            else if (veiculo == "Moto")
            {
                novoVeiculo = new Moto(modelo, ano);
            }
            else
            {
                return BadRequest("Veiculo Inválido");
            }
            _context.TabelaVeiculo.Add(novoVeiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Deletar(int id)
        {
            var carro = await _context.TabelaVeiculo.FindAsync(id);
            if (carro == null) return NotFound();

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}