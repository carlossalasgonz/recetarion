using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class GroupRole { 
    [Column(Order = 0), Key]
    public Guid Id { get; set; }

    [ForeignKey("Group")]
    public Guid GroupId { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Title { get; set; } = null!;

    //Relationships
    public virtual Group Group { get; } = null!;
    public virtual ICollection<GroupPermission> Permissions { get; } = new List<GroupPermission>();

}