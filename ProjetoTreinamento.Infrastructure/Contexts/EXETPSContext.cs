using Microsoft.EntityFrameworkCore;
using ProjetoTreinamento.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTreinamento.Infrastructure.Contexts
{
    public class EXETPSContext(DbContextOptions<EXETPSContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define as chaves primárias e aponta as chaves derivadas das tabelas "Pais"
            
            modelBuilder.Entity<Tarefa>()
                .HasKey(x => new { x.Id });
            
            modelBuilder.Entity<Checklist>()
                .HasKey(x => new { x.IdTarefa, x.Id });

            modelBuilder.Entity<Item>()
                .HasKey(x => new { x.IdTarefa, x.IdChecklist, x.Id });


        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Checklist> Checklist { get; set; }
    }
}
