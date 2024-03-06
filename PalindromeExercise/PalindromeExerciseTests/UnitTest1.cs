using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("level", true)]
        [InlineData("radar", true)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            WordSmith instance = new WordSmith();

            //Act
            bool actual = instance.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
