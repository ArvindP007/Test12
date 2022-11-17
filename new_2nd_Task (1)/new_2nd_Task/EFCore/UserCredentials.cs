using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_2nd_Task.EFCore
{
    [Table("UserCredentials")]
    public class UserCredentials
    {
        public int UserId { get; set; }
        public Usertable Usertable { get; set; }
       [Key, Required]
        public int credentialId { get; set; }
        public CredentialsInfoTable? CredentialsInfoTable { get; set; }
       
    }
}
