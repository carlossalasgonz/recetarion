using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Unit { 
    [Column(Order = 0), Key]
    public Guid Id { get; private set; }

    [Column(TypeName = "varchar(32)")]
    public string Title { get; set; } = null!;
}