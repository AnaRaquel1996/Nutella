using Microsoft.EntityFrameworkCore;
using Nutella.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutella.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<Produtos>().HasData(
                new Produtos
                {
                    Id = 1,
                    Name = "Nutella Chocolate Branco",
                    Description = "Taste...",
                    Price = 5,
                    ImageUrl = "",
                },
                new Produtos
                {
                    Id = 2,
                    Name = "Nutella Clássica",
                    Description = "Taste...",
                    Price = 4,
                    ImageUrl = "",
                },
                new Produtos
                {
                    Id = 3,
                    Name = "Nutella Crocante",
                    Description = "Taste...",
                    Price = 7,
                    ImageUrl = "",
                }

                );
        }
    }
}