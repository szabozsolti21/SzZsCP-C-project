using Common_Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Orvos_Asszisztens_Szerver.Repositories
{
    public class PatientContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=PatientsDB;Integrated Security=True;");
        }
    }
}
