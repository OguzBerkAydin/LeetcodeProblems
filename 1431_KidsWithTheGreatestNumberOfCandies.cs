namespace _1431_KidsWithTheGreatestNumberOfCandies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            foreach (var item in KidsWithCandies(candies, 3))
            {
                Console.WriteLine(item);
            }
        }
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            int max = candies[0];
            for (int i = 0; i < candies.Length - 1; i++)
            {
                if (max < candies[i + 1])
                {
                    max = candies[i + 1];
                    
                }
            }
            

            for (int i = 0; i < candies.Length; i++)
            {
                if ((candies[i] + extraCandies) >= max)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }
            return result;
        }
    }
}