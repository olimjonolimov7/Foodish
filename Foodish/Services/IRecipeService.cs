using Foodish.Models;
using System.Collections.Generic;

public interface IRecipeService
{
    List<Recipe> GetAllRecipes();
    Recipe GetRecipeById(int recipeId);
    void AddRecipe(Recipe recipe);
    void UpdateRecipe(Recipe recipe);
    void DeleteRecipe(int recipeId);
}
