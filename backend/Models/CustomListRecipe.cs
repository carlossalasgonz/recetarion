using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(CustomListId), nameof(RecipeId))]
public class CustomListRecipe {
    [Column(Order = 0), Key, ForeignKey("User")]
    public Guid CustomListId { get; set; }

    [Column(Order = 1), Key, ForeignKey("Recipe")]
    public Guid RecipeId { get; set; }

    //Relationships
    public virtual User User { get; } = null!;
    public virtual Recipe Recipe { get; } = null!;
}