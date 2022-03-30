using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATM.Tests
{
    public class ValidatePinTest
    {
        [Fact]
        public void ValidatePin_InputShouldMatchAccountPin()
        {
            //Arrange


            bool expected = true;
            //Act
            bool actual = PinValidator.ValidatePin("1234");

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


            bool expected = false;
            //Act
            bool actual = PinValidator.ValidatePin("-5698");

            //int enteredPin = 1379;
            //int cardPin = 1379;
            //bool actual = (enteredPin == cardPin);



            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
