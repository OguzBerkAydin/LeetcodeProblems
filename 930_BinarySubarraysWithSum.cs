using System.Text;

namespace _930_BinarySubarraysWithSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

        }
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            int counter = 0;
            int sum = 0;
            Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                sum += num;
                if (sum == goal)
                    counter++;

                if (prefixSumCount.ContainsKey(sum - goal))
                    counter += prefixSumCount[sum - goal];

                if (!prefixSumCount.ContainsKey(sum))
                    prefixSumCount[sum] = 1;
                else
                    prefixSumCount[sum]++;
            }

            return counter;
        }
        //***************************************************************

        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {

                    sum += nums[j];
                    if (sum == goal)
                    {
                        counter++;
                    }
                    else if (sum > goal)
                        break;


                }
            }
            return counter;
        }
        
    }
    
}