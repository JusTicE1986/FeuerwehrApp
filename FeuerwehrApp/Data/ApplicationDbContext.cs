using Microsoft.EntityFrameworkCore;
using FeuerwehrApp.Models;


namespace FeuerwehrApp.Data

{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Atemschutzmaske> Masken { get; set; }
        public DbSet<Atemschutzgeraet> Geraete { get; set; }
        public DbSet<Geraetetraeger> AGT { get; set; }
        public DbSet<Fuehrerschein> DrivingLicense { get; set; }
        public DbSet<Feuerwehrmann> Feuerwehrmann { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
