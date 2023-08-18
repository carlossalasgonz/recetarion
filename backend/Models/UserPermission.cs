using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(UserRolesId), nameof(Action) )]
public class UserPermission {
    [Column(Order = 0), Key, ForeignKey("Role")]
    public Guid UserRolesId { get; private set; }
    
    [Column(Order = 1), Key]
    public string Action { get; set; } = null!;

    //Relationships
    public virtual UserRole Role { get; } = null!;
    public virtual ICollection<CustomList> Lists { get; } = new List<CustomList>();
    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();
    public virtual ICollection<LikePublication> LikePublications { get; } = new List<LikePublication>();
    public virtual ICollection<Publication> Publications { get; } = new List<Publication>();
    public virtual ICollection<Subscription> Subscriptions { get; } = new List<Subscription>();
    public virtual ICollection<Group> Groups { get; } = new List<Group>();
    public virtual ICollection<LikeIngredient> LikeIngredients { get; } = new List<LikeIngredient>();
    public virtual ICollection<Ingredient> Ingredients { get; } = new List<Ingredient>();
}