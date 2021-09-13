using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartBO
{
    public class CartBO
    {
        int orderID;
        string itemName;
        int quantityNeeded;
        decimal totalPrice;
        string customerName;
        long customerContact;
        string customerEmail;
        DateTime orderDate;

        public CartBO(string itemName, int quantityNeeded, decimal totalPrice, string customerName, long customerContact, string customerEmail, DateTime orderDate)
        {
            this.itemName = itemName;
            this.quantityNeeded = quantityNeeded;
            this.totalPrice = totalPrice;
            this.customerName = customerName;
            this.customerContact = customerContact;
            this.customerEmail = customerEmail;
            this.orderDate = orderDate;
        }

        public int OrderID { get => orderID; set => orderID = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int QuantityNeeded { get => quantityNeeded; set => quantityNeeded = value; }
        public decimal TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public long CustomerContact { get => customerContact; set => customerContact = value; }
        public string CustomerEmail { get => customerEmail; set => customerEmail = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
    }
}
