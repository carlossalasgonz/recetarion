
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Recetarion.Models;

public class Recipe {
    [Column(Order = 0), Key]
    public Guid Id { get; set; }

    [ForeignKey("Publication")]
    public Guid PublicationId { get; set; }

    [Column(TypeName = "varchar(255)")]
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    //Relationships
    public virtual Publication Publication { get; } = null!;
    public virtual ICollection<RecipeIngredient> IngredientsQuantitys { get; } = new List<RecipeIngredient>();
    public virtual ICollection<Ingredient> Ingredients { get; } = new List<Ingredient>();
    public virtual ICollection<Step> Steps { get; } = new List<Step>();
    public virtual ICollection<Critic> Critics { get; } = new List<Critic>();
    public virtual ICollection<CustomListRecipe> Lists { get; } = new List<CustomListRecipe>();
}