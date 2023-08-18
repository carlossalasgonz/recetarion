using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Publication {

    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }

    //Relationships
    public virtual User User { get; } = null!;
    public virtual Critic? Critic { get; }
    public virtual Recipe? Recipe { get; }
    public virtual ICollection<LikePublication> Likes { get; } = new List<LikePublication>();
    public virtual ICollection<User> UsersLike { get; } = new List<User>();
    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();
    public virtual ICollection<Image> Images { get; } = new List<Image>(); 
}