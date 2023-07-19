internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        int m = 3, n = 3;
        Merge(nums1, m, nums2, n);
        foreach (var item in nums1)
        {
            Console.WriteLine(item);
        }

    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int last = m + n - 1;
        while (n > 0 && m > 0)
        {
            if (nums1[m - 1] > nums2[n - 1])
            {
                nums1[last] = nums1[m - 1];
                last--;
                m--;
            }
            else
            {
                nums1[last] = nums2[n - 1];
                last--;
                n--;

            }
        }
        while (n > 0)
        {
            nums1[last] = nums2[n - 1];
            last--;
            n--;
        }
    }

}