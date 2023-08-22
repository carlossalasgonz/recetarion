using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(UserRolesId), nameof(Action) )]
public class UserPermission {
    [Column(Order = 0), Key, ForeignKey("Role")]
    public Guid UserRolesId { get; set; }
    
    [Column(Order = 1), Key]
    public string Action { get; set; } = null!;

    //Relationships
    public virtual UserRole Role { get; } = null!;
}