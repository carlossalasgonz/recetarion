using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(GroupRoleId), nameof(Action))]
public class GroupPermission { 
    [Column(Order = 0), Key, ForeignKey("Role")]
    public Guid GroupRoleId { get; private set; }

    [Column(Order = 1, TypeName = "varchar(255)"), Key]
    public string Action { get; set; } = null!;

    //Relationships
    public virtual GroupRole GroupRole { get; } = null!;
}