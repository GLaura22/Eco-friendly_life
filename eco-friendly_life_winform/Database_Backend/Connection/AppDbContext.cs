using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eco_friendly_life_winform.Database_Backend.Tables;
using Microsoft.EntityFrameworkCore;

namespace eco_friendly_life_winform.Database_Backend.Connection
{
    internal class AppDbContext : DbContext
    {
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";

        public DbSet<Comment> Comments { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<IngRecRel> IngRecRels { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Tipp> Tipps { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
