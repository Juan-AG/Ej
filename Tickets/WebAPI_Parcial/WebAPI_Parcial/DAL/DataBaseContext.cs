using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebAPI_Parcial.DAL.Entities;

namespace WebAPI_Parcial.DAL
{
    public class DataBaseContext:DbContext
    {
        //Con este contructor me podré conectar a la BD, me brinda unas opciones de configuración que ya están definidas internamente
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().HasIndex(c => c.Name).IsUnique(); //El nombre del hotel debe ser unico
            modelBuilder.Entity<Hotel>().HasIndex(c => c.Phone).IsUnique(); //Un telefono solo le puede corresponder a un hotel
        }

        public DbSet<Hotel> Hotels { get; set; } 
        public DbSet<Room> Rooms { get; set; }

    }
}
