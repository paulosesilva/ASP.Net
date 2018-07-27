using System.Data.Entity;

namespace ECommerce.Models
{
    public class Context : DbContext
    {
        public Context() : base("BancoDeDados") { }

        public DbSet<Produto> Produtos { get; set; }
    }
}