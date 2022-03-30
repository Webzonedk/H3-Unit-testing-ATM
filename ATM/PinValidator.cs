using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM;

namespace ATM
{
    public static class PinValidator
    {
        private static List<Account> _accounts = Bank.GetAccounts();
        /// <summary>
        /// Method to validate the pin code
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cardPin"></param>
        /// <returns>true or false</returns>
        public static bool ValidatePin(string value)
        {
            try
            {
                bool tryParseResult = int.TryParse(value, out int input);
                if (tryParseResult)
                {
                    var result = _accounts.Where(x => (x.PinCode == input));

                    if (result != null)
                    {
                        foreach (Account account in result)//Needed as the result is an Ienumerable and can not be used directly
                        {
                            int pinCode = account.PinCode;
                            if (input == pinCode)
                            {
                                return true;
                            };
                        };
                    }
                    else
                    {
                        return false;
                    };
                }
                else
                {
                    return false;
                };
            }
            catch (Exception)
            {
                Console.WriteLine("Hov. Noget gik galt med valideringen af din pinkode");
                Console.WriteLine("Indtast venligst igen at indtaste den korekte pinkode.");
                return false;
            }
            return false;
        }
    }
}
