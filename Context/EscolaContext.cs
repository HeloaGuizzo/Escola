using Escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Context
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        { }
        
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("aluno");
            modelBuilder.Entity<Aluno>()
                .HasOne(e => e.Turma)
                .WithMany(e => e.Aluno)
                .HasForeignKey(e => e.Turma_Id);


            modelBuilder.Entity<Turma>().ToTable("turma");

            modelBuilder.Entity<Turma>()
                .HasMany(e => e.Aluno)
                .WithOne(e => e.Turma);
         }
    }
}
    

