using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(RecipeId), nameof(IngredientId))]
public class RecipeIngredient {
    [Column(Order = 0), Key, ForeignKey("Recipe")]
    public Guid RecipeId { get; private set; }

    [Column(Order = 1), Key, ForeignKey("Ingredient")]
    public Guid IngredientId { get; private set;}

    public uint quantity { get; set; }

    [ForeignKey("Unit")]    
    public Guid UnitId { get; set; }

    //Relationships
    public virtual Recipe Recipe { get; } = null!;
    public virtual Ingredient Ingredient { get; } = null!;
    public virtual Unit Unit { get; } = null!;
}