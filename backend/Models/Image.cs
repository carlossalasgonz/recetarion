using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Image {

    [Column(Order = 0), Key]
    public Guid Id { get; private set; }
    
    [Column(TypeName = "varchar(255)")]
    public string Name { get; set;} = null!;

    [Column(TypeName = "varchar(255)")]
    public string Type { get; set; } = null!;
}