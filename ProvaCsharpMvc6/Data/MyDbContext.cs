using Microsoft.EntityFrameworkCore;
using ProvaCsharpMvc6.Models;

namespace ProvaCsharpMvc6.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
