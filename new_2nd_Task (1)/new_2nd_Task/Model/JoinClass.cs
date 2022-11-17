using new_2nd_Task.EFCore;

namespace final_code.Model
{
    public class JoinClass
    {
        public CredentialsInfoTable GetCredentialsInfoTable { get; set; }
        public Usertable GetUsertable { get; set; }
        public UserCredentials GetUserCredentials { get; set; }
    }
}
