internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    public static bool IsValid(string s)
    {
        Dictionary<char, char> dict = new Dictionary<char, char>();
        dict.Add('(', ')');
        dict.Add('{', '}');
        dict.Add('[', ']');

        Stack<char> stack = new Stack<char>();
        // ({})
        // {(])
        // ([]){
        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if (dict.ContainsValue(c))
            {
                if (stack.Count == 0 || dict[stack.Pop()] != c)
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}