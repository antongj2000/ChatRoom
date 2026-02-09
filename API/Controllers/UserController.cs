using API.DBconnention;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(RoomDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<RoomUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoomUser>> GetUserById(string id)
        {
            var user = await context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            if(user==null) return NotFound();
            return user;
        }  

    }     
}
