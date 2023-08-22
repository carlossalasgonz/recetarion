using Microsoft.EntityFrameworkCore;
using Recetarion.Models;
using Recetarion.Seeder;

namespace Recetarion.Data;

public class RecetarionDbContext : DbContext{
    public RecetarionDbContext(DbContextOptions options) : base(options){}
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<Critic> Critics { get; set; } = null!;
    public DbSet<CustomList> CustomLists { get; set; } = null!;
    public DbSet<CustomListRecipe> CustomListRecipes { get; set; } = null!;
    public DbSet<Follow> Follows { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;
    public DbSet<GroupPermission> GroupPermissions { get; set; } = null!;
    public DbSet<GroupRole> GroupRoles { get; set; } = null!;
    public DbSet<Image> Images { get; set; } = null!;
    public DbSet<Ingredient> Ingredients { get; set; } = null!;
    public DbSet<LikeIngredient> LikeIngredients { get; set; } = null!;
    public DbSet<LikePublication> LikePublications { get; set; } = null!;
    public DbSet<Publication> Publications { get; set; } = null!;
    public DbSet<PublicationImage> PublicationImages { get; set; } = null!;
    public DbSet<Recipe> Recipes { get; set; } = null!;
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; } = null!;
    public DbSet<Step> Steps { get; set; } = null!;
    public DbSet<Subscription> Subscriptions { get; set; } = null!;
    public DbSet<Unit> Units { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserPermission> UserPermissions { get; set; } = null!;
    public DbSet<UserRole> UserRoles { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        new MasterSeeder().Seed( modelBuilder, this );
    }
}