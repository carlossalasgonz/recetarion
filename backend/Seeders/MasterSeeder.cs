using Microsoft.EntityFrameworkCore;
using Recetarion.Data;
using Recetarion.Models;

namespace Recetarion.Seeder;

public class MasterSeeder {

    public void Seed( ModelBuilder modelBuilder, RecetarionDbContext DB){
        var Roles = new UserRoleSeeder().Seed( modelBuilder );
        var Image = new ImageSeeder().Seed( modelBuilder );
        var Unit = new UnitSeeder().Seed( modelBuilder );
        var Ingredient = new IngredientSeeder().Seed( modelBuilder, Image);
        var User = new UserSeeder().Seed( modelBuilder, Roles, Image );
    }

}