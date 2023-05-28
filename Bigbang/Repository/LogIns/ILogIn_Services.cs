using Bigbang.Models;

namespace Bigbang.Repository.LogIns
{
    public interface ILogIn_Services
    {
        Task<IEnumerable<LogIn>> GetLogIns();
        Task<LogIn>? GetLogIn(int id);
        Task<LogIn> PutLogIn(int id, LogIn logIn);
        Task<List<LogIn>> PostLogIn(LogIn logIn);
        Task<LogIn>? DeleteLogIn(int id);
    }
}
