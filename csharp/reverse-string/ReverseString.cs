using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string strReturnString = "";
        for(int i = input.Length -1; i >= 0; i--)
        {
            strReturnString += input[i];
        }
        return strReturnString;
    }
}