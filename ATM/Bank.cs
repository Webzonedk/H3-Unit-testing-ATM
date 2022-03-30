using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Bank
    {
        public List<Account> Accounts { get; set; }

        public Bank()
        {
            Accounts = new List<Account>()
            {
            new Account("BudgetKonto","Kent",1111222233334444,123456789,1234,1000000),
            new Account("Lønkonto","Kent",5555666677778888,987654321,2345,20000)
            };
        }


    };

}
