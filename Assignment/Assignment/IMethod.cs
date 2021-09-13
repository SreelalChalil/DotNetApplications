using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    interface IMethod
    {
        int AddCustomer(ICustomer obj);
        int AddAccount(IAccount acobj);
        List<IAccount> ViewByAccountType(int accountType);
        decimal DepositAmount(int accountID, decimal deposit);
        int DeactivateAccount(int accountid);
    }
}
