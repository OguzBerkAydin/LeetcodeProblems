using System.Text;

namespace _1768_MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(MergeAlternately("asdasd", "fgh"));

        }
        public static string MergeAlternately(string word1, string word2)
        {
            //abc defgh adbecfgh
            int length1 = word1.Length;
            int length2 = word2.Length;
            int minLength = Math.Min(length1, length2);

            char[] mergedChars = new char[length1 + length2];
            int index = 0;

            for (int i = 0; i < minLength; i++)
            {
                mergedChars[index++] = word1[i];
                mergedChars[index++] = word2[i];
            }

            if (length1 > length2)
            {
                for (int i = minLength; i < length1; i++)
                {
                    mergedChars[index++] = word1[i];
                }
            }
            else
            {
                for (int i = minLength; i < length2; i++)
                {
                    mergedChars[index++] = word2[i];
                }
            }

            return new string(mergedChars);
        }
    }
    
}