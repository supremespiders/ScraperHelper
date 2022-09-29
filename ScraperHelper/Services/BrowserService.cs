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
    public  EventHandler<string> OnXpathChanged { get; set; }
    private string _lastXpath { get; set; }
    
    public async Task StartBrowser(bool headless,string url)
    {
        Notifier.Display("Starting browser");
        _playwright = await Playwright.CreateAsync();
        Directory.CreateDirectory("temp");
        var userDataDir = $"{_path}/tmp";
        _browser = await _playwright.Chromium.LaunchPersistentContextAsync(userDataDir,new BrowserTypeLaunchPersistentContextOptions()
        {
            Headless = headless,
            Args = new []{$"--disable-extensions-except={_path}/ext"} //$"--load-extension={_path}/ext", ,{_path}/ext2
        });
      //  var context = await _browser.NewContextAsync();
        _page = _browser.Pages[0];
        Notifier.Display("browser started");
        await _page.GotoAsync(url);
        if(m_GlobalHook==null)
            Subscribe();
    }
    
    public async Task Attach()
    {
        Notifier.Display("attaching to browser");
        _playwright = await Playwright.CreateAsync();
        var b = await _playwright.Chromium.ConnectOverCDPAsync("http://localhost:9222", new BrowserTypeConnectOverCDPOptions());
        _browser = b.Contexts[0];
        _page = _browser.Pages[0];
        Notifier.Display("Attached");
        if(m_GlobalHook==null)
            Subscribe();
    }
    
    public async Task Dispose()
    {
        if (_browser == null) return;
        await _browser.DisposeAsync();
        _playwright.Dispose();
        Unsubscribe();
    }

    private void Unsubscribe()
    {
        m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
        m_GlobalHook.Dispose();
    }

    private void Subscribe()
    {
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
            OnXpathChanged?.Invoke(this,t);
        }
        // uncommenting the following line will suppress the middle mouse button click
        // if (e.Buttons == MouseButtons.Middle) { e.Handled = true; }
    }
}

