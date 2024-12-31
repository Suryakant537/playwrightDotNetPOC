namespace PlaywrightWithDotNet;
using Microsoft.Playwright;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        using var playwright = await Playwright.CreateAsync(); 
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless = false});
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://playwright.dev");
        await page.PauseAsync();

    }
}
