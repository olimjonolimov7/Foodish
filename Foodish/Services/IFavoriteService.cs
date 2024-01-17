using Foodish.Models;
using System.Collections.Generic;

public interface IFavoriteService
{
    List<Favorite> GetAllFavorites();
    Favorite GetFavoriteById(int favoriteId);
    void AddFavorite(Favorite favorite);
    void UpdateFavorite(Favorite favorite);
    void DeleteFavorite(int favoriteId);
}
