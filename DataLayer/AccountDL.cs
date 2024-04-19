using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AccountDL
    {
        List<Account> Users = new List<Account>();

        public AccountDL()
        {
            CreateData();
        }

        private void CreateData()
        {
            Account account = new Account { username = "danieljosesagun", password = "djsagun123" };

            Users.Add(account);
        }

        public Account GetAccount(string username, string password)
        {
            Account foundUser = new Account();

            foreach (var user in Users)
            {
                if (username == user.username && password == user.password)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}
