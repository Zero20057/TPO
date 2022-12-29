using Tests.model;
using Tests.resorces;

namespace Tests.service
{
    public class UserCreator
    {
        public static string Username = UserFirst.Username;
        public static string Password = UserFirst.Password;
        public static User user = new User(Username, Password);
    }
}
