using System.Linq;

namespace InterleavingString
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r1 = IsInterleave("aabcc", "dbbca", "aadbbcbcac");
            bool r2 = IsInterleave("aabcc", "dbbca", "aadbbbaccc");
            bool r3 = IsInterleave("", "", "");
        }

        static bool Trim(ref string s, ref string s3)
        {
            bool isTrimed = false;
            char c = s3.FirstOrDefault();
            if (s.StartsWith(c))
            {
                isTrimed = true;
                s = s.Substring(1);
                s3 = s3.Substring(1);
                Trim(ref s, ref s3);
            }

            return isTrimed;
        }

        public static bool IsInterleave(string s1, string s2, string s3)
        {
            bool isTrimed1 = true;
            bool isTrimed2 = true;
            while (isTrimed1 || isTrimed2)
            {
                isTrimed1 = Trim(ref s1, ref s3);
                isTrimed2 = Trim(ref s2, ref s3);
                
                if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2) && string.IsNullOrEmpty(s3))
                    return true;
                
                if (!isTrimed1 && !isTrimed2)
                    return false;
            }

            return true;
        }
    }
}