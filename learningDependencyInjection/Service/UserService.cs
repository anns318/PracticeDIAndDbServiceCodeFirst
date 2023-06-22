using learningDependencyInjection.Data;
using learningDependencyInjection.Models;

namespace learningDependencyInjection.Service
{
    public class UserService : IUserService
    {
        

        private readonly DataContext _dataContext;
        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public User addNewUser(User user)
        {
            _dataContext.Add(user);
            _dataContext.SaveChanges();
            return user;
        }

        public User? getUser(int id)
        {
            return _dataContext.Users.ToList().Find(x => x.Id == id);
        }

        public List<User> getAllUser()
        {
            return _dataContext.Users.ToList();
        }

        public User? updateUser(int id, User User)
        {
            var user = _dataContext.Users.ToList().Find(x => x.Id == id);
            if (user == null) return null;
            user.UserName = User.UserName;
            user.Password = User.Password;
            _dataContext.SaveChanges();
            return user;
        }

        public User? removeUser(int id)
        {
            var user = _dataContext.Users.ToList().Find(x => x.Id == id);
            if (user == null) { return null; }

            _dataContext.Users.Remove(user);
            _dataContext.SaveChanges();

            return user;


        }
    }
}
