using Foodish.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
