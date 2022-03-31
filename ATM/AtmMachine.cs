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
        public Account? Account { get; set; }
        public Bank bank = new();

        public bool Login(string? input)
        {
            PinValidator validator = new();
            AccountNumberLoggedIn = validator.ValidatePin(input).AccountNumber;
            Account = validator.ValidatePin(input);
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

        //public void ShowSaldo()
        //{

        //}


        public Account? Withdraw(string amount)
        {
            try
            {
                bool tryParseResult = int.TryParse(amount, out int input);
                if (tryParseResult)
                {
                    if (input % 100 == 0 && input >0)
                    {
                        Account.Saldo -=input;
                    }
                }
                else
                {
                    return null;
                };
            }
            catch (Exception)
            {
                Console.WriteLine("Hov. Noget gik galt");
                Console.WriteLine("Du er muligvis gået konkurs");
                return null;
            }
            return null;
        }


        public void Deposit(string amount)
        {

        }

    }
}