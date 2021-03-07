using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("abikba"));
        }
        static bool IsPalindrome(string s)
        {
            bool result = true;
            if (s[0] != s[s.Length - 1])
            {
                result = false;

            }
            else if (s.Length > 2)
            {
                s = s.Substring(1, s.Length - 2);
                return IsPalindrome(s);
            }
            else
            {
                result = true;
            }
            if (result)
            {
                return true;
            }
            else return false;
        }
    }
}
       
            
            
            
           
           
            
        


   


       

      


    

