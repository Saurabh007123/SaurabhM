using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class WindowsHandle
    {
        public void windows()
        {

            ChromeDriver driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(5));
            IWebElement alertButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("button_xpath")));

            driver.Url = "";
            /* implicitly wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            /* Explicit wait using lambda expression */
            wait.Until(driver => driver.FindElement(By.Id("foo")));

            /* Handle the Current Window */
            string window = driver.CurrentWindowHandle;

            /* Handle the Multiple Windows */
            IList<string> windows = driver.WindowHandles;
            driver.SwitchTo().Window("mywindow");

            IAlert alert_win = driver.SwitchTo().Alert();

            Actions action = new Actions(driver);
            IWebElement testDrop = driver.FindElement(By.Id("testingDropdown"));
            SelectElement sE = new SelectElement(testDrop);
            
            




        }
        
    }
}
