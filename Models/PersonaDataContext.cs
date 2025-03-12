using Microsoft.EntityFrameworkCore;

namespace SimpleMVCApp.Models
{
    public class PersonaDataContext : DbContext
    {
        public DbSet<Persona> personas { get; set; }

        public PersonaDataContext(DbContextOptions<PersonaDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Persona>().HasData(
                new Persona
                {
                    PersonaID = 1,
                    Nombre = "Juan",
                    Apellidos = "Pérez",
                    Edad = 30
                },
                new Persona
                {
                    PersonaID = 2,
                    Nombre = "María",
                    Apellidos = "González",
                    Edad = 25
                },
                new Persona
                {
                    PersonaID = 3,
                    Nombre = "Carlos",
                    Apellidos = "Ramírez",
                    Edad = 40
                }
            );
        }
    }
}
