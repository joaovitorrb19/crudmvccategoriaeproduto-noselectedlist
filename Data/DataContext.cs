using ControleEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.Data{
    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base (options){

        }

        public DbSet<Produto> Produtos{get;set;}

        public DbSet<Categoria> Categorias {get;set;} 

    }
}