using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[Index(nameof(Email), IsUnique = true)]
public class User {

    [Column(Order = 0), Key]
    public Guid Id { get; set;}

    [ForeignKey("Role")]
    public Guid UserRoleId { get; set; }

    [Column( TypeName = "varchar(255)" )]
    public string Username { get; set; } = null!;

    [Column( TypeName = "varchar(255)" )]
    public string Email { get; set; } = null!;

    [Column( TypeName = "varchar(255)" )]
    public string PasswordSalt { get ; set; } = null!;

    [Column( TypeName = "varchar(255)" )]
    public string PasswordHash { get ; set; } = null!;

    [Column( TypeName = "varchar(255)" )]
    public string? TokenFacebook { get; set; }

    [Column( TypeName = "varchar(255)" )]
    public string? TokenTwitter { get; set; }

    public string? Description { get; set; }

    [ForeignKey("Image")]
    public Guid ImageId { get; set; }

    public uint FollowerCount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    //Relationships
    public virtual UserRole Role { get; } = null!;

    public virtual Image Image { get; } = null!;

    public virtual ICollection<CustomList> Lists { get; } = new List<CustomList>();

    public virtual ICollection<Subscription> Subscriptions { get; } = new List<Subscription>();

    public virtual ICollection<Group> Groups { get; } = new List<Group>();

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<Publication> Publications { get; } = new List<Publication>();

    public virtual ICollection<LikePublication> LikePublications { get; } = new List<LikePublication>();
    
    public virtual ICollection<LikeIngredient> LikeIngredients { get; } = new List<LikeIngredient>();
}
