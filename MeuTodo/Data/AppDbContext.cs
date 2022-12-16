using MeuTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Data
{
    public class AppDbContext : DbContext
    {
        //Tabelas
        public DbSet <Todo> Todos { get; set; }

        //Conexão com o banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite(connectionString: "DataSource=app.db; Cache=Shared");
      
    }
}
