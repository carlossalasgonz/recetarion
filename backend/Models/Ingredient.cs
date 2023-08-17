using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Ingredient {

    [Column(Order = 0), Key]
    public Guid Id { get; private set;}

    [Column(TypeName = "varchar(32)")]
    public string Name { get; set; } = null!;

    //Calories per gram
    public int Calories { get; set; }

    [ForeignKey("Image")]
    public Guid ImageId { get; set; }

    //Relationships
    public virtual Image Image { get; } = null!;
}