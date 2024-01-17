using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Foodish.Models;

[Table("recipes")]
public class Recipe
{
    [Key]
    [Column("recipe_id")]
    public int RecipeId { get; set; }

    [Required]
    [StringLength(100)]
    [Column("title")]
    public string Title { get; set; }

    [Required]
    [StringLength(100)]
    [Column("recipe_type")]
    public string RecipeType { get; set; }

    [Required]
    [StringLength(400)]
    [Column("photo")]
    public string Photo { get; set; }

    [Required]
    [Column("description")]
    public string Description { get; set; }

    [Required]
    [StringLength(100)]
    [Column("difficulty_level")]
    public string DifficultyLevel { get; set; }

    [Required]
    [Column("cooking_time")]
    public int CookingTime { get; set; }

    [Required]
    [Column("reyting")]
    public int Rating { get; set; }
}
