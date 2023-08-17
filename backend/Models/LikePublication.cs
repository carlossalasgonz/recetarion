using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(UserId), nameof(PublicationId))]
public class LikePublication {

    [Column(Order = 0), Key, ForeignKey("User")]
    public Guid UserId { get; set; }

    [Column(Order = 1), Key, ForeignKey("Publication")]
    public Guid PublicationId { get; set; }

    //Relationships
    public virtual User User { get; } = null!;
    public virtual Publication Publication { get; } = null!;
}