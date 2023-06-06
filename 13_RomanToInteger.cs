internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    public static int RomanToInt(string s)
    {

        var dc = new Dictionary<char, int>();

        dc.Add('I', 1);
        dc.Add('V', 5);
        dc.Add('X', 10);
        dc.Add('L', 50);
        dc.Add('C', 100);
        dc.Add('D', 500);
        dc.Add('M', 1000);

        s = s.Replace("IV", "IIII").Replace("IX", "VIIII").Replace("XL", "XXXX").Replace("XC", "LXXXX").
        Replace("CD", "CCCC").Replace("CM", "DCCCC");
        int sum = 0;
        foreach (var c in s)
        {
            sum += dc[c];
        }
        return sum;
    }
}