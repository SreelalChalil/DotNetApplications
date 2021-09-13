using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Account:IAccount
    {
        static int incrementID = 1000;
        int accountId;
        int customerId;
        //1=savings account 2= current account
        int accountType;
        decimal depositAmount;
        DateTime accountStartDate = DateTime.Now;
        string accountStatus = "active";

       

        public Account( int customerId, int accountType, decimal depositAmount)
            {
            accountId = incrementID++;
            CustomerId = customerId;
            AccountType = accountType;
            DepositAmount = depositAmount;
            AccountStatus = accountStatus;
            }

        public int AccountId
            {
            get { return accountId; }
            set { accountId = value; }
            }

        public int CustomerId
            {
            get { return customerId; }
            set { customerId = value; }
           }

        public int AccountType
           {
            get { return accountType; }
            set { accountType = value; }
           }

        public decimal DepositAmount
           {
            get { return depositAmount; }
            set { depositAmount = value; }
           }

         public string AccountStatus
           {
            get { return accountStatus; }
            set { accountStatus = value; }
           }

        
        }
}
