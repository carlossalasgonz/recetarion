using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Group {

    [Column(Order = 0), Key]
    public Guid Id { get; private set;}

    [Column(TypeName = "varchar(255)")]
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    [ForeignKey("Image")]
    public Guid ImageId { get; set; }

    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }

    public DateTime DeletedAt { get; private set; }

    //Relationships
    public virtual Image Image { get; } = null!;
    public virtual ICollection<GroupRole> Roles { get; } = new List<GroupRole>();
    public virtual ICollection<Subscription> Subscriptions { get; } = new List<Subscription>();
    public virtual ICollection<User> Users { get; } = new List<User>();
}