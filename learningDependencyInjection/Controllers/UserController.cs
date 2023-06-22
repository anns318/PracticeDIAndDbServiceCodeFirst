using learningDependencyInjection.Models;
using learningDependencyInjection.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace learningDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService=userService;
        }
        [HttpGet]
        public async Task<ActionResult<List<User>>> getAllUser()
        {
            List<User> users = _userService.getAllUser();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> getUser(int id)
        {
            
            return Ok(_userService.getUser(id));
        }
        [HttpPost]
        public async Task<ActionResult<User>> newUser(User user)
        {
            _userService.addNewUser(user);
            return Ok(user);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> updateUser(int id,User request)
        {
            var user = _userService.updateUser(id,request);
            if (user == null) return NotFound();

            return Ok(user);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> deleteUser(int id)
        {
            var user = _userService.removeUser(id);
            if (user == null) return NotFound();

            return Ok();
        }
    }
}
