using Bigbang.Models;
using Microsoft.EntityFrameworkCore;

namespace Bigbang.Repository.LogIns
{
    public class LogIn_Services : ILogIn_Services
    {
        public BigbangDbContext _bigbangDbcontext;
        public LogIn_Services(BigbangDbContext bigbangDbContext)
        {
            _bigbangDbcontext = bigbangDbContext;
        }
        public async Task<IEnumerable<LogIn>> GetLogIns()
        {
            return await _bigbangDbcontext.Logins.ToListAsync();
        }
        public async Task<LogIn>? GetLogIn(int id)
        {
            var hot = await _bigbangDbcontext.Logins.FindAsync(id);
            return hot;
        }
        public async Task<LogIn> PutLogIn(int id, LogIn logIn)
        {
            var item = await _bigbangDbcontext.Logins.FindAsync(id);

            item.UserName = logIn.UserName;
            item.Email = logIn.Email;
            item.Password = logIn.Password;
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return logIn;

        }
        public async Task<List<LogIn>> PostLogIn(LogIn logIn)
        {
            await _bigbangDbcontext.Logins.AddAsync(logIn);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return await _bigbangDbcontext.Logins.ToListAsync();


        }
        public async Task<LogIn>? DeleteLogIn(int id)
        {
            var roo = await _bigbangDbcontext.Logins.FindAsync(id);
            _bigbangDbcontext.Logins.Remove(roo);
            try
            {
                await _bigbangDbcontext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return roo;

        }
    }
}
