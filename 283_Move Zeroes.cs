namespace _283_MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MoveZeroes(new int[] { 0,0,1 });
            
        }
        public static void MoveZeroes(int[] nums)
        {
            //  0, 1, 0, 3, 12
            int nonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[nonZeroIndex];
                    nums[nonZeroIndex] = temp;
                    nonZeroIndex++;
                }
            }
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

        }
    }
}