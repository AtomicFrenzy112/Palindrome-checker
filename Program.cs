using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            //Takes an input//
           
            char[] wordCharacters = word.ToCharArray();
            Array.Reverse(wordCharacters);
            //Creates an array of the charecters and then reverses them

            string invertedWord = new string(wordCharacters);
            //Makes the reversed word into a string
            if (invertedWord == word)
            //Compares the reversed word and the original word//
            {
                Console.WriteLine(word + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(word + " is not a palindrome.");
            }
        }
    }
}
