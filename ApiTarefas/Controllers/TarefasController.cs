using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTarefas.Data;
using ApiTarefas.Model;

namespace ApiTarefas.Controllers
{
    [Route("/tarefas")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ApiTarefasContext _context;

        public TarefasController(ApiTarefasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tarefas = await _context.Tarefa.ToListAsync();
            return StatusCode(200, tarefas);
        }
    }
}
