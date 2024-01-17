using Foodish.Models;
using System.Collections.Generic;

public interface IIngredientService
{
    List<Ingredient> GetAllIngredients();
    Ingredient GetIngredientById(int ingredientId);
    void AddIngredient(Ingredient ingredient);
    void UpdateIngredient(Ingredient ingredient);
    void DeleteIngredient(int ingredientId);
}
