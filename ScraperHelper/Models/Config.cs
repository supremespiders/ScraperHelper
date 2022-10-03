using Microsoft.Playwright;

namespace ScraperHelper.Models;

public class Config
{
    public string Url { get; set; }
    public string Xpath { get; set; }
    public string SearchTerm { get; set; }
    public List<Request> TargetedRequests { get; set; }
    public Request RequestInDebug { get; set; }
}