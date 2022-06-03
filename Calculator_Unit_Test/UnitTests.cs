using Xunit;
using Calculator_App;

namespace Calculator_Tests
{
    public class UnitTests
    {
        [Fact]
        public void Addition_valid()
        {
            var operation = "+";
            var num1 = 56;
            var num2 = 44;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 100);
        }

        [Fact]
        public void Addition_with_first_number_as_negative()
        {
            var operation = "+";
            var num1 = -44;
            var num2 = 44;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 0);
        }
        
        [Fact]
        public void Addition_with_second_number_as_negative()
        {
            var operation = "+";
            var num1 = 44;
            var num2 = -44;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 0);
        }

        [Fact]
        public void Addition_with_first_number_as_zero()
        {
            var operation = "+";
            var num1 = 0;
            var num2 = 44;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 44);
        }

        [Fact]
        public void Addition_with_second_number_as_zero()
        {
            var operation = "+";
            var num1 = 44;
            var num2 = 0;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 44);
        }
        
        [Fact]
        public void Addition_with_first_number_as_float()
        {
            var operation = "+";
            var num1 = 4.5;
            var num2 = 10;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 14.5);
        }

        [Fact]
        public void Addition_with_second_number_as_float()
        {
            var operation = "+";
            var num1 = 10;
            var num2 = 4.4;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 14.4);
        }

        [Fact]
        public void Addition_with_both_number_as_float()
        {
            var operation = "+";
            var num1 = 10.4;
            var num2 = 40.4;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 50.8);
        }

        [Fact]
        public void Addition_with_both_number_as_zero()
        {
            var operation = "+";
            var num1 = 0;
            var num2 = 0;
            var result = new Basic().basic_operations(operation, num1, num2);
            Assert.Equal(result, 0);
        }
    }
}