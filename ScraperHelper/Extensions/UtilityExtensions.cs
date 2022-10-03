using System.Text;
using Newtonsoft.Json;

namespace ScraperHelper.Extensions;

public static class UtilityExtensions
{
    public static void Save<T>(this T o)
    {
        File.WriteAllText( nameof(o),JsonConvert.SerializeObject(o));
    }

    public static Dictionary<string, string> ParseHeader(this string s)
    {
        var lines = s.Split(Environment.NewLine).ToList();
        lines.Remove("");
        var r = new Dictionary<string,string>();
        foreach (var line in lines)
        {
             var f = line.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
             r.Add(f[0],f[1]);
        }
        return r;
    }

    public static T DeepClone<T>(this T t) where T : class
    {
        var s = JsonConvert.SerializeObject(t);
        var y = JsonConvert.DeserializeObject<T>(s);
        return y;
    }

    public static T Load<T>(this T o) where T : class
    {
        if (!File.Exists(nameof(o))) return null;
        return JsonConvert.DeserializeObject<T>(File.ReadAllText(nameof(o)));
    }
}