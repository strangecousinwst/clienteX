using PKX.Models;
using Microsoft.EntityFrameworkCore;


namespace PKX.Data

{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

        public DbSet<Cliente>? Clientes { get; set; }

        // public DbSet<Funcionario>? Funcionarios { get; set; }   

        
    }
}
