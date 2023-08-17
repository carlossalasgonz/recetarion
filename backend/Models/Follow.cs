using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(FollowerId), nameof(FolloweeId) )]
public class Follow {

    //Original Atributes
    [Column(Order = 0), Key, ForeignKey("Follower")]
    public Guid FollowerId { get; set; }
    [Column(Order = 1), Key, ForeignKey("Followee")]
    public Guid FolloweeId { get; set; }

    //Relations
    public virtual User Follower { get; set; } = null!;
    public virtual User Followee { get; set; } = null!;

}