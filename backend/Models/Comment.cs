using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Comment {
    [Column(Order = 0), Key]
    public Guid Id { get; private set; }
    
    [ForeignKey("User")]
    public Guid UserId { get; set; }

    [ForeignKey("Publication")]
    public Guid PublicationId { get; set; }

    public string Description { get; set; } = null!;

    [ForeignKey("Image")]
    public Guid? ImageId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    //Relationships
    public virtual User User { get; } = null!;
    public virtual Publication Publication { get; } = null!;
    public virtual Image? Image { get; }
}