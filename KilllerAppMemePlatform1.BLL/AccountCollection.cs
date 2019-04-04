using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class AccountCollection
    {
        List<Account> accountList = new List<Account>();

        public void AddAccount(Account account)
        {
            accountList.Add(account);
        }
    }
}
