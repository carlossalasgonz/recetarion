using Microsoft.AspNetCore.Mvc;
using Recetarion.Data;
using Recetarion.Models;

namespace Recetarion.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase {

    private readonly RecetarionDbContext dbContext;

    public UserController(RecetarionDbContext dbContext) {
        this.dbContext = dbContext;
    }

    [HttpGet(Name = "user.index")]
    public IActionResult Get() {
        return Ok( dbContext.Users.ToList() );
        // return Enumerable.Range(1, 5).Select(index => new User{
        //     firstName = new string[] {"Pepe", "Eduardo", "Rene", "Ramiro", "Juan"}[Random.Shared.Next(index)],
        //     lastName = new string[] {"Gonzalez", "Rodriguez", "Blanco", "Ramirez", "Alfaro"}[Random.Shared.Next(index)],
        //     imageId = (uint)Random.Shared.Next()
        // })
        // .ToArray();
    }
}
