namespace KariyerAkademi.WebApi
{
    public interface IUserManager
    {
        User GetUserById(int userId);
        string CreateUser(User user);
        List<User> GetUsers();
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
