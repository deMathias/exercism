using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int intDoublePointLocation = logLine.IndexOf(":");
        string strMessageSubstring = logLine.Substring(intDoublePointLocation+1,logLine.Length-intDoublePointLocation-1);
        string strReturnString = strMessageSubstring.Trim();
        return strReturnString;
    }

    public static string LogLevel(string logLine)
    {
        int intEndBrackLocation = logLine.IndexOf("]");
        string strReturnString = logLine.Substring(1,intEndBrackLocation-1);
        return strReturnString.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string strMessage = Message(logLine);
        string strLogLevel = LogLevel(logLine);
        string strReturnString = $"{strMessage} ({strLogLevel})";
        return strReturnString;
    }
}
