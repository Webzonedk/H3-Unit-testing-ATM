using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        public string AccountName { get; set; }

        public string Owner { get; set; }

        public long CardNumber { get; set; }

        public long AccountNumber { get; set; }

        public int PinCode { get; set; }

        public double Saldo { get; set; }

        public Account(string accountName, string owner,long cardNumber, long accountNumber, int pinCode, double saldo)
        {
            AccountName = accountName;
            Owner = owner;
            CardNumber = cardNumber;
            AccountNumber = accountNumber;
            PinCode = pinCode;
            Saldo = saldo;
        }
    }
}
