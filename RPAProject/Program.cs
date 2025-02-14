using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program {
    static void Main() {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.hotnews.ro/");

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        // ✅ Try By.Name first (preferred)
        IWebElement searchBox = wait.Until(drv => drv.FindElement(By.ClassName("input")));
        if (searchBox != null)
        {
            Console.WriteLine("Search box found!");
        }
        else
        {
            Console.WriteLine("Search box not found!");
        }

        // ✅ If needed, scroll into view
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", searchBox);

        // ✅ If still not working, use JavaScript click
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", searchBox);

        searchBox.SendKeys("Power Automate RPA" + Keys.Enter);

        Console.WriteLine("Search performed!");
    }
}