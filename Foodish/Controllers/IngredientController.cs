using Foodish.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _ingredientService;

    public IngredientController(IIngredientService ingredientService)
    {
        _ingredientService = ingredientService;
    }

    [HttpGet]
    public IActionResult GetAllIngredients()
    {
        var ingredients = _ingredientService.GetAllIngredients();
        return Ok(ingredients);
    }

    [HttpGet("{id}")]
    public IActionResult GetIngredientById(int id)
    {
        var ingredient = _ingredientService.GetIngredientById(id);
        if (ingredient == null)
        {
            return NotFound();
        }
        return Ok(ingredient);
    }

    [HttpPost]
    public IActionResult AddIngredient(Ingredient ingredient)
    {
        _ingredientService.AddIngredient(ingredient);
        return CreatedAtAction(nameof(GetIngredientById), new { id = ingredient.IngredientId }, ingredient);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateIngredient(int id, Ingredient ingredient)
    {
        if (id != ingredient.IngredientId)
        {
            return BadRequest();
        }

        _ingredientService.UpdateIngredient(ingredient);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteIngredient(int id)
    {
        _ingredientService.DeleteIngredient(id);
        return NoContent();
    }
}
