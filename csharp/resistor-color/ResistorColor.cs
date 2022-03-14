using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] strColors = Colors();
        return Array.IndexOf(strColors, color);
    }

    public static string[] Colors()
    {
        string[] strColors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return strColors;
    }
}