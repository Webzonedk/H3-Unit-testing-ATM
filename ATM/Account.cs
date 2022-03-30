using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        public int PinCode { get; set; }

        public double Saldo { get; set; }

        public Account(int pinCode, double saldo)
        {
            
            PinCode = pinCode;
            Saldo = saldo;
        }

        //public Account()
        //{
        //}
    }
}
