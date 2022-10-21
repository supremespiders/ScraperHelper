using System.Text;
using Microsoft.Playwright;
using Newtonsoft.Json;
using ScraperHelper.Extensions;

namespace ScraperHelper.Models;

public class Request
{
    public int Number { get; set; }
    public Method Method { get; set; }
    public string Url { get; set; }
    public string ResourceType { get; set; }
    public Dictionary<string,string> Headers { get; set; }
    public Dictionary<string,string> Cookies { get; set; }
    public Dictionary<string,string> FormData { get; set; }
    public string FormBody { get; set; }

    public bool ContainKeyword(string text)
    {
        var t = JsonConvert.SerializeObject(Headers);
        var t2 = JsonConvert.SerializeObject(Cookies);
        if (FormBody != null)
        {
            var t3 = JsonConvert.SerializeObject(FormBody);
            if (t3.Contains(text)) return true;
        }
        if (t.Contains(text) || t2.Contains(text))
        {
            return true;
        }

        if (FormBody != null && FormBody.Contains(text)) return true;

        return false;
    }
    public string GetCookieString()
    {
        if (Cookies == null) return "";
        var c = new StringBuilder();
        foreach (var cookie in Cookies) c.Append($"{cookie.Key}={cookie.Value};");
        return c.ToString();
    }

    public string GenerateCode()
    {
        var sb = new StringBuilder();
        var cookies = GetCookieString();
        var headers = Headers;
        if (cookies!="")
            headers.Add("cookie", cookies);

        
        sb.AppendLine($"var request = new HttpRequestMessage({(Method==Method.Get ? "HttpMethod.Get" : "HttpMethod.Post")},\"{Url}\");");

        foreach (var header in headers.Where(header => !header.Key.Equals("content-type")))
            sb.AppendLine($"request.Headers.Add(\"{header.Key}\",\"{header.Value.EscapeDoubleQuote()}\");");

        if (headers.ContainsKey("content-type") && headers["content-type"] == "application/x-www-form-urlencoded")
        {
            sb.AppendLine($"var dic= new Dictionary<string, string>();");
            foreach (var d in FormData) 
                sb.AppendLine($"dic.Add(\"{d.Key}\",\"{d.Value.EscapeDoubleQuote()}\");");
        }

        if (headers.ContainsKey("content-type"))
            switch (headers["content-type"])
            {
                case "application/x-www-form-urlencoded":
                    sb.AppendLine($"request.Content = new FormUrlEncodedContent(dic.ToList());");
                    break;
                case "application/json":
                case "application/json;charset=UTF-8":
                    sb.AppendLine($"request.Content = new StringContent(\"{FormBody}\", Encoding.UTF8, \"application/json\");");
                    break;
            }
        
        sb.AppendLine("var response = await _client.SendAsync(request);");
        sb.AppendLine("var bytes = await response.Content.ReadAsByteArrayAsync();");
        sb.AppendLine("var html = Encoding.UTF8.GetString(bytes);");
        return sb.ToString();
    }
}

public enum Method
{
    Get,
    Post
}