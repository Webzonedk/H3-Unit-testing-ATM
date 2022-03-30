using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Bank
    {
        List<Account> accounts = new List<Account>()
        {
            new Account(1234,1000000),
            new Account(2345,20000)
        };
    };

}
