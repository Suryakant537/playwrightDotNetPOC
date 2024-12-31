DotNet Playwright setup on MAC



Install dot net sdk, brew install --cask dotnet-sdk

dotnet new --list   (to get the list of runners)

dotnet new nunit -n PlaywrightTests

cd PlaywrightTests

dotnet add package Microsoft.Playwright.NUnit

playwright install

brew install --cask powershell

pwsh bin/Debug/net9.0/playwright.ps1 install

dotnet add package Microsoft.Playwright

dotnet add package Microsoft.Playwright.Testing

Install C# package for autosuggestion

