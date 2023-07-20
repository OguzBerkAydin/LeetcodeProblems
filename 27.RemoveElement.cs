namespace _27.RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3, 4, 5, 3 };
            int newlength = RemoveElement(nums, 2);
            Console.WriteLine(newlength);
            for (int i = 0; i < newlength; i++)
            {
                Console.Write(nums[i]+" ");
            }
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}