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
            var palindromes = "Civic";
            var checkPalindrome = new CheckPalindrome();


            //Act
            var result = checkPalindrome.CheckResult(palindromes);



            //Assert
            Assert.False(result);

        }
        [Fact]
        public void Test2()
        {
            //Arrange
            var palindromes2 = "Dammit, I'm Mad!";
            var checkPalindrome = new CheckPalindrome();

            //Act


            //Assert
        }

    }
}
