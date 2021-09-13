using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Customer:ICustomer
    {
        static int incrementId=5000;
        int customerId;
        string name;
        DateTime dateOfBirth;
        char gender;
        string city;
        long mobileNumber;

        public Customer(string name, DateTime dateOfBirth, char gender, string city, long mobileNumber)
        {
            customerId= incrementId++;
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            City = city;
            MobileNumber = mobileNumber;
        }

        public int CustomerId
        {
            get { return customerId; }
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public long MobileNumber
        {
            get { return mobileNumber; }
            set {
                    if (value.ToString().Length < 10)
                        throw new Exception("Invalid mobile number");
                     else mobileNumber = value;
                 }
        }
    }

}
