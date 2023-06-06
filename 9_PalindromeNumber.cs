internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    public static bool IsPalindrome(int x)
    {
        string rx = "";
        string strx = x.ToString();

        for (int i = x.ToString().Length - 1; i >= 0; i--)
        {
            rx += strx[i];
        }
        if (strx.Equals(rx))
            return true;
        else
            return false;
    }
}