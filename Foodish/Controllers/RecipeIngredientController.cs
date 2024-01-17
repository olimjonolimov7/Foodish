using Foodish.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class RecipeIngredientController : ControllerBase
{
    private readonly IRecipeIngredientService _recipeIngredientService;

    public RecipeIngredientController(IRecipeIngredientService recipeIngredientService)
    {
        _recipeIngredientService = recipeIngredientService;
    }

    [HttpGet]
    public IActionResult GetAllRecipeIngredients()
    {
        var recipeIngredients = _recipeIngredientService.GetAllRecipeIngredients();
        return Ok(recipeIngredients);
    }

    [HttpGet("{id}")]
    public IActionResult GetRecipeIngredientById(int id)
    {
        var recipeIngredient = _recipeIngredientService.GetRecipeIngredientById(id);
        if (recipeIngredient == null)
        {
            return NotFound();
        }
        return Ok(recipeIngredient);
    }

    [HttpPost]
    public IActionResult AddRecipeIngredientByRecipeId(RecipeIngredient recipeIngredient)
    {
        _recipeIngredientService.AddRecipeIngredient(recipeIngredient);
        return CreatedAtAction(nameof(GetRecipeIngredientById), new { id = recipeIngredient.RecipeId }, recipeIngredient);
    }

    [HttpPost]
    public IActionResult AddRecipeIngredientByIngredientId(RecipeIngredient recipeIngredient)
    {
        _recipeIngredientService.AddRecipeIngredient(recipeIngredient);
        return CreatedAtAction(nameof(GetRecipeIngredientById), new { id = recipeIngredient.IngredientId }, recipeIngredient);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRecipeIngredientByRecipeId(int id, RecipeIngredient recipeIngredient)
    {
        if (id != recipeIngredient.RecipeId)
        {
            return BadRequest();
        }

        _recipeIngredientService.UpdateRecipeIngredient(recipeIngredient);
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRecipeIngredientByIngredientId(int id, RecipeIngredient recipeIngredient)
    {
        if (id != recipeIngredient.IngredientId)
        {
            return BadRequest();
        }

        _recipeIngredientService.UpdateRecipeIngredient(recipeIngredient);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteRecipeIngredient(int id)
    {
        _recipeIngredientService.DeleteRecipeIngredient(id);
        return NoContent();
    }
}
