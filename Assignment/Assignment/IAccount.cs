using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    interface IAccount
    {
        int AccountId { get; set; }
        int CustomerId { get; set; }
        int AccountType { get; set; }
        decimal DepositAmount { get; set; }
        string AccountStatus { get; set; }
        
        
    }
}
