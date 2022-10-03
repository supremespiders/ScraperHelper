using System.Text;
using Microsoft.Playwright;

namespace ScraperHelper.Models;

public class Request
{
    public Method Method { get; set; }
    public string Url { get; set; }
    public string ResourceType { get; set; }
    public Dictionary<string,string> Headers { get; set; }
    public Dictionary<string,string> Cookies { get; set; }
    public Dictionary<string,string> FormData { get; set; }
    public string FormBody { get; set; }

    public Request()
    {
    }

    public string GetCookieString()
    {
        if (Cookies == null) return "";
        var c = new StringBuilder();
        foreach (var cookie in Cookies) c.Append($"{cookie.Key}={cookie.Value};");
        return c.ToString();
    }

    public Request(IRequest req)
    {
        Method = req.Method.ToLower() == "get" ? Method.Get : Method.Post;
        Url = req.Url;
        ResourceType = req.ResourceType;
        var headers = new Dictionary<string, string>();
        var cookies = new Dictionary<string, string>();
        var allHeaders = req.AllHeadersAsync().Result;
        foreach (var reqHeader in allHeaders)
        {
            if (reqHeader.Key.ToLower() == "cookie")
            {
                cookies = reqHeader.Value.Split(';').ToDictionary(x => x.Split('=')[0].Trim(), y => y.Split("=")[1].Trim());
                continue;
            }
            if(reqHeader.Key.StartsWith(":"))continue;
            headers.Add(reqHeader.Key,reqHeader.Value);
        }
        Headers = headers;
        Cookies = cookies;
    }
}

public enum Method
{
    Get,
    Post
}