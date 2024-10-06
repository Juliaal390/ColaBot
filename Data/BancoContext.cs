using ColaBot_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace ColaBot_Web.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base (options)
        {
            
        }

        //db utilizado para armazenar contas
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
