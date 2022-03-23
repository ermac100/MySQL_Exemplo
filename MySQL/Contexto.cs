using MySQL.Entidades;
using Microsoft.EntityFrameworkCore;

namespace MySQL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option) { }


        public DbSet<Usuario> USUARIOS { get; set; }
    }
}
