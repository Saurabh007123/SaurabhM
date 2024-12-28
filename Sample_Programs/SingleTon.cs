using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{

    public class Country
    {

        

        public string Id { get; set; }
        public string CountryName { get; set; }
    }
    public static class SingleTon
    {
        // encapsulation
        private static List<Country> _Countries = null;

        // Safe Iteration
        public static IEnumerable<Country> GetCountries()
        {
            // lazy loading
            if (_Countries == null)
            {
                _Countries = new List<Country>();
            }
            return _Countries;
        }
        public static void RefreshCountries()
        {
            // thread safety
            lock (_Countries)
            {
                _Countries = new List<Country>();
            }
        }
    }

    /*
     create one instance of the class and use it across the system. singleton class can be passed as a parameter.
     Normal singleton class follow the OOPS rules but not the static singleton class
     static class can not be inherited nor inherit into any other class
    cache example is the good example of 
     */

    public partial class SearchEngineMainPage
    {
        private readonly IWebDriver _driver;
        private readonly string _url = @"searchEngineUrl";
        public SearchEngineMainPage(IWebDriver browser) => _driver = browser;
        public void Navigate() => _driver.Navigate().GoToUrl(_url);
        public void Search(string textToType)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(textToType);
            GoButton.Click();
        }
    }

    public partial class SearchEngineMainPage
    {
        public IWebElement SearchBox => _driver.FindElement(By.Id("sb_form_q"));
        public IWebElement GoButton => _driver.FindElement(By.Id("sb_form_go"));
        public IWebElement ResultsCountDiv => _driver.FindElement(By.Id("b_tween"));

        
    }

    public class Utility
    {
        private static WebDriver driver = null;

        public static WebDriver DRIVER;
        public static string BrowserName = string.Empty;

        private static void Initialize(string BrowserName)
        {
            if(driver == null)
            {
                if(BrowserName.Equals("CH"))
                {
                    driver = new ChromeDriver(@"");
                }
                else if (BrowserName.Equals("FF"))
                {
                    driver = new FirefoxDriver();
                }
                else if (BrowserName.Equals("ED"))
                {
                    driver = new EdgeDriver();
                }

                
            }
            driver = DRIVER;
            MaximizeWindow();
        }

        private static void MaximizeWindow()
        {

            DRIVER.Manage().Window.Maximize();

        }

        private static void Close()
        {

            DRIVER.Close();
            DRIVER = null;

        }


    }

    public class Loginpage
    {
        private IWebDriver driver;

       // [FindsBy(How = How.LinkText, Using = "More details")]
        public IWebElement UserName { get; set; }

    }

}
