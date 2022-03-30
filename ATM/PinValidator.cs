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
        /// <summary>
        /// Method to validate the pin code
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cardPin"></param>
        /// <returns>true or false</returns>
        public static bool ValidatePin(int value, int pinCode)
        {

            try
            {

                if (value == pinCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong with the pin code validation");
                Console.WriteLine("Indtast venligst den korrekte pin code");
                throw;
            }
        }
    }
}
