using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AccountBL
    {
        public bool VerifyAccount(string username, string password)
        {
            AccountDL accountDL = new AccountDL();
            var result = accountDL.GetAccount(username, password);

            return result.username != null ? true : false;
        }
    }
}
