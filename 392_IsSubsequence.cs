namespace _392_IsSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("acb", "ahbgdc"));

        }
        public static bool IsSubsequence(string s, string t)
        {
            s = s.ToLower();
            t = t.ToLower();

            int sIndex = 0;
            int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }

            return sIndex == s.Length;
        }
    }

}