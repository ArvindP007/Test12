using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_2nd_Task.EFCore
{
    [Table("CredentialsInfo")]
    public class CredentialsInfoTable
    {
        
        // public int Id { get; set; }
      
        public int userId { get; set; }
        [Key, Required]
        public int credentialId { get; set; }
        public string credentialName { get; set; }
        public string credentialValue { get; set; }
        public IList<UserCredentials> UserCredentials { get; set; }
    }
}
