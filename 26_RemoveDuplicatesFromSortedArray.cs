internal class Program
{
    public static void Main()
    {
        int[] sortedArray = { 1, 2, 2, 3, 4, 4, 4, 5, 5, 6,6 };
        int newSize = RemoveDuplicates(sortedArray);

        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < newSize; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }
    }

    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int newIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[newIndex])
            {
                newIndex++;
                nums[newIndex] = nums[i];
            }
        }

        return newIndex + 1;
    }
   
}