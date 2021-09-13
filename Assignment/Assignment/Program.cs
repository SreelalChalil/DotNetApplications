using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IMethod method = new Method();
           
                int choice = 0;
                do
                {
                    Console.WriteLine("\n BANKING INFORMATION OF CUSTOMERS : Enter Your Choice:  \n 1.Add New Customer details\n 2.Add New Account for customer\n 3.View by Account Type\n 4.Deposit Amount\n 5. Deactivate Account \n");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the Customer Name");
                            string custName = Console.ReadLine();
                            Console.WriteLine("Enter The Date of Birth");
                            DateTime dob = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter Your Gender (M/F)");
                            char gen = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Enter the City name:");
                            string cty = Console.ReadLine();
                            Console.WriteLine("Enter the Mobile Number:");
                            long mob = Convert.ToInt64(Console.ReadLine());
                        try {
                            ICustomer objcustomer = new Customer(custName, dob, gen, cty, mob);
                            int returnId = method.AddCustomer(objcustomer);
                            Console.WriteLine("Customer details Saved Successfuly!!!: " + returnId + "\n");
                        }
                        catch(Exception e) { Console.WriteLine("Error :" + e.Message + "Please Try Again");  }
                     break;

                        case 2:
                            Console.WriteLine("\nEnter the Customer ID");
                            int cusId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Select Account Type: \n 1.  Savings Account and \t 2.  Current Account");
                            int accType = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Amount to Deposit  (Minimum 500):");
                            decimal depAmount = Convert.ToDecimal(Console.ReadLine());
                            if(depAmount < 500)
                            {
                                Console.WriteLine("Warning!!! Amount Should be greater than 500 \n");
                                break;
                            }
                        try {
                            IAccount newAccount = new Account(cusId, accType, depAmount);
                            int return_Id = method.AddAccount(newAccount);
                            Console.WriteLine("\n Successfully Created an Account With Account ID:" + return_Id + "\n");
                            }
                        catch (Exception e) { Console.WriteLine("Error :" + e.Message + "Please Try Again"); }

                        break;

                        case 3:
                            Console.WriteLine("\n Select Account Type :>> \n 1. Savings and \t 2.  Current Account");
                            int acc_Type = Convert.ToInt32(Console.ReadLine());
                            List<IAccount> viewAccount = new List<IAccount>();
                            viewAccount = method.ViewByAccountType(acc_Type);
                            foreach(IAccount account in viewAccount)
                            {
                                Console.WriteLine("Customer Id : {0} \t Account ID : {1} \t Deposit: {2}", account.CustomerId, account.AccountId, account.DepositAmount);
                            }
                            break;

                        case 4:
                            Console.WriteLine("\n Enter The Customer ID:");
                            int cid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter The Account id");
                            int aid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter The Account Type \n 1. Savings Account \t 2. Current Account");
                            int act = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the  Amount to deposit");
                            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                            decimal newAmount = method.DepositAmount(aid, depositAmount);
                            Console.WriteLine("New Balance in account:" + newAmount);
                            break;

                        case 5:
                            Console.WriteLine("\n Enter the Customer ID:");
                            int cuid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Account ID:");
                            int acid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Account Type \n 1. Savings Account \t 2. Current Account");
                            int acty = Convert.ToInt32(Console.ReadLine());
                            int status = method.DeactivateAccount(acid);
                            if(status == 1)
                            {
                                Console.WriteLine("\n Account has been Successfully Deactivated \n");
                            }
                            else
                            {
                                Console.WriteLine("\n Cannot deactivate  the Account\n");
                            }

                            break;

                    case 0: break;
                        default:
                            Console.WriteLine("\n Invalid Choice");
                            break;
                    }

                } while (choice != 0);

            Console.ReadLine();  
        }
    }
}
