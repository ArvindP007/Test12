using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public class DefaultPasswordValidator: IDefaultPasswordValidator
    {
        public bool Validate(string password)
        {
            if (password.Length < 8) return false;

            if (!password.Any(x => !char.IsUpper(x))) return false;

            if (!password.Any(x => !char.IsLower(x))) return false;

            if (!password.Any(x => !char.IsNumber(x))) return false;

            return true;
        }
    }
}
