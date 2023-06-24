namespace KariyerAkademi.WebApi
{
    public class UserManager : IUserManager
    {
        List<User> users = new List<User>();

        public User GetUserById(int userId) 
        {
            return users.FirstOrDefault(x=> x.Id == userId);
        }

        public string CreateUser(User user) 
        {
            try
            {
                users.Add(user);
                return "Başarılı";
            }
            catch (Exception ex)
            {

                return "Aşağıdaki hatadan dolayı başarısız : " +ex.Message;
            }
        } 

        public List<User> GetUsers() 
        {
            return users;
        }

        public void UpdateUser(User user) 
        {
        }
        public void DeleteUser(int userId) 
        {
            users.Remove(GetUserById(userId));
        }
    }
}
