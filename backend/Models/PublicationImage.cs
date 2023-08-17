using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

[PrimaryKey(nameof(PublicationId), nameof(ImageId))]
public class PublicationImage {

    [Column(Order = 0), Key, ForeignKey("Publication") ]
    public Guid PublicationId { get; set; }

    [Column(Order = 1), Key, ForeignKey("Image")]
    public Guid ImageId { get; set; }

    public uint Order { get; set; }

    //Relationships
    public virtual Publication Publication { get; } = null!;
    public virtual Image Image { get; } = null!;
}