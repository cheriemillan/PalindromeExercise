using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string answer)
    {
        string reversed = new string(answer.Reverse().ToArray());
        return answer.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}