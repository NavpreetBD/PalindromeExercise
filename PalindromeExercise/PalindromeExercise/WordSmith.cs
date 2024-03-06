using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string originalWord) 
        {
            string reversedWord = "";
            for(int i = originalWord.Length - 1; i >= 0; i--) 
            {
                reversedWord += originalWord[i];    
            }

            return originalWord.ToLower() == reversedWord.ToLower();
        }
    }
}
