using System.ComponentModel.DataAnnotations;

namespace Gml.Launcher.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
