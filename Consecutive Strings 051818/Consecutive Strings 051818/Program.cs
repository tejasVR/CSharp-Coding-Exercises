using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Instractions:

// You are given an array strarr of strings and an integer k.Your task is to return the first longest string consisting of k consecutive strings taken in the array.
// #Example: longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"
// n being the length of the string array, if n = 0 or k > n or k <= 0 return "".

namespace Consecutive_Strings_051818
{
    class LongestConsecutives
    {
        static void Main(string[] args)
        {

        }

        public static String LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || strarr.Length < k || k <= 0)
                return "";

            // Lets sort the list by the length of each element in the array
            var sortedWords =
                from w in strarr
                orderby w.Length
                select w;

            var result = "";

            for (int i = 0; i < k; i++)
            {
                result += sortedWords.ElementAt(i);
            }

            return result;

        }
    }
}
