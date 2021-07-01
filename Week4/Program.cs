using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = RemoveDuplicates("abbaca");
        }

        public static string RemoveDuplicates(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    string left = s.Substring(0, i);
                    string right = s.Substring(i + 2, s.Length - (i + 2));
                    return RemoveDuplicates(left + right);
                }
            }

            return s;
        }
    }
}