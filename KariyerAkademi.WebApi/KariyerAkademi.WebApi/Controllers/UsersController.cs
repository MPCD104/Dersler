using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KariyerAkademi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserManager userManager;
        public UsersController(IUserManager userManager)
        {
             this.userManager = userManager;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public List<User> Get()
        {
            return userManager.GetUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return userManager.GetUserById(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public string Post([FromBody] User user)
        {
             return userManager.CreateUser(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userManager.DeleteUser(id); 
        }
    }
}
