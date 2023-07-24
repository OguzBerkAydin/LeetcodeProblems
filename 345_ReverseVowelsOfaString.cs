namespace _345_ReverseVowelsOfaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowels("Marge, let's \"went.\" I await news telegram."));
        }
        public static string ReverseVowels(string s)
        {
            string str = "aAeEuUiIoO";

            int start = 0, end = s.Length - 1;

            char[] chars = s.ToCharArray();


            while (start < end)
            {
                if (str.Contains(chars[start]) && str.Contains(chars[end]))
                {
                    char temp = chars[start];
                    chars[start] = chars[end];
                    chars[end] = temp;
                    start++;
                    end--;
                }
                else
                {
                    if (!str.Contains(chars[start]))
                    {
                        start++;
                    }
                    if (!str.Contains(chars[end]))
                    {
                        end--;
                    }
                }
            }

            return new string(chars);
        }
    }
}