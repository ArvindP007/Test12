using StudentWebAPI.Models;

namespace StudentWebAPI.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username,string password);
        Task<bool> UserExits(string username);
    }
}
