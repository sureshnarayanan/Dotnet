using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class LongestRepeatedSubstring
    {
        //returns the longest repeated substring in input string
        public static string FindLongestRepeatedSubstring(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            int N = input.Length;
            string[] substrings = new string[N];

            //form an array of substring i to N
            for (int i = 0; i < N; i++)
            {
                substrings[i] = input.Substring(i);
            }

            //Sort the array
            Array.Sort(substrings);

            string result = string.Empty;
            for (int i = 0;i < N-1; i++)
            {
                string lcp = FindLongestCommonString(substrings[i], substrings[i + 1]);
                if (lcp.Length > result.Length)
                {
                    result = lcp;
                }
            }
            return result;
        }

        //returns the longest common matching substring between two string
        public static string FindLongestCommonString(string a, string b)
        {
            int n = Math.Min(a.Length, b.Length);
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == b[i])
                {
                    result = result + a[i];
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}

