using ScraperHelper.Extensions;

namespace ScraperHelper.Services;

public static class Global
{
    public static State State=new();

    public static void LoadState()
    {
        State.Load();
    }
    
    public static void SaveState()
    {
        State.Save();
    }
}