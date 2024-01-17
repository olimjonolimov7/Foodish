using Foodish.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class FavoriteController : ControllerBase
{
    private readonly IFavoriteService _favoriteService;

    public FavoriteController(IFavoriteService favoriteService)
    {
        _favoriteService = favoriteService;
    }

    [HttpGet]
    public IActionResult GetAllFavorites()
    {
        var favorites = _favoriteService.GetAllFavorites();
        return Ok(favorites);
    }

    [HttpGet("{id}")]
    public IActionResult GetFavoriteById(int id)
    {
        var favorite = _favoriteService.GetFavoriteById(id);
        if (favorite == null)
        {
            return NotFound();
        }
        return Ok(favorite);
    }

    [HttpPost]
    public IActionResult AddFavorite(Favorite favorite)
    {
        _favoriteService.AddFavorite(favorite);
        return CreatedAtAction(nameof(GetFavoriteById), new { id = favorite.FavoriteId }, favorite);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateFavorite(int id, Favorite favorite)
    {
        if (id != favorite.FavoriteId)
        {
            return BadRequest();
        }

        _favoriteService.UpdateFavorite(favorite);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteFavorite(int id)
    {
        _favoriteService.DeleteFavorite(id);
        return NoContent();
    }
}
