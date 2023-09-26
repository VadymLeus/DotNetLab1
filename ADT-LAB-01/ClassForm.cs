using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT_LAB_01
{
    internal class ClassForm
    {
        public class Account
        {
            public string CardNumber { get; set; }
            public string PIN { get; set; }
            public string OwnerName { get; set; }
            public decimal Balance { get; set; }
            public string PhoneNumber { get; set; }

            public Account(string cardNumber, string pin, string ownerName, decimal balance, string phoneNumber)
            {
                CardNumber = cardNumber;
                PIN = pin;
                OwnerName = ownerName;
                Balance = balance;
                PhoneNumber = phoneNumber;
            }
        }
    }
}
