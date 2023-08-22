using Microsoft.EntityFrameworkCore;
using Recetarion.Data;
using Recetarion.Models;

namespace Recetarion.Seeder;

public class IngredientSeeder {
    public List<Ingredient> Seed( ModelBuilder modelBuilder, List<Image> Image ){

        Guid DefaultImageId = Image[0].Id;

        List<Ingredient> Ingredients = new List<Ingredient>() {

            new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Almond Meal",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Almonds",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Amaranth",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Apples",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Apricots",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Avocados",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Bananas",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Barley",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Beef",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Beef Chuck",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Beef Ribs",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Beef Tenderloin",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Brisket",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Brown Rice",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Buckwheat",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Bulgur",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Cheese",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Cherries",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Chia Seeds",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Chicken",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Chicken Breasts",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Chicken Legs",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Chicken Thighs",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Chicken Wings",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Chocolate",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Coconut",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Corn Flour",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Cornish Hens",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Cornmeal",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Duck",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Fish",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Flax Seeds",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Goat",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Ground Beef",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Ground Chicken",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Ground Pork",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Ground Turkey",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Lamb",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Mangos",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Millet",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Mushroom",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Nectarines",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Oat Flour",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Oats",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Peaches",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Peanuts",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Pears",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Pineapples",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Plums",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Pomegranates",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Pork",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Pork Ribs",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Pork Shoulder",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Pork Tenderloin",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Prime Rib",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Quinoa",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Sausage",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Seafood",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Shellfish",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Sirloin",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Spelt",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Steak",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Tapioca Flour",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Turkey",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Veal",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Venison",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "White Rice Flour",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Wild Game",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }, new Ingredient(){
                Id          = Guid.NewGuid(),  
                Name        = "Wild Rice",
                Calories    = 0,
                ImageId     = DefaultImageId,
                Density     = 1,
            }
        };

        modelBuilder.Entity<Ingredient>().HasData( Ingredients );

        return Ingredients;
    }
}