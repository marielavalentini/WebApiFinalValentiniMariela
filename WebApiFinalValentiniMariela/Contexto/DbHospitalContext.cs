using Microsoft.EntityFrameworkCore;
using WebApiFinalValentiniMariela.Models;

namespace WebApiFinalValentiniMariela.Conection
{
    public class DbHospitalContext : DbContext
    {
        public DbHospitalContext (DbContextOptions<DbHospitalContext> options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }

    }
}
