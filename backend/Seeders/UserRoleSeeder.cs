using Microsoft.EntityFrameworkCore;
using Recetarion.Models;

namespace Recetarion.Seeder;

public class UserRoleSeeder {
    public List<UserRole> Seed( ModelBuilder modelBuilder ) {

        List<UserRole> newRoles = new List<UserRole>() {
            new UserRole() {
                Id      = Guid.NewGuid(),  
                Title   = "SuperAdmin"
            }, new UserRole() {
                Id      = Guid.NewGuid(),  
                Title   = "Admin"
            }, new UserRole() {
                Id      = Guid.NewGuid(),  
                Title   = "Client"
            }
        };

        modelBuilder.Entity<UserRole>().HasData( newRoles );

        return newRoles;
    }
}