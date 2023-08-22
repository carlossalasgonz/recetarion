using Microsoft.EntityFrameworkCore;
using Recetarion.Models;

namespace Recetarion.Seeder;

public class SettingSeeder {
    public void Seed( ModelBuilder modelBuilder ) {
        modelBuilder.Entity<Setting>().HasData(
            new Setting() {
                Key     = "Auth.Password.MinLength",
                Value   = "8"
            }, new Setting() {
                Key     = "Auth.User.MinLength",
                Value   = "8"
            }
        );
    }
}