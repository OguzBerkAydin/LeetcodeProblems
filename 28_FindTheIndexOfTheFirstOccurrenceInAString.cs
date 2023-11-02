namespace _28_FindTheIndexOfTheFirstOccurrenceInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrStr("sabutsad","sad"));
            
        }
        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) 
            {
                return 0;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++) 
            {
                int matchIndex = i;
                bool isMatch = true;

                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[matchIndex] != needle[j])
                    {
                        isMatch = false;
                        break; 
                    }
                    matchIndex++;
                }

                if (isMatch)
                {
                    return i; 
                }
            }

            return -1; 
        }
        
    }
}