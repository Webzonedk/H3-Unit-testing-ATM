using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Text.Json;

namespace ATM.Tests
{
    public class ValidatePinTest
    {
        PinValidator pinValidator = new();
        Bank bank = new();



        [Theory]
        [InlineData("1234")]
        public void ValidatePin_InputShouldMatchAccountPin(string input)
        {
            //Arrange
            //Account expected = null;
            string expected = JsonSerializer.Serialize(bank.Accounts[0]);

            //Act
            string actual = JsonSerializer.Serialize(pinValidator.ValidatePin(input));
            //int enteredPin = 1379;
            //int cardPin = 1379;
            //bool actual = (enteredPin == cardPin);

            //Assert
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void ValidatePin_InputShouldNotMatchAccountPin()
        {
            //Arrange
            Account? expected = null;
            //Account expected = new Account("BudgetKonto", "Kent", 1111222233334444, 123456789, 1234, 1000000);

            //Act
            Account? actual = pinValidator.ValidatePin("-5698");
            //int enteredPin = 1379;
            //int cardPin = 1379;
            //bool actual = (enteredPin == cardPin);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
