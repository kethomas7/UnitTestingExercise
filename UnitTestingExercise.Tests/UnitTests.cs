using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculatorObject = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = calculatorObject.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]
        [InlineData(19,10,9)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculatorObject = new Calculator();


            //Act

            var actual = calculatorObject.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,8,64)]//Add test data <-------
        [InlineData(5,5,25)]
        [InlineData(8,7,56) ]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculatorObject = new Calculator();

            //Act

            var actual = calculatorObject.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(100,10,10)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var calculatorObject = new Calculator();
            //Act

            var actual = calculatorObject.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
