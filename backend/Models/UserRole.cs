using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Web;

namespace Recetarion.Models;

public class UserRole{

    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [Column( TypeName = "varchar(32)")]
    public string Title { get; set; } = null!;

    //Relationship
    public virtual ICollection<UserPermission> Permissions { get; } = new List<UserPermission>();
}