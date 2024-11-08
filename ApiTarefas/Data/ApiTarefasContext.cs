using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiTarefas.Model;

namespace ApiTarefas.Data
{
    public class ApiTarefasContext : DbContext
    {
        public ApiTarefasContext (DbContextOptions<ApiTarefasContext> options)
            : base(options)
        {
        }

        public DbSet<ApiTarefas.Model.Tarefa> Tarefa { get; set; } = default!;
    }
}
