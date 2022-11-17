using BasicAPI.Model;

namespace BasicAPI.Data
{
    public interface ITechRepository
    {
        Task<int> Register(Teacher user, string password);
        Task<string> Login(string username, string password);
        Task<bool> UserExits(string username);
    }
}
