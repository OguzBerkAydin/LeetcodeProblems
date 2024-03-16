using System.Text;

namespace _2485FindthePivotInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

        }
        public int PivotInteger(int n)
        {
            for (int i = 1; i <= n; i++)
            {

                int left = (i * (i + 1)) / 2;
                int right = ((n * (n + 1)) / 2) - left + i;

                if (left == right)
                {
                    return i;
                }
            }
            return -1;
        }

    }
    
}