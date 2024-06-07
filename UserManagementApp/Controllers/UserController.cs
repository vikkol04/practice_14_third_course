using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserManagementApp.Models;

namespace UserManagementApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "Alica", Email = "alica@example.com" },
            new User { Id = 2, Name = "Kortana", Email = "kortana@example.com" }
        };

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Users;
        }

        [HttpPost]
        public ActionResult<User> AddUser(User user)
        {
            user.Id = Users.Count + 1;
            Users.Add(user);
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            var existingUser = Users.Find(u => u.Id == id);
            if (existingUser == null)
            {
                return NotFound();
            }

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = Users.Find(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            Users.Remove(user);
            return NoContent();
        }
    }
}
