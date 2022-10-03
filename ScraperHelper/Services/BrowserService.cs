using System.Diagnostics;
using Gma.System.MouseKeyHook;
using Microsoft.Playwright;
using ScraperHelper.Extensions;

namespace ScraperHelper.Services;

public class BrowserService
{
    private IPlaywright _playwright;
    private IBrowserContext _browser;
    private IPage _page;
    private readonly string _path = AppDomain.CurrentDomain.BaseDirectory;
    private IKeyboardMouseEvents m_GlobalHook;
    public EventHandler<string> OnXpathChanged { get; set; }
    public string SearchTerm;
    private string _lastXpath { get; set; }
    private HashSet<string> _ressourceTypes = new HashSet<string>();
    private List<string> _allowedTypes = new() { "document", "fetch", "xhr" };
    private Dictionary<string, IRequest> _allRequests = new Dictionary<string, IRequest>();
    public EventHandler<IRequest> OnRequestCaptured { get; set; }

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

    private async void OnPageOnResponse(object _, IResponse response)
    {
        if (string.IsNullOrEmpty(SearchTerm)) return;
        if (!_allowedTypes.Contains(response.Request.ResourceType)) return;
        Debug.WriteLine("<< " + response.Status + " " + response.Url + " ");
        if (!response.Ok) return;
        try
        {
            var body = await response.TextAsync();
            if (body.Contains(SearchTerm))
            {
                OnRequestCaptured?.Invoke(this, response.Request);
                Debug.WriteLine("good");
            }
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