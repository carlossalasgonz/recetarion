using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Recetarion.Data;
using Recetarion.Models;

namespace Recetarion.Seeder;

public class UserSeeder { 

    public List<User> Seed( ModelBuilder Builder, List<UserRole> Roles, List<Image> Images ){

        var Passwords = new List<KeyValuePair<byte[], byte[]>>(); 

        using( var crypter = new HMACSHA512()) {
            Passwords.Add( new KeyValuePair<byte[], byte[]>(
                crypter.Key,
                crypter.ComputeHash(System.Text.Encoding.UTF8.GetBytes( Environment.GetEnvironmentVariable("Seeder:Admin:Password")! ))
            ));
        }

        List<User> Users = new List<User>() {
            new User() {
                Id              = Guid.NewGuid(),  
                UserRoleId      = Roles.Find( Role => Role.Title == "SuperAdmin" )!.Id,
                Username        = Environment.GetEnvironmentVariable("Seeder:Admin:Username")!,
                Email           = Environment.GetEnvironmentVariable("Seeder:Admin:Email")!,
                PasswordSalt    = System.Text.Encoding.UTF8.GetString(Passwords[0].Key),
                PasswordHash    = System.Text.Encoding.UTF8.GetString(Passwords[0].Value),
                TokenFacebook   = null,
                TokenTwitter    = null,
                Description     = string.Empty,
                ImageId         = Images[0].Id,
                FollowerCount   = 0,
                CreatedAt       = DateTime.Now,
                UpdatedAt       = null,
                DeletedAt       = null,
            }
        };

        Builder.Entity<User>().HasData( Users );

        return Users;
    }

}