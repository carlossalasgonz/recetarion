using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Critic {
    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [ForeignKey("Publication")]
    public Guid PublicationId { get; set; }

    [ForeignKey("Recipe")]
    public Guid RecipeId { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    //Relationships
    public virtual Publication Publication { get; } = null!;
    public virtual Recipe Recipe { get; } = null!;
}