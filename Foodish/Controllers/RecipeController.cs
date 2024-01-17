using Foodish.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class RecipeController : ControllerBase
{
    private readonly IRecipeService _recipeService;

    public RecipeController(IRecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    [HttpGet]
    public IActionResult GetAllRecipes()
    {
        var recipes = _recipeService.GetAllRecipes();
        return Ok(recipes);
    }

    [HttpGet("{id}")]
    public IActionResult GetRecipeById(int id)
    {
        var recipe = _recipeService.GetRecipeById(id);
        if (recipe == null)
        {
            return NotFound();
        }
        return Ok(recipe);
    }

    [HttpPost]
    public IActionResult AddRecipe(Recipe recipe)
    {
        _recipeService.AddRecipe(recipe);
        return CreatedAtAction(nameof(GetRecipeById), new { id = recipe.RecipeId }, recipe);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRecipe(int id, Recipe recipe)
    {
        if (id != recipe.RecipeId)
        {
            return BadRequest();
        }

        _recipeService.UpdateRecipe(recipe);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteRecipe(int id)
    {
        _recipeService.DeleteRecipe(id);
        return NoContent();
    }
}
