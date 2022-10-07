using System.Net;
using System.Text;
using ScraperHelper.Extensions;
using ScraperHelper.Models;

namespace ScraperHelper.Services;

public class HttpService
{
    private readonly HttpClient _client = new(new HttpClientHandler
    {
        UseCookies = false,
        AutomaticDecompression = DecompressionMethods.All
    });

    public async Task<Request> Optimize(Request baseRequest, string searchTerm)
    {
        var lastSuccess=await CheckCookiesIsNeeded(baseRequest, searchTerm);
        lastSuccess = await CheckHeadersAreNeeded(lastSuccess, searchTerm);
        return lastSuccess;
    }

    private async Task<Request> CheckCookiesIsNeeded(Request baseRequest, string searchTerm)
    {
        var r = baseRequest.DeepClone();
        r.Cookies.Clear();
        if (await IsRequestSuccess(r, searchTerm)) return r;
        var lastSuccess=baseRequest.DeepClone();
        foreach (var rCookie in baseRequest.Cookies)
        {
            var r2 = lastSuccess.DeepClone();
            r2.Cookies.Remove(rCookie.Key);
            if (await IsRequestSuccess(r2, searchTerm))
                lastSuccess = r2;
        }
        return lastSuccess;
    }
    
    private async Task<Request> CheckHeadersAreNeeded(Request baseRequest, string searchTerm)
    {
        var r = baseRequest.DeepClone();
        r.Headers.Clear();
        if (await IsRequestSuccess(r, searchTerm)) return r;
        var lastSuccess=baseRequest.DeepClone();
        foreach (var h in baseRequest.Headers)
        {
            var r2 = lastSuccess.DeepClone();
            r2.Headers.Remove(h.Key);
            if (await IsRequestSuccess(r2, searchTerm))
                lastSuccess = r2;
        }
        return lastSuccess;
    }

    private async Task<bool> IsRequestSuccess(Request request, string searchTerm)
    {
        var resp = await Execute(request);
        return resp.body.Contains(searchTerm);
    }
    
    public async Task<(string body,Dictionary<string,string> headers)> Execute(Request request)
    {
        var r = new HttpRequestMessage(request.Method==Method.Get ? HttpMethod.Get : HttpMethod.Post, request.Url);
        foreach (var header in request.Headers)
        {
            if (header.Key.Equals("content-type")) continue;
            try
            {
                r.Headers.Add(header.Key, header.Value);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Couldn't add header : {header.Key} : {header.Value} : {e.Message}");
                throw;
            }
        }

        var c = request.GetCookieString();
        if(c!="")
            r.Headers.Add("cookie",c);


        if (request.Headers.ContainsKey("content-type"))
            r.Content = request.Headers["content-type"] switch
            {
                "application/x-www-form-urlencoded" => new FormUrlEncodedContent(request.FormData.ToList()),
                "application/json" => new StringContent(request.FormBody, Encoding.UTF8, "application/json"),
                _ => r.Content
            };
        var s = await _client.SendAsync(r);
        var m = await s.Content.ReadAsByteArrayAsync();
        var headers = new Dictionary<string, string>();
        foreach (var h in s.Headers)
        {
            headers.Add(h.Key,string.Join(" ",h.Value));
        }
        return ((Encoding.UTF8.GetString(m)),headers);
    }
}