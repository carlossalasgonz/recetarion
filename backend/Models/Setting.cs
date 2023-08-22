using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Recetarion.Models;

public class Setting {

    [Column( Order = 0, TypeName = "varchar(255)"), Key]
    public string Key { get; set; } = null!;

    [Column( TypeName = "varchar(255)")]
    public string Value { get; set; } = null!;

}