using System;
using PalindromesCheck;

namespace Check
{
    public class Program
    {
        public static void Main()
        {
            Palindromes newPalindrome = new Palindromes();
            Palindromes newPalindrome1 = new Palindromes();

            Console.WriteLine("Enter a word and a number to see if they are Palindromes:");
            string stringInput = Console.ReadLine();
            string intInput = Console.ReadLine();

            newPalindrome.IsItAPalindrome(stringInput);
            newPalindrome1.IsItAPalindrome1(intInput);
        }

        public static void checkMethod()
        {   
            Console.WriteLine("This word/number is a Palindrome!!!");
        }

        public static void notMethod()
        {   
            Console.WriteLine("This word/number is not a Palindrome!!!");
        }

    }
}