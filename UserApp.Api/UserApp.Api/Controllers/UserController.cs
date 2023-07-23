using Microsoft.AspNetCore.Mvc;
using UserApp.Api.Context;
using UserApp.Api.Entities;

namespace UserApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserAppContext userAppContext;
        public UserController(UserAppContext userAppContext)
        {
            this.userAppContext = userAppContext;
        }

        [HttpGet("all")]
        public List<User> Get() 
        {
            return userAppContext.Users.ToList();
        }

        [HttpPost]
        public void Post([FromBody] User user) 
        {
            userAppContext.Users.Add(user);
            userAppContext.SaveChanges();
        }
        [HttpGet("{id}")]
        public User GetById([FromRoute]int id)
        {
            return userAppContext.Users.Find(id);
        }
        [HttpGet]
        public User GetByIdd(int id)
        {
            return userAppContext.Users.Find(id);
        }
        [HttpGet("GetByUserName/{userName}")]
        public User GetByUserName([FromRoute] string userName)
        {
            return userAppContext.Users.FirstOrDefault(x => x.UserName == userName);
        }
        [HttpGet("LoginUser")]
        public bool LoginUser (string userName , string password)
        {
            return userAppContext.Users.Any(x => x.UserName == userName && x.Password == password);
        }

    }
}