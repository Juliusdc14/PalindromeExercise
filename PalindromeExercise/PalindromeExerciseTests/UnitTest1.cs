using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecare", false)]
        public void Mytest(string word, bool expected)
        {
            //Arrange
            var myTest = new WordSmith();

            //Act
            bool actual = myTest.IsPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
