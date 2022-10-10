using System.Diagnostics;
using Gma.System.MouseKeyHook;
using Microsoft.Playwright;
using Newtonsoft.Json;
using ScraperHelper.Extensions;
using ScraperHelper.Models;

namespace ScraperHelper.Services;

public class BrowserService
{
    private IPlaywright _playwright;
    private IBrowserContext _browser;
    private IPage _page;
    private readonly string _path = AppDomain.CurrentDomain.BaseDirectory;
    private IKeyboardMouseEvents m_GlobalHook;
    public Config Config;
    public EventHandler<string> OnXpathChanged { get; set; }
    public string SearchTerm;
    private string _lastXpath { get; set; }
    private readonly List<string> _allowedTypes = new() { "document", "fetch", "xhr" };
    public List<Response> AllRequests = new();
    public bool CaptureAll { get; set; }
    public bool CaptureRequestsEnabled;
    public EventHandler<Response> OnRequestCaptured { get; set; }

    public async Task StartBrowser(bool headless, string url)
    {
        Notifier.Display("Starting browser");
        _playwright = await Playwright.CreateAsync();
        Directory.CreateDirectory("temp");
        var userDataDir = $"{_path}/tmp";
        _browser = await _playwright.Chromium.LaunchPersistentContextAsync(userDataDir, new BrowserTypeLaunchPersistentContextOptions()
        {
            Headless = headless,
            //  Args = new []{$"--disable-extensions-except={_path}/ext"} //$"--load-extension={_path}/ext", ,{_path}/ext2
        });
        //  var context = await _browser.NewContextAsync();
        _page = _browser.Pages[0];
        Notifier.Display("browser started");
        //  _page.Request += OnPageOnRequest;
        _page.Response += OnPageOnResponse;
        await _page.GotoAsync(url);
    }

    public async Task GetNeededRequests(string text)
    {
        foreach (var resp in AllRequests)
        {
            var t = JsonConvert.SerializeObject(resp.Headers);
            var t2 = JsonConvert.SerializeObject(resp.Cookies);
            if (t.Contains(text) || t2.Contains(text) || resp.Content.Contains(text))
            {
                OnRequestCaptured?.Invoke(this, resp);
            }
        }
    }
    
    public void StartNewCapture()
    {
        AllRequests = new List<Response>();
        AllRequests.Save();
        CaptureRequestsEnabled = true;
    }

    private bool IsSameDomain(string url)
    {
        var baseHost = Config.Url.ParseHost();
        var thisHost = url.ParseHost();
        if (baseHost.Length <= thisHost.Length && thisHost.Contains(baseHost)) return true;
        if (baseHost.Length >= thisHost.Length && baseHost.Contains(thisHost)) return true;
        return false;
    }

    private async void OnPageOnResponse(object _, IResponse response)
    {
        if (!CaptureRequestsEnabled) return;
        if (string.IsNullOrEmpty(SearchTerm) && !CaptureAll) return;
        if (!_allowedTypes.Contains(response.Request.ResourceType)) return;
        if (Config.SameDomain && !IsSameDomain(response.Url))
            return;
        Debug.WriteLine("<< " + response.Status + " " + response.Url + " ");
        // if (!response.Request.Url.EndsWith("search")) return;
        //     Debug.WriteLine("");
        if (!response.Ok && response.Status!=301 && response.Status!=302) 
            return;
        var resp = await response.Convert();
        AllRequests.Add(resp);
        // if (CaptureAll)
        // {
        //     OnRequestCaptured?.Invoke(this, resp);
        //     return;
        // }
        try
        {
            var y = JsonConvert.SerializeObject(resp.Request);
            if (y.Contains(SearchTerm))
            {
                OnRequestCaptured?.Invoke(this, resp);
                return;
            }
            if (resp.Content.Contains(SearchTerm))
            {
                OnRequestCaptured?.Invoke(this, resp);
                return;
            }
            OnRequestCaptured?.Invoke(this, resp);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.ToString());
        }
    }

    private void OnPageOnRequest(object _, IRequest request)
    {
        if (string.IsNullOrEmpty(SearchTerm)) return;
        if (!_allowedTypes.Contains(request.ResourceType)) return;
        //Debug.WriteLine(">> " + request.Method + " " + request.Url);
        //_allRequests.Add(request.);
    }

    public async Task Attach()
    {
        Notifier.Display("attaching to browser");
        _playwright = await Playwright.CreateAsync();
        var b = await _playwright.Chromium.ConnectOverCDPAsync("http://localhost:9222", new BrowserTypeConnectOverCDPOptions());
        _browser = b.Contexts[0];
        _page = _browser.Pages[0];
        Notifier.Display("Attached");
    }

    public async Task Dispose()
    {
        if (_browser == null) return;
        //await _browser.CloseAsync();
        // await _browser.DisposeAsync();
        if (_browser.Browser != null)
            await _browser.Browser.CloseAsync();
        _playwright.Dispose();
        Unsubscribe();
    }

    private void Unsubscribe()
    {
        if (m_GlobalHook == null) return;
        m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
        m_GlobalHook.Dispose();
    }

    public void Subscribe()
    {
        if (m_GlobalHook != null) return;
        // Note: for the application hook, use the Hook.AppEvents() instead
        m_GlobalHook = Hook.GlobalEvents();
        m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
    }

    public void LoadRequests()
    {
        AllRequests=AllRequests.Load();
    }
    public void SaveRequests()
    {
        AllRequests.Save();
    }

    public List<Request> SearchRequests(string text)
    {
        var requests = new List<Request>();
        foreach (var resp in AllRequests)
        {
            if (resp.ContainKeyword(text) || resp.Request.ContainKeyword(text))
            {
               requests.Add(resp.Request);
            }
        }

        return requests;
    }

    public async Task SetHtml(string html)
    {
        await _page.SetContentAsync(html);
    }

    private async void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
    {
        if (Control.ModifierKeys != Keys.Shift) return;
        Debug.WriteLine($"MouseDown: {e.Button} {Control.ModifierKeys == Keys.Shift}");
        if (_page == null) return;
        await Task.Delay(500);
        var s = "//*[@id='xpath-content']";
        if (!await _page.Exist(s)) return;
        var t = await _page.Locator(s).TextContentAsync();
        if (t != _lastXpath)
        {
            _lastXpath = t;
            OnXpathChanged?.Invoke(this, t);
        }
        // uncommenting the following line will suppress the middle mouse button click
        // if (e.Buttons == MouseButtons.Middle) { e.Handled = true; }
    }
}