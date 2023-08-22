using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Unit { 
    [Column(Order = 0), Key]
    public Guid Id { get; set; }

    [Column(TypeName = "varchar(32)")]
    public string Title { get; set; } = null!;

    [Column( TypeName = "varchar(32)")]
    public string Abbreviation { get; set; } = null!;

    [Column( TypeName = "varchar(32)")]
    public string Type { get; set; } = null!;

    public bool Default { get; set; }

    public float Equivalence { get; set; }
}