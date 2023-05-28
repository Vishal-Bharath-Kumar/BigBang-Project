using System.ComponentModel.DataAnnotations;

namespace Bigbang.Models
{
    public class LogIn
    {
        [Key]
        public int userId { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; } 

        public string? Password { get; set; }
    }
}
