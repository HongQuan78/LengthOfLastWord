class Program
{
    static void Main()
    {
        string s = "a";
        Console.WriteLine(LengthOfLastWord(s));
    }

    static int LengthOfLastWord(string s)
    {
        int lastSpaceIndex = 0;
        s = s.Trim();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                lastSpaceIndex = i;
            }
        }
        if(lastSpaceIndex == 0)
        {
            return s.Length;
        }
        return  s.Length - lastSpaceIndex - 1;
    }
}