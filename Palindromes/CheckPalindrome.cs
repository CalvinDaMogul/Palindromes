using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class CheckPalindrome
    {
        public bool CheckResult(string luna)
        {
            var reverseWord = luna.Reverse();
            var correctWord = string.Concat(reverseWord);
            if (correctWord == luna)
            {
                return true;
            }
            else return false;
            

                

        } 
       
    }
}
