using Foodish.Models;
using System.Collections.Generic;
using System.Linq;

namespace Foodish.Services
{
    public class RecipeIngredientService : IRecipeIngredientService
    {
        private readonly ApplicationDbContext _dbContext;

        public RecipeIngredientService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<RecipeIngredient> GetAllRecipeIngredients()
        {
            return _dbContext.RecipeIngredients.ToList();
        }

        public RecipeIngredient GetRecipeIngredientById(int recipeIngredientId)
        {
            return _dbContext.RecipeIngredients.Find(recipeIngredientId);
        }

        public void AddRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            _dbContext.RecipeIngredients.Add(recipeIngredient);
            _dbContext.SaveChanges();
        }

        public void UpdateRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            _dbContext.RecipeIngredients.Update(recipeIngredient);
            _dbContext.SaveChanges();
        }

        public void DeleteRecipeIngredient(int recipeIngredientId)
        {
            var recipeIngredient = _dbContext.RecipeIngredients.Find(recipeIngredientId);
            if (recipeIngredient != null)
            {
                _dbContext.RecipeIngredients.Remove(recipeIngredient);
                _dbContext.SaveChanges();
            }
        }
    }
}
