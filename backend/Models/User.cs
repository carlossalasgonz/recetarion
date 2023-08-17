using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[Index(nameof(Email), IsUnique = true)]
public class User {

    [Column(Order = 0), Key]
    public Guid Id { get; private set;}

    [ForeignKey("Role")]
    public Guid UserRoleId { get; set; }

    [Column( TypeName = "varchar(255)" )]
    public string Email { get; set; } = null!;

    [Column( TypeName = "varchar(255)" )]
    public string Password { get ; set; } = null!;

    [Column( TypeName = "varchar(255)" )]
    public string? TokenFacebook { get; set; }

    [Column( TypeName = "varchar(255)" )]
    public string? TokenTwitter { get; set; }

    [Column( TypeName = "varchar(32)")]
    public string FirstName { get; set; } = null!;

    [Column( TypeName = "varchar(32)")]
    public string LastName { get; set; } = null!;

    public string? Description { get; set; }

    public bool LoggedIn { get; set; }

    [ForeignKey("Image")]
    public Guid ImageId { get; set; }

    public uint Followers { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime DeletedAt { get; set; }

    //Relationships
    public virtual UserRole Role { get; } = null!;

    public virtual Image Image { get; } = null!;

    //Generated attributes
    public string FullName {
        get {
            return FirstName + " " + LastName;
        }
    }
}
