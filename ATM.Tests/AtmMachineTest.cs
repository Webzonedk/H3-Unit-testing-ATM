using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATM.Tests
{
    public class AtmMachineTest
    {
        AtmMachine atmMachine = new();
        
        [Theory]
        [InlineData(123456789)]
        public void GetAccount_SupposedToRethrieveASingleAccount(long account)
        {
            //Arrange


            Account expected = new Account("BudgetKonto", "Kent", 1111222233334444, 123456789, 1234, 1000000);
            //Act
            Account? actual = atmMachine.GetAccount();

        



            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
