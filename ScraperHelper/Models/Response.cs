using Newtonsoft.Json;

namespace ScraperHelper.Models;

public class Response
{
    public string Url { get; set; }
    public int Code { get; set; }
    public Dictionary<string,string> Headers { get; set; }
    public Dictionary<string,string> Cookies { get; set; }
    public string Content { get; set; }
    public Request Request { get; set; }

    public bool ContainKeyword(string text)
    {
        var t = JsonConvert.SerializeObject(Headers);
        var t2 = JsonConvert.SerializeObject(Cookies);
        if (t.Contains(text) || t2.Contains(text) || Content.Contains(text))
        {
            return true;
        }

        return false;
    }
}