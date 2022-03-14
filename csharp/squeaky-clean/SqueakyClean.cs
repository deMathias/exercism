using System;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string strReturnString = "";
        Boolean boolShouldIMakeUpper = false;
        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                strReturnString += "_";
            }
            else if (char.IsControl(c))
            {
                strReturnString += "CTRL";
            }
            else if (c == '-')
            {
                boolShouldIMakeUpper = true;
            }
            else if (!char.IsLetter(c))
            {

            }
            else if (boolShouldIMakeUpper)
            {
                strReturnString += Char.ToUpper(c);
                boolShouldIMakeUpper = false;
            }
            else if (Regex.IsMatch(c.ToString(),"[α-ω]",RegexOptions.None))
            {

            }
            else
            {
                strReturnString += c;
            }
        }
        return strReturnString;
    }
}
