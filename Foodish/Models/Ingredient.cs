using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Foodish.Models;

[Table("ingredients")] // Specify the table name here
public class Ingredient
{
    [Column("ingredient_id")] // Specify the column name for the IngredientId property
    public int IngredientId { get; set; }

    [Required]
    [Column("ingredient_name")] // Specify the column name for the IngredientName property
    public string IngredientName { get; set; }

    [Column("ingredient_unit")] // Specify the column name for the IngredientUnit property
    public string IngredientUnit { get; set; }
}
