using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("brick", false)]
        [InlineData("madam", true)]
        public void Test1(string answer, bool expected)
        {
            WordSmith wordSmith = new WordSmith();

            bool actual = wordSmith.IsAPalindrome(answer);
            
            Assert.Equal(expected, actual);


        }
    }
}
