using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class GroupRole { 
    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [ForeignKey("Group")]
    public Guid GroupId { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Title { get; set; } = null!;
}