using System.Text;

namespace _191_Numberof1Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(MergeAlternately("asdasd", "fgh"));

        }

        public static int HammingWeight(uint n)
        {
            int counter = 0;

            while (n > 0)
            {
                counter += (int)(n & 1);
                n >>= 1;
            }
            return counter;
        }
    }
    
}