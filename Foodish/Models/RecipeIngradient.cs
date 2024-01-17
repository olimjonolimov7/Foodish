using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Foodish.Models;
[Table("recipe_ingredient")] // Specify the table name here
public class RecipeIngredient
{
    [Key]
    [Column("recipe_id")] // Specify the column name for the RecipeId property
    public int RecipeId { get; set; }

    [Column("ingredient_id")] // Specify the column name for the IngredientId property
    public int IngredientId { get; set; }

    [Column("quantity")] // Specify the column name for the Quantity property
    public int Quantity { get; set; }

    [ForeignKey("RecipeId")] // Specify the foreign key relationship with the Recipes table
    public virtual Recipe Recipe { get; set; }

    [ForeignKey("IngredientId")] // Specify the foreign key relationship with the Ingredients table
    public virtual Ingredient Ingredient { get; set; }
}
