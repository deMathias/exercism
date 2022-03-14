using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] charsAlphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        foreach(char c in input)
        {
            char charLowerChar = char.ToLower(c);
            if(charsAlphabet.Contains(charLowerChar))
            {
                charsAlphabet = charsAlphabet.Where(x => x != charLowerChar).ToArray();
            }
        }
        return charsAlphabet.Length == 0;
    }
}
