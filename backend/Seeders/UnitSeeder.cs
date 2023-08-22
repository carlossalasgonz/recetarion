using Microsoft.EntityFrameworkCore;
using Recetarion.Models;

namespace Recetarion.Seeder;

public class UnitSeeder {
    public List<Unit> Seed( ModelBuilder modelBuilder ){

        List<Unit> units = new List<Unit>() {
            new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Grams",
                Abbreviation    = "g",
                Type            = "Mass",
                Default         = true,
                Equivalence     = 1
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Kilogram",
                Abbreviation    = "kg",
                Type            = "Mass",
                Default         = false,
                Equivalence     = 0.001f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Milligram",
                Abbreviation    = "mg",
                Type            = "Mass",
                Default         = false,
                Equivalence     = 1000f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Ounce",
                Abbreviation    = "oz",
                Type            = "Mass",
                Default         = false,
                Equivalence     = 0.035274f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Pound",
                Abbreviation    = "lb",
                Type            = "Mass",
                Default         = false,
                Equivalence     = 0.035274f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Stone",
                Abbreviation    = "st",
                Type            = "Mass",
                Default         = false,
                Equivalence     = 0.035274f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Liters",
                Abbreviation    = "l",
                Type            = "Volume",
                Default         = true,
                Equivalence     = 1
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Milliliters",
                Abbreviation    = "ml",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 1000f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Tablespoon",
                Abbreviation    = "tbsp",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 67.62805f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Teaspoon",
                Abbreviation    = "tsp",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 202.8841f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Fluid ounce",
                Abbreviation    = "fl. oz",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 33.81402f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Cup",
                Abbreviation    = "c",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 4.226753f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Quart",
                Abbreviation    = "qt",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 1.056688f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Pint",
                Abbreviation    = "pt",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 2.113376f
            }, new Unit() {
                Id              = Guid.NewGuid(),  
                Title           = "Gallon",
                Abbreviation    = "gal",
                Type            = "Volume",
                Default         = false,
                Equivalence     = 0.264172f
            }
        };

        modelBuilder.Entity<Unit>().HasData( units );

        return units;
    }
}