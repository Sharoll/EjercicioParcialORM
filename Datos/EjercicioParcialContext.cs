using Entidad;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class EjercicioParcialContext :  DbContext
    {
        public EjercicioParcialContext(DbContextOptions options) : base(options){

        }
        public DbSet<Persona> Personas { get; set; }
        
        public DbSet<Apoyo> Apoyos { get; set; }
       
    }
}