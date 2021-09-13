using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Method:IMethod
    {
       
        List<ICustomer> ICustomerlist = new List<ICustomer>();
        public int AddCustomer(ICustomer obj)
        {
            ICustomerlist.Add(obj);
            return (obj.CustomerId);

        }
        List<IAccount> IAccountlist = new List<IAccount>();
        public int AddAccount(IAccount obj)
        {
            int customerId = obj.CustomerId;
            int accountType = obj.AccountType;
            bool hasCustomer = ICustomerlist.Any(x => x.CustomerId == customerId);
            if (hasCustomer)
            {
                switch (accountType)
                {
                    case 1:
                        if (IAccountlist.Any(x => x.AccountType == 1 && x.CustomerId == customerId))
                        {
                            throw new Exception("Customer Already have Savings Accounts. ");
                        }
                        break;
                    case 2:
                        if (IAccountlist.Any(x => x.AccountType == 2 && x.CustomerId == customerId))
                        {
                            throw new Exception("Customer Already have Current Accounts. ");
                        }
                        break;
                    default: throw new Exception("Invalid Account Type. ");
                }
                
                    IAccountlist.Add(obj);
                    return (obj.AccountId); 
            }
            else
            {
                throw new Exception("Customer Not Found");
            }

        }
        public List<IAccount> ViewByAccountType(int accountType)
        {
            //1=savings account 2= current account
            List<IAccount> myNewList = new List<IAccount>();
            foreach(IAccount account in IAccountlist)
            {
                if(account.AccountType == accountType)
                {
                    myNewList.Add(account);
                }
            }
            return myNewList;
        }

        public decimal DepositAmount(int accountID, decimal deposit)
        {
            IAccount account = IAccountlist.Find(x => x.AccountId == accountID);
            account.DepositAmount = account.DepositAmount + deposit;
            return account.DepositAmount;
        }

        public int DeactivateAccount(int accountId)
        {
            IAccount account = IAccountlist.Find(x => x.AccountId == accountId);
            account.AccountStatus = "Inactive";
            if (account.AccountStatus == "Inactive") { return 1; }
            else return 0;
        }
            
    }
}
