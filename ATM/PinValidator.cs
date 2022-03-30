using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM;

namespace ATM
{
    public class PinValidator
    {
        private readonly Bank _Accounts = new();

        /// <summary>
        /// Method to validate the pin code
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true or false</returns>
        public Account? ValidatePin(string? value)
        {
            try
            {
                bool tryParseResult = int.TryParse(value, out int input);
                if (tryParseResult)
                {
                    var result = _Accounts.Accounts.Where(x => (x.PinCode == input));

                    if (result != null)
                    {
                        foreach (Account account in result)//Needed as the result is an Ienumerable and can not be used directly
                        {
                            int pinCode = account.PinCode;
                            if (input == pinCode)
                            {
                                return account;
                            };
                        };
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
                return null;
            }
            return null;
        }
    }
}
