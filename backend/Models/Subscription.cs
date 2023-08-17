using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(GroupId), nameof(UserId))]
public class Subscription { 
    [Column(Order = 0), Key, ForeignKey("Group")]
    public Guid GroupId { get; private set; }

    [Column(Order = 1), Key, ForeignKey("User")]
    public Guid UserId { get; private set; }

    [ForeignKey("Role")]
    public Guid RoleId { get; set; }

    public DateTime CreatedAt { get; private set; }

    //Relationships
    public virtual Group Group { get; } = null!;
    public virtual User User { get; } = null!;
    public virtual GroupRole Role { get; } = null!;
}