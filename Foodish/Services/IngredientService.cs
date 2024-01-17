using Foodish.Models;
using System.Collections.Generic;
using System.Linq;

namespace Foodish.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly ApplicationDbContext _dbContext;

        public IngredientService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _dbContext.Ingredients.ToList();
        }

        public Ingredient GetIngredientById(int ingredientId)
        {
            return _dbContext.Ingredients.Find(ingredientId);
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _dbContext.Ingredients.Add(ingredient);
            _dbContext.SaveChanges();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            _dbContext.Ingredients.Update(ingredient);
            _dbContext.SaveChanges();
        }

        public void DeleteIngredient(int ingredientId)
        {
            var ingredient = _dbContext.Ingredients.Find(ingredientId);
            if (ingredient != null)
            {
                _dbContext.Ingredients.Remove(ingredient);
                _dbContext.SaveChanges();
            }
        }
    }
}
