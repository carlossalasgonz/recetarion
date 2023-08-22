using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recetarion.Models;

public class Ingredient {

    [Column(Order = 0), Key]
    public Guid Id { get; set;}

    [Column(TypeName = "varchar(32)")]
    public string Name { get; set; } = null!;

    //Calories per gram
    public int Calories { get; set; }

    // gram / liter      (We use this measures since they are our defaults)
    public float Density { get; set; }

    [ForeignKey("Image")]
    public Guid ImageId { get; set; }

    //Relationships
    public virtual Image Image { get; } = null!;
    public virtual ICollection<LikeIngredient> Likes { get; } = new List<LikeIngredient>();
    public virtual ICollection<User> Users { get; } = new List<User>();
    public virtual ICollection<RecipeIngredient> RecipePivot { get; } = new List<RecipeIngredient>();
    public virtual ICollection<Recipe> Recipes { get; } = new List<Recipe>();
}