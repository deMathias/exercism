using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] charsAlphabetLower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] charsAlphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        string strReturnString = "";
        foreach(char c in text)
        {
            if(char.IsLower(c))
            {
                int intCharIndex = Array.IndexOf(charsAlphabetLower, c);
                if (intCharIndex + shiftKey >= 26)
                {
                    int intShiftedCharIndex = intCharIndex + shiftKey - 26;
                    strReturnString += charsAlphabetLower[intShiftedCharIndex];
                }
                else
                {
                    strReturnString += charsAlphabetLower[intCharIndex + shiftKey];
                }
            }
            else if(char.IsUpper(c))
            {
                int intCharIndex = Array.IndexOf(charsAlphabetUpper, c);
                if (intCharIndex + shiftKey >= 26)
                {
                    int intShiftedCharIndex = intCharIndex + shiftKey - 26;
                    strReturnString += charsAlphabetUpper[intShiftedCharIndex];
                }
                else
                {
                    strReturnString += charsAlphabetUpper[intCharIndex + shiftKey];
                }
            }
            else
            {
                strReturnString += c;
            }
        }
        return strReturnString;
    }
}