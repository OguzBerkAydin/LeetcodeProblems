using System.Text;

namespace _58_LengthofLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

        }
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;

                }
                if (count > 0 && s[i] == ' ')
                    return count;


            }
            return count;
        }

    }
    
}