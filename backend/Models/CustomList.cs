using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class CustomList {
    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    //Relationship
    public virtual User User { get; } = null!;
}