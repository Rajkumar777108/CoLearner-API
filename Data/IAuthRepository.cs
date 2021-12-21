using System.Threading.Tasks;
using CoLearner.API.Model;

namespace CoLearner.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register (User user, string password);
         Task<User> Login (string userName, string password);
         Task<bool> UserExist(string userName);
    }
}