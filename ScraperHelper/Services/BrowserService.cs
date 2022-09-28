using Microsoft.Playwright;

namespace ScraperHelper.Services;

public class BrowserService
{
    private IPlaywright _playwright;
    private IBrowserContext _browser;
    private IPage _page;
    private readonly string _path = AppDomain.CurrentDomain.BaseDirectory;
    
    public async Task StartBrowser(bool headless)
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
        _page = await _browser.NewPageAsync();
        Notifier.Display("browser started");
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
        await _browser.DisposeAsync();
        _playwright.Dispose();
    }
}

