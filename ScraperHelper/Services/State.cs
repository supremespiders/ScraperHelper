using Newtonsoft.Json;
using ScraperHelper.Models;

namespace ScraperHelper.Services;

public class State
{
    public  List<Response> AllResponses = new();
    public  List<Request> ScenarioRequests = new();
    
}