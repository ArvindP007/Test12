using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_2nd_Task.EFCore
{
    [Table("Usertable")]
    public class Usertable
    {
        [Key, Required]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public IList<UserCredentials> UserCredentials { get; set; }
    }
}
