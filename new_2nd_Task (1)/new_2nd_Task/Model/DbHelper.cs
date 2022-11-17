using Credentials_Module.EFCore;
using new_2nd_Task.EFCore;

namespace new_2nd_Task.Model
{
    public class DbHelper
    {
        private EF_DataContext _context;
        public DbHelper(EF_DataContext context)
        {
            _context = context;
        }
        public void Credentials(CredInfoModel credInfoModel)
        {
            CredentialsInfoTable credentialsInfoTable = new CredentialsInfoTable();
            if (credInfoModel.UserId > 0)
            {
              //  credentialsInfoTable.Id = credInfoModel.Id;
                 credentialsInfoTable.userId = credInfoModel.UserId;
                credentialsInfoTable.credentialId = credInfoModel.credentialId;
                credentialsInfoTable.credentialName = credInfoModel.credentialName;
                credentialsInfoTable.credentialValue = credInfoModel.credentialValue;

                _context.credentialsInfos.Add(credentialsInfoTable);

                _context.SaveChanges();
            }
        }
        public void UserCredentials(UsertableModel usertableModel)
        {
            Usertable usertable = new Usertable();
            if (usertableModel.UserId > 0)
            {
                usertable.UserId = usertableModel.UserId;
                usertable.UserName = usertableModel.UserName;
                usertable.Password = usertableModel.Password;
                _context.usertables.Add(usertable);
                _context.SaveChanges();
            }
        }
        public void deleteCredInfo(int userId)
        {
            var cred = _context.credentialsInfos.Where(d => d.userId.Equals(userId)).FirstOrDefault();
            if (cred != null)
            {
                _context.credentialsInfos.Remove(cred);
                _context.SaveChanges();
            }
        }

        public List<CredInfoModel> GetuserCred(int userId)
        {
            CredInfoModel credInfoModel = new CredInfoModel();
            List<CredInfoModel> response = new List<CredInfoModel>();
            var dataList = _context.credentialsInfos.Where(d => d.credentialId.Equals(userId)).ToList(); ;
            dataList.ForEach(row => response.Add(new CredInfoModel()
            {
                //Id = row.Id,
                 UserId = row.userId,
                credentialId = row.credentialId,
                credentialName = row.credentialName,
                credentialValue = row.credentialValue,


            })); ;
            return response;
        }


        public List<UserCredentialsModel> GetUsercred1(int UserId)
        {
            List<UserCredentialsModel> response = new List<UserCredentialsModel>();
            var dataList = _context.userCredentials.Where(d => d.UserId.Equals(UserId)).ToList(); ;
            dataList.ForEach(row => response.Add(new UserCredentialsModel()
            {
                //Id = row.Id,
                UserId = row.UserId,
                CredentialId = row.credentialId,
               // UserName = row.UserName,
               // Password = row.Password,

            })); ;

            return response;
        }

        public List<UserCredentialsModel> GetSharedUserCredential(int Userid)
        {
            List<UserCredentialsModel> response = new List<UserCredentialsModel>();
            var dataList = _context.userCredentials.Where(d => d.UserId.Equals(Userid)).ToList(); ;
            dataList.ForEach(row => response.Add(new UserCredentialsModel()
            {
               
                UserId = row.UserId,
                CredentialId = row.credentialId,
               

            })); ;
            return response;
        }


       /* public IEnumerable<CredentialsInfoTable> GetUsercred1()
        {
            var list=(from p in _context.credentialsInfos
                join pm in _context.credentialsInfos on p.credentialId equals pm.credentialId

                join ud in_context.usertables on p.userID equals ud.userId
                select new UserCredentials()
                {
                    credentialId=p.credentialId,
                    UserId=ud.UserId,
                }).ToList();*/

        }
    }



    
