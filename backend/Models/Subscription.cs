using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(GroupId), nameof(UserId))]
public class Subscription { 
    [Column(Order = 0), Key, ForeignKey("Group")]
    public Guid GroupId { get; set; }

    [Column(Order = 1), Key, ForeignKey("User")]
    public Guid UserId { get; set; }

    [ForeignKey("Role")]
    public Guid RoleId { get; set; }

    public DateTime CreatedAt { get; set; }

    //Relationships
    public virtual Group Group { get; } = null!;
    public virtual User User { get; } = null!;
}