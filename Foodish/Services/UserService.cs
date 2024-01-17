﻿using Foodish.Models;

namespace Foodish.Services;
public class UserService : IUserService
{
    private readonly ApplicationDbContext _dbContext;

    public UserService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<User> GetAllUsers()
    {
        return _dbContext.Users.ToList();
    }

    public User GetUserById(int userId)
    {
        return _dbContext.Users.Find(userId);
    }

    public void AddUser(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }

    public void UpdateUser(User user)
    {
        _dbContext.Users.Update(user);
        _dbContext.SaveChanges();
    }

    public void DeleteUser(int userId)
    {
        var user = _dbContext.Users.Find(userId);
        if (user != null)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
    }
}
