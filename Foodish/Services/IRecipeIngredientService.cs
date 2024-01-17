using Foodish.Models;
using System.Collections.Generic;

public interface IRecipeIngredientService
{
    List<RecipeIngredient> GetAllRecipeIngredients();
    RecipeIngredient GetRecipeIngredientById(int recipeIngredientId);
    void AddRecipeIngredient(RecipeIngredient recipeIngredient);
    void UpdateRecipeIngredient(RecipeIngredient recipeIngredient);
    void DeleteRecipeIngredient(int recipeIngredientId);
}
