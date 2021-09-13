using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    interface ICustomer
    {
        int CustomerId { get;  }
        string Name { get; set; }
        DateTime DateOfBirth { get; set; }
        char Gender { get; set; }
        string City { get; set; }
        long MobileNumber { get; set; }
    }
}
