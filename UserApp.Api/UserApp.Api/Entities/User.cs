using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserApp.Api.Controllers;

namespace UserApp.Api.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime LastLoginDate { get; set; }
    }
}
