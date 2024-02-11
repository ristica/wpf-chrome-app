namespace Chrome.Common;

public delegate void ChangeCultureHandler(string culture);

public static class CultureHandler
{
    public static event ChangeCultureHandler? ChangeCulture;

    public static void ChangeCultureAction(string lang)
    {
        ChangeCulture?.Invoke(lang);
    }
}