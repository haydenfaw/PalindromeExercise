using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hello", false)]
        [InlineData("upgrade", false)]
        [InlineData("level", true)]
        public void Test1(string word, bool expected)
        {
            //Arange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
