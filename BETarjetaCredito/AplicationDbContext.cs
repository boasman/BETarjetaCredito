using BETarjetaCredito.Models;
using Microsoft.EntityFrameworkCore;

namespace BETarjetaCredito;

public class AplicationDbContext : DbContext
{

    public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
    {
            
    }
   
    public DbSet<TarjetaCredito> tarjetaCreditos { get; set; }
}
