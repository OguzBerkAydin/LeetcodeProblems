internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }

            }
        }
        return new int[] { -1, -1 };

    }
    public int[] TwoSum(int[] nums, int target)
    {

        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        // are there more than 1 solution -> No, you may assume that each input has exactly one solution
        // can I use same element more than once? -> No, you may not use the same element twice
        // in which order should I return? -> you can return the answer in any order.  
        // What is the size of given array -> 2<= size <= 10000
        /*
           Example 1:
           Input: nums = [2,7,11,15], target = 9
           Output: [0,1]
           Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

           Example 2:
           Input: nums = [3,2,4], target = 6
           Output: [1,2]

           Example 3:
           Input: nums = [3,3], target = 6
           Output: [0,1]
      
        */

        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int remainder = target - nums[i];
            if (dict.ContainsKey(remainder))
            {
                return new int[] { dict[remainder], i };
            }
            dict[nums[i]] = i;

        }
        return null;




    }
}