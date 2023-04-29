using Examen.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace Examen.API.DATA
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Boleto> boletos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Boleto>().HasIndex(x => x.Id).IsUnique();
        }
    }
}
