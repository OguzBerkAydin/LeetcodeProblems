using System.Text;

namespace _35_SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

        }
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] >= target)
                    return i;
            return nums.Length;
        }
        
    }
    
}