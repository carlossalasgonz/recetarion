using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Step {
    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [ForeignKey("Recipe")]
    public Guid RecipeId { get; set; }

    [ForeignKey("Image")]
    public Guid ImageId { get; set; }

    public string Description { get; set; } = null!;

    //Relationship
    public virtual Recipe Recipe { get; } = null!;
}