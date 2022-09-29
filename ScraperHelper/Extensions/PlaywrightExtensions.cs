using Microsoft.Playwright;
using ScraperHelper.Models;

namespace ScraperHelper.Extensions
{
    public static class PlaywrightExtensions
    {
        public static async Task<bool> Exist(this IPage page,string selector,int timeout=500)
        {
            try
            {
                await page.Locator(selector).WaitForAsync(new LocatorWaitForOptions{Timeout = timeout,State = WaitForSelectorState.Attached});
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static async Task Fill(this IPage page,string selector,string value,int timeout=500)
        {
            try
            {
                await page.Locator(selector).FillAsync(value,new LocatorFillOptions {Timeout = timeout});
            }
            catch (Exception)
            {
                throw new KnownException($"Failed to find {selector}");
            }
        }
        public static async Task Click(this IPage page,string selector,int timeout=1000)
        {
            try
            {
                await page.Locator(selector).ClickAsync(new LocatorClickOptions {Timeout = timeout});
            }
            catch (Exception ex)
            {
                throw new KnownException($"Failed to find {selector}");
            }
        }
    }
}