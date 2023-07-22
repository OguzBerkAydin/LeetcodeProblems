namespace _605_CanPlaceFlowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool test = CanPlaceFlowers(new int[] { 1, 0, 0}, 1);
            Console.WriteLine(test);
            
        }
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            //[1,0,0,0,1] [0,0,0] [0,0,1,0,0]
            int count = 0; 
            for (int i = 0; i<flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    count++; 
                    if (count == n)
                    {
                        return true;
                    }
                    i++;
                }
            }

            return false;
        }
    }
}