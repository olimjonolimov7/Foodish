using Foodish.Models;

namespace Foodish.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly ApplicationDbContext _dbContext;

        public RecipeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Recipe> GetAllRecipes()
        {
            return _dbContext.Recipes.ToList();
        }

        public Recipe GetRecipeById(int recipeId)
        {
            return _dbContext.Recipes.Find(recipeId);
        }

        public void AddRecipe(Recipe recipe)
        {
            _dbContext.Recipes.Add(recipe);
            _dbContext.SaveChanges();
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _dbContext.Recipes.Update(recipe);
            _dbContext.SaveChanges();
        }

        public void DeleteRecipe(int recipeId)
        {
            var recipe = _dbContext.Recipes.Find(recipeId);
            if (recipe != null)
            {
                _dbContext.Recipes.Remove(recipe);
                _dbContext.SaveChanges();
            }
        }
    }
}
