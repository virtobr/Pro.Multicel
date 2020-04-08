using Microsoft.EntityFrameworkCore;
using ProMulticel.Domain;

namespace ProMulticel.Repository
{
    public class ProMulticelContext : DbContext
    {
        public ProMulticelContext(DbContextOptions<ProMulticelContext> options) : base (options){}
        public DbSet <Formulario> Formularios { get; set; }
        public DbSet <Funcionario> Funcionarios { get; set; }
        public DbSet <FuncionarioFormulario> FuncionarioFormularios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<FuncionarioFormulario>()
            .HasKey(PE => new { PE.FormularioId, PE.FuncionarioId });
        }
        
    }
}