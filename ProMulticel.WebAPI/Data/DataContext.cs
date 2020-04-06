using Microsoft.EntityFrameworkCore;
using ProMulticel.WebAPI.Model;

namespace ProMulticel.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet <Formulario> Formularios { get; set; }
        
    }
}