using Microsoft.Playwright;

namespace ScraperHelper.Models;

public class Config
{
    public string Url { get; set; }
    public string Xpath { get; set; }
    public string SearchTerm { get; set; }
    public string LocalSearchTerm { get; set; }
    public string Result { get; set; }
    public Request RequestInDebug { get; set; }
    public bool SameDomain { get; set; }
}