using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class AtmMachine
    {
        public long? AccountNumberLoggedIn { get; set; }
        public Bank bank = new();

        public bool Login(string? input)
        {
            PinValidator validator = new();
            AccountNumberLoggedIn = validator.ValidatePin(input).AccountNumber;
            return true;
        }

        public Account? GetAccount(long? AccountNumberLoggedIn)
        {
            try
            {
                if (AccountNumberLoggedIn != null)
                {
                    var result = bank.Accounts.Where(x => (x.AccountNumber == AccountNumberLoggedIn));
                    foreach (var item in result)
                    {
                        return item;
                    }
                }
                else
                {
                    return null;
                };
            }
            catch (Exception)
            {
                Console.WriteLine("Hov. Noget gik galt med valideringen af din pinkode");
                Console.WriteLine("Indtast venligst den korekte pinkode.");
            }
            return null;
        }

        public void ShowSaldo()
        {

        }

        public void Deposit(string amount)
        {

        }

        public void Withdraw(string amount)
        {
        }

    }
}