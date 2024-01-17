using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Foodish.Models;

[Table("favorite")] // Specify the table name here
public class Favorite
{
    [Column("user_id")] // Specify the column name for the UserId property
    public int UserId { get; set; }

    [Column("recipe_id")] // Specify the column name for the RecipeId property
    public int RecipeId { get; set; }

    [Column("favorite_id")] // Specify the column name for the Quantity property
    public int FavoriteId { get; set; }

    [ForeignKey("UserId")] // Specify the foreign key relationship with the Users table
    public virtual User User { get; set; }

    [ForeignKey("RecipeId")] // Specify the foreign key relationship with the Recipes table
    public virtual Recipe Recipe { get; set; }
}
