internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    public static string LongestCommonPrefix(string[] strs)
    {
        string longestPrefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(longestPrefix) != 0)
            {
                longestPrefix = longestPrefix.Substring(0, longestPrefix.Length - 1);
                if (longestPrefix == null)
                    return "";
            }

        }
        return longestPrefix;
    }
}