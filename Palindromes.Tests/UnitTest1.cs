using System;
using Xunit;

namespace Palindromes.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var palindromes = "racecar";
            var checkPalindrome = new CheckPalindrome();

            //Act
            var result = checkPalindrome.CheckResult(palindromes);


            //Assert
            Assert.True(result);

        }
    }
}
