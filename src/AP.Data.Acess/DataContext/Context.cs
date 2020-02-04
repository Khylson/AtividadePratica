using AP.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace AP.Data.Acess.DataContext
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.OpenConnection();
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

    }
}
