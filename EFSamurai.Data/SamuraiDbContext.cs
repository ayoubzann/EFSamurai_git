using Microsoft.EntityFrameworkCore;
using EFSamurai.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFSamurai.Data
{
    public class SamuraiDbContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<SecretIdentity> SecretIdentities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = (localdb)\MSSQLLocalDB; " +
                "Database = EFSamurai; " +
                "Trusted_Connection = True;");
        }
        // add-migration -StartupProject EFSamurai.data -Project EFSamurai.data MigrationName
        // update-database -StartupProject EFSamurai.data -Project EfSamurai.data
    }
}