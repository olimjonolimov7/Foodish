using Foodish.Models;
using System.Collections.Generic;
using System.Linq;

namespace Foodish.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly ApplicationDbContext _dbContext;

        public FavoriteService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Favorite> GetAllFavorites()
        {
            return _dbContext.Favorites.ToList();
        }

        public Favorite GetFavoriteById(int favoriteId)
        {
            return _dbContext.Favorites.Find(favoriteId);
        }

        public void AddFavorite(Favorite favorite)
        {
            _dbContext.Favorites.Add(favorite);
            _dbContext.SaveChanges();
        }

        public void UpdateFavorite(Favorite favorite)
        {
            _dbContext.Favorites.Update(favorite);
            _dbContext.SaveChanges();
        }

        public void DeleteFavorite(int favoriteId)
        {
            var favorite = _dbContext.Favorites.Find(favoriteId);
            if (favorite != null)
            {
                _dbContext.Favorites.Remove(favorite);
                _dbContext.SaveChanges();
            }
        }
    }
}
