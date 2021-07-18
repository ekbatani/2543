using System;

namespace _2543
{
    public class ReversedStringsSofia
    {
        public static string Solution(string str)
        {
            string reverse = "";

            for (int i = str.Length; i > 0; i--)
            {
                reverse += str[i-1];
            }

            return reverse;
        }
    }
}