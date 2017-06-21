using NGCooking.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NGCooking.DAL
{
    public class Context  : DbContext
    {
        public Context() : base("NgCooking")
{
        }

        public DbSet<Community> Community { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<CategoryIngedient> IngredientsCategories { get; set; }
        public DbSet<CategoryRecipe> ReceiptsCategories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Recipe> Receipts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}