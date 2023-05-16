using Microsoft.EntityFrameworkCore;
using ModernRecrut.Emplois.API.Models;

namespace ModernRecrut.Emplois.API.Data
{
    public class EmploiContext : DbContext
    {
        public DbSet<Emploi> Emplois { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlite(@"\ModernRecrut\ModernRecrut.Emplois.API\Emplois.db");

        public EmploiContext(DbContextOptions<EmploiContext> options) : base(options)
        {

        }

    }
}
