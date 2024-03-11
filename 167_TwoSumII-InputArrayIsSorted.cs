namespace _167._Two_Sum_II___Input_Array_Is_Sorted
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}
		public int[] TwoSum(int[] numbers, int target)
		{

			Dictionary<int, int> dict = new Dictionary<int, int>();
			for (int i = 0; i < numbers.Length; i++)
			{
				int remainder = target - numbers[i];
				if (dict.ContainsKey(remainder))
				{
					return new int[] { dict[remainder], i + 1 };
				}
				dict[numbers[i]] = i + 1;

			}
			return null;

		}
	}
}