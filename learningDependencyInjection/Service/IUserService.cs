using learningDependencyInjection.Models;

namespace learningDependencyInjection.Service
{
    public interface IUserService
    {
        List<User> getAllUser();
        User? getUser(int id);
        User addNewUser(User user);
        User? updateUser(int id, User user);
        User? removeUser(int id);
    }
}
