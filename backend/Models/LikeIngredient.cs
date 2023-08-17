using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(UserId), nameof(IngredientId))]
public class LikeIngredient {
    [Column(Order = 0), Key]
    public Guid UserId { get; private set; }

    [Column(Order = 1), Key, ForeignKey("Ingredient")]
    public Guid IngredientId { get; private set; }

    public bool IsDislike { get; set; }

    //Relationships
    public virtual User User { get; } = null!;
    public virtual Ingredient Ingredient { get; } = null!;
}