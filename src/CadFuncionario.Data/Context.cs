using CadFuncionario.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadFuncionario.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<StepProfissao> StepProfissoes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}