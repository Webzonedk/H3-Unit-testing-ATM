using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Text.Json;

namespace ATM.Tests
{
    public class AtmMachineTest
    {
        AtmMachine atmMachine = new();
        Bank bank = new Bank();
        
        [Theory]
        [InlineData(123456789)]
        public void GetAccount_SupposedToRethrieveASingleAccount(long account)
        {
            //Arrange

            string expected = JsonSerializer.Serialize(bank.Accounts[0]);
            //Act
            string? actual = JsonSerializer.Serialize(atmMachine.GetAccount(account));

        



            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(123456788)]
        public void GetAccount_SupposedToNotRethrieveASingleAccount(long account)
        {
            //Arrange

            string expected = JsonSerializer.Serialize(bank.Accounts[0]);
            //Act
            string? actual = JsonSerializer.Serialize(atmMachine.GetAccount(account));





            //Assert
            Assert.NotEqual(expected, actual);
        }

    }
}
