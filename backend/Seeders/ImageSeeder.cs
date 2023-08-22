using Microsoft.EntityFrameworkCore;
using Recetarion.Models;

namespace Recetarion.Seeder;

public class ImageSeeder {
    public List<Image> Seed( ModelBuilder modelBuilder ){

        List<Image> Image = new List<Image>() {
            new Image(){
                Id      = Guid.NewGuid(),  
                Name    = Environment.GetEnvironmentVariable( "Seeder:Image:Name" )!,
                Type    = Environment.GetEnvironmentVariable( "Seeder:Image:Name" )!.Split(".").Last(),
            }
        };
        
        modelBuilder.Entity<Image>().HasData( Image );

        return Image;
    }
}