using MiniErp2.DataModels;
using Microsoft.EntityFrameworkCore;


namespace MiniErp2
{
    public class Contexto : DbContext
    {

        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Produtos> produtos { get; set; }
        public DbSet<Pedido> pedido { get; set; }
        public DbSet<Fornecedores> fornecedor { get; set; }
        public DbSet<Notas> notas { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=MiniERPQ;User ID=MiniERPQ;password=MiniERPQ;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(e => e.cliente)
                .WithMany(e => e.pedidos)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Pedido>()
            .HasOne(e => e.nota)
            .WithMany(e => e.pedidos)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Pedido>()
          .HasOne(e => e.produtos)
          .WithMany(e => e.pedidos)
          .OnDelete(DeleteBehavior.ClientCascade);

 
        }

    }
}