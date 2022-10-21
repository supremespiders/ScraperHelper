using System.Net;
using System.Text;
using Microsoft.Playwright;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScraperHelper.Models;

namespace ScraperHelper.Extensions;

public static class UtilityExtensions
{
    public static void Save<T>(this T o)
    {
        File.WriteAllText(o.GetType().Name, JsonConvert.SerializeObject(o));
    }

    public static Dictionary<string, string> ParseHeader(this string s)
    {
        var lines = s.Split("\n").ToList();
        lines.Remove("");
        var r = new Dictionary<string, string>();
        foreach (var line in lines)
        {
            var f = line.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
            r.Add(f[0], f.Length == 1 ? "" : f[1]);
        }

        return r;
    }

    public static T DeepClone<T>(this T t) where T : class
    {
        var s = JsonConvert.SerializeObject(t);
        var y = JsonConvert.DeserializeObject<T>(s);
        return y;
    }

    public static string EscapeDoubleQuote(this string s)
    {
        return s.Replace("\"", "\\\"");
    }

    public static T Load<T>(this T o) where T : class
    {
        if (!File.Exists(o.GetType().Name)) return null;
        o = JsonConvert.DeserializeObject<T>(File.ReadAllText(o.GetType().Name));
        return o;
    }

    public static Dictionary<string, string> FormUrlEncodedToDictionary(this string s)
    {
        var dic = new Dictionary<string, string>();
        if (string.IsNullOrEmpty(s)) return dic;
        var parts = s.Split("&");
        foreach (var part in parts)
        {
            var x1 = part.IndexOf("=", StringComparison.Ordinal);
            if (x1 == -1) throw new KnownException($"No = in cookie");
            var key = part[..x1];
            var value = part[(x1 + 1)..];
            dic.Add(WebUtility.UrlDecode(key), WebUtility.UrlDecode(value));
        }

        return dic;
    }

    public static string DictionaryToFormUrlEncoded(this Dictionary<string, string> dic)
    {
        var sb = new StringBuilder();
        if (dic == null) return sb.ToString();
        var r = 0;
        foreach (var d in dic)
        {
            sb.Append($"{WebUtility.UrlEncode(d.Key)}={WebUtility.UrlEncode(d.Value)}");
            r++;
            if (r < dic.Count)
                sb.Append("&");
        }

        return sb.ToString();
    }

    public static async Task<Response> Convert(this IResponse response)
    {
        var r = new Response
        {
            Url = response.Url
        };
        var headers = new Dictionary<string, string>();
        var cookies = new Dictionary<string, string>();
        var allHeaders = await response.AllHeadersAsync();
        foreach (var reqHeader in allHeaders)
        {
            if (reqHeader.Key.ToLower() == "cookie")
            {
                cookies = reqHeader.Value.ParseCookies();
                continue;
            }

            if (reqHeader.Key.StartsWith(":")) continue;
            if (reqHeader.Key.ToLower() == "content-length") continue;
            headers.Add(reqHeader.Key, reqHeader.Value);
        }

        var content = "";
        try
        {
            content = await response.TextAsync();
        }
        catch (Exception)
        {
            //
        }

        r.Request = await response.Request.Convert();
        r.Cookies = cookies;
        r.Headers = headers;
        r.Content = content;
        r.Code = response.Status;
        return r;
    }

    public static Dictionary<string, string> ParseCookies(this string cookieString)
    {
        var dc = new Dictionary<string, string>();
        var cc = cookieString.Split(";");
        foreach (var c in cc)
        {
            var x1 = c.IndexOf("=", StringComparison.Ordinal);
            if (x1 == -1) throw new KnownException($"No = in cookie");
            var key = c[..x1];
            var value = c[(x1 + 1)..];
            if (!dc.ContainsKey(key))
                dc.Add(key, value);
        }
        return dc;
    }

    public static async Task<Request> Convert(this IRequest req)
    {
        var r = new Request();
        r.Method = req.Method.ToLower() == "get" ? Method.Get : Method.Post;
        r.Url = req.Url;
        r.ResourceType = req.ResourceType;
        var headers = new Dictionary<string, string>();
        var cookies = new Dictionary<string, string>();
        var allHeaders = await req.AllHeadersAsync();
        foreach (var reqHeader in allHeaders)
        {
            if (reqHeader.Key.ToLower() == "cookie")
            {
                cookies = reqHeader.Value.ParseCookies();
                continue;
            }

            if (reqHeader.Key.StartsWith(":")) continue;
            if (reqHeader.Key.ToLower() == "content-length") continue;
            headers.Add(reqHeader.Key, reqHeader.Value);
        }

        string reqBody = null;
        Dictionary<string, string> formData = null;
        if (headers.ContainsKey("content-type"))
            switch (headers["content-type"])
            {
                case "application/x-www-form-urlencoded":
                    formData = req.PostData.FormUrlEncodedToDictionary();
                    break;
                case "application/json":
                    reqBody = req.PostData;
                    break;
            }

        r.Headers = headers;
        r.Cookies = cookies;
        r.FormBody = reqBody;
        r.FormData = formData;
        return r;
    }

    public static string DictionaryToText(this Dictionary<string, string> dic)
    {
        var s = new StringBuilder();
        foreach (var f in dic) s.AppendLine($"{f.Key} : {f.Value}");
        return s.ToString();
    }

    public static string BeautifyIfJson(this string json)
    {
        try
        {
            var obj = JToken.Parse(json);
            var s = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return s;
        }
        catch (Exception)
        {
            //
        }

        return json;
    }

    public static int HighlightText(this RichTextBox t, string text)
    {
        var start = 0;
        var howMany = 0;
        do
        {
            var x = t.Text.IndexOf(text, start, StringComparison.Ordinal);
            if (x == -1) break;
            t.SelectionStart = x;
            t.SelectionLength = text.Length;
            t.SelectionFont = new Font(t.Font.FontFamily, 10, FontStyle.Bold);
            t.SelectionBackColor = Color.Yellow;
            t.ScrollToCaret();
            t.SelectionLength = 0;
            howMany++;
            start = x + 1;
        } while (true);

        return howMany;
    }
    
    public static string StringBetween(this string main, string s1, string s2)
    {
        if (!main.Contains(s1) || !main.Contains(s2)) return null;
        var x1 = main.IndexOf(s1, StringComparison.Ordinal) + s1.Length;
        var x2 = main.IndexOf(s2, x1 + 1, StringComparison.Ordinal);
        return (main.Substring(x1, x2 - x1));
    }

    public static string ParseHost(this string url)
    {
        var host = new Uri(url).Host;
        if (host.StartsWith("www."))
            host=host.Replace("www.", "");
        return host;
    }
}