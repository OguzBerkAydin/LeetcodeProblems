namespace _169_MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
        }
        public static int MajorityElement(int[] nums)
        {
            int total = 0, num1 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total = 0;
                num1 = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        total++;
                    }

                }
                if ((total) > nums.Length / 2)
                {
                    break;
                }
            }
            return num1;
        }
    }
}