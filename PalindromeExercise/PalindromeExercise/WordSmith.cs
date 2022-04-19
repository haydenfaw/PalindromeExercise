using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            return String.Equals(new string(word.Reverse().ToArray()), word, StringComparison.OrdinalIgnoreCase);

            // ORIGINAL SOLUTION:
            //string reverse = "";
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    reverse += word[i];
            //}
            //return (word.ToLower() == reverse.ToLower()) ? true : false;
        }
    }
}
