using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Foodish.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Required]
    [StringLength(100)]
    [Column("first_name")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(100)]
    [Column("last_name")]
    public string LastName { get; set; }

    [Required]
    [StringLength(100)]
    [Column("mail")]
    public string Mail { get; set; }

    [Required]
    [StringLength(100)]
    [Column("password")]
    public string Password { get; set; }

    [Required]
    [StringLength(100)]
    [Column("username")]
    public string Username { get; set; }

    [Required]
    [StringLength(100)]
    [Column("gender")]
    public string Gender { get; set; }
}
