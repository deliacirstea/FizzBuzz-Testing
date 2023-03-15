using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private readonly FizzBuzz sut;

        public FizzBuzzTests()
        {
            sut = new FizzBuzz();
        }

        [TestMethod]
        public void When_non_divisible_number()
        {
            var number = 1;
            var result = sut.Run(number);
            Assert.AreEqual(number.ToString(), result);
        }

        [TestMethod]
        public void When__divisible_by_3()
        {
            var number = 3;
            var result = sut.Run(number);
            Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void When__divisible_by_5()
        {
            var number = 5;
            var result = sut.Run(number);
            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void When__divisible_by_5_and_3()
        {
            var number = 15;
            var result = sut.Run(number);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
