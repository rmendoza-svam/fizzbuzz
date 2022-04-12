using Fizz_Buzz.infrastructure;
using Fizz_Buzz.Models;
using Xunit;

namespace FizzBuzz.Tests.Models
{
    public class FizzBuzzModelTest
    {
        [Fact]
        public void createModel()
        {
            var model = new Fizz_BuzzModel();
            Assert.True(model.Data != null);
        }
        [Fact]
        public void CalculateThree()
        {
            var model = new Fizz_BuzzModel();
            model.Data[0] = "3";
            model.Calculate();
            Assert.True(model.DataResult[0][1] == Constants.Fizz);
        }
        [Fact]
        public void CalculateFive()
        {
            var model = new Fizz_BuzzModel();
            model.Data[0] = "5";
            model.Calculate();
            Assert.True(model.DataResult[0][1] == Constants.Buzz);
        }
        [Fact]
        public void CalculateFiveAndThree()
        {
            var model = new Fizz_BuzzModel();
            model.Data[0] = "30";
            model.Calculate();
            Assert.True(model.DataResult[0][1] == Constants.FizzBuzz);
        }
        [Fact]
        public void CalculateEmptyValue()
        {
            var model = new Fizz_BuzzModel();
            model.Calculate();
            Assert.True(model.DataResult[0][0] == Constants.EmptyValue);
        }
        [Fact]
        public void CalculateInvalidItem()
        {
            var model = new Fizz_BuzzModel();
            model.Data[0] = "A30A";
            model.Calculate();
            Assert.True(model.DataResult[0][1] == Constants.InvalidItem);
        }
    }
}
