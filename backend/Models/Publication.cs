using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Publication {

    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    //Relationships
    public virtual User User { get; } = null!;
}