using Newtonsoft.Json;

namespace ScraperHelper.Extensions;

public static class UtilityExtensions
{
    public static void Save<T>(this T o)
    {
        File.WriteAllText( nameof(o),JsonConvert.SerializeObject(o));
    }
    
    public static T Load<T>(this T o) where T : class
    {
        if (!File.Exists(nameof(o))) return null;
        return JsonConvert.DeserializeObject<T>(File.ReadAllText(nameof(o)));
    }
}