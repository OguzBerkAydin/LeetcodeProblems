namespace _1732_FindTheHighestAltitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestAltitude(new int[] { 52, -91, 72 }));
        }
        public static int LargestAltitude(int[] gain)
        {
            if (gain.Length == 1 && gain[0] <= 0)
            {
                return 0;
            }
            else if (gain.Length == 1 && gain[0] >= 0)
            {
                return gain[0];
            }

            int maxAltitude = 0;
            int checkAltitude = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                checkAltitude += gain[i];
                if (checkAltitude > maxAltitude)
                {
                    maxAltitude = checkAltitude;
                }
            }
            return maxAltitude;
        }
    }
}