using System;
using Check;

namespace PalindromesCheck
{
    public class Palindromes
    {
        public bool IsItAPalindrome(string stringInput)
        {
            char[] palindromesArray = stringInput.ToCharArray();
            Array.Reverse(palindromesArray);
            string reverseInput = string.Join("", palindromesArray);
            if (stringInput == reverseInput)
            {
                Program.checkMethod();
                return true;
            }
            else
            {
                Program.notMethod();
                return false;
            }
        }

        public bool IsItAPalindrome1(string intInput)
        {
            char[] palindromesArray = intInput.ToCharArray();
            Array.Reverse(palindromesArray);
            string reverseInput = string.Join("", palindromesArray);
            if (intInput == reverseInput)
            {
                Program.checkMethod();
                return true;
            }
            else
            {
                Program.notMethod();
                return false;
            }
        }
    }
}
