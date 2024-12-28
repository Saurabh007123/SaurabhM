using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace TrainerConsole;

public class ActionUtil
{
  

}


    public class WebUtil
{
    private static WebDriver DRIVER;
    private static WebUtil UtilObject;
    private static JSUtil JSObj;
    private static ActionUtil ActionObj;

    public static WebUtil getUtilObject()
    {
        if (UtilObject == null)
        {
            UtilObject = new WebUtil();
        }
        return UtilObject;
    }

    public WebDriver getDriver()
    {
        return DRIVER;
    }


    public static JSUtil JSWay()
    {
        if (JSObj == null)
        {
            JSObj = new JSUtil();
        }
        return JSObj;

    }

    public static ActionUtil ActionsWay()
    {
        if (ActionObj == null)
        {
            ActionObj = new ActionUtil();
        }
        return ActionObj;

    }

    public WebDriver GetWebDriver()
    {
        return DRIVER;
    }

    public void LaunchBrowser(String BrowserName)
    {
        WebDriver driver = null;
        if (BrowserName.ToLower()=="FF")
        {
            driver = new FirefoxDriver();
        }
        else if (BrowserName.ToLower() == ("CH"))
        {
            driver = new ChromeDriver();
        }
        else if (BrowserName.ToLower() == ("IE"))
        {
            driver = new InternetExplorerDriver();
        }

        DRIVER = driver;
        // DRIVER.manage().timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        //DRIVER.manage().Window.Maximize();
    }

    public void OpenURL(String URL)
    {

        DRIVER.Navigate().GoToUrl(URL);
    }

    public void OpenApp(String BrowserName, String URL)
    {
        LaunchBrowser(BrowserName);
        OpenURL(URL);

    }

    public static void input(String locator) 
    {
           WebElement WebObj = getWebElement(locator);
        // fetching the locator from sheet
          //String value = TestDataUtil.DataMap.get(locator);
           //input(WebObj, value);

}

public static void input(WebElement WebObj, String value)
{

    if (checkWebElementForAction(WebObj) == true)
    {
        WebObj.SendKeys(value);
    }
}

public static void click(String locator) 
{
    WebElement WebObj = getWebElement(locator);
            if(checkWebElementForAction(WebObj) == true)
            {
        WebObj.Click();
    }

}

public void mouseHover(String locator)
{
    WebElement WebObj = getWebElement(locator);
            if(checkWebElementForAction(WebObj) == true)
            {
        new Actions(DRIVER).MoveToElement(WebObj).Build().Perform();
    }

}

public void mouseHover(WebElement WebObj)
{

    if (checkWebElementForAction(WebObj) == true)
    {
        new Actions(DRIVER).MoveToElement(WebObj).Build().Perform();
    }

}

public void click(WebElement WebObj)
{

    if (checkWebElementForAction(WebObj) == true)
    {
        WebObj.Click();
    }

}

public void uncheckCheckBox(String locator) 
{
    WebElement WebObj = getWebElement(locator);
            if(checkWebElementForAction(WebObj) == true)
            {
        if (WebObj.Selected == true)
            WebObj.Click();
    }
}

public void CheckCheckBox(String locator)
{
    WebElement WebObj = getWebElement(locator);
            if(checkWebElementForAction(WebObj) == true)
               if(WebObj.Selected==false)
                    WebObj.Click();
}

public void selectByText(String locator, String optionalText)
{
            WebElement WebObj = getWebElement(locator);
             if(checkWebElementForAction(WebObj) == true)
             {
            SelectElement SelObj = new SelectElement(WebObj);
            SelObj.SelectByText(optionalText);
    }

}

public void SelectByIndex(String locator, int optionalIndex)
{
    WebElement WebObj = getWebElement(locator);
             if(checkWebElementForAction(WebObj) == true)
             {
            SelectElement SelObj = new SelectElement(WebObj);
            SelObj.SelectByIndex(optionalIndex);
    }

}

public void selectByValue(String locator, String optionalValue)
{
    WebElement WebObj = getWebElement(locator);
            if(checkWebElementForAction(WebObj) == true)
            {
            SelectElement SelObj = new SelectElement(WebObj);
            SelObj.SelectByValue(optionalValue);
    }

}

public static WebElement getWebElement(String locator)
{
    String []
    locArr = locator.Split("##");
    String locatorType = locArr [1];
    String locatorValue = locArr [0];
    WebElement WE = null;
            if(locatorType.ToLower() == "XP")
            {
              WE = (WebElement)DRIVER.FindElement(By.XPath(locatorValue));
            }
            else if(locatorType.ToLower() == ("CSS"))
            {
        WE = (WebElement)DRIVER.FindElement(By.CssSelector(locatorValue));
    }
            else if(locatorType.ToLower() == ("CLS"))
            {
        WE = (WebElement)DRIVER.FindElement(By.ClassName(locatorValue));
    }
            else if(locatorType.ToLower() == ("ID"))
            {
        WE = (WebElement)DRIVER.FindElement(By.Id(locatorValue));
    }
             else if(locatorType.ToLower() == ("LT"))
            {
        WE = (WebElement)DRIVER.FindElement(By.LinkText(locatorValue));
    }
            else if(locatorType.ToLower() == ("PLT"))
            {
        WE = (WebElement)DRIVER.FindElement(By.PartialLinkText(locatorValue));
    }
            else if(locatorType.ToLower() == ("TN"))
            {
        WE = (WebElement)DRIVER.FindElement(By.TagName(locatorValue));
    }
            else
            {
        Console.WriteLine("Wrong Locator Type : Please check");
    }
            return WE;

}

public void setFocusByTitle(String expTitle)
{
    //Set<String> WinHandleLst =  DRIVER.WindowHandles;
    //Iterator<String> WinHandleIT = WinHandleLst.GetEnumerator();


}

public void GetScreenShot(String DestFile)
{
        Screenshot Tss = ((ITakesScreenshot)DRIVER).GetScreenshot(); ;
        DRIVER.TakeScreenshot().SaveAsFile("file_name_string", ScreenshotImageFormat.Jpeg);
        //	FileUtils.copyFile(SrcFile, DestFile1);
    }
        
 private static Boolean checkWebElementForAction(WebElement WE)
{
    if (WE.Displayed == true)
    {
        if (WE.Enabled)
        {
            return true;
        }
        else
        {
           Console.WriteLine("Element is not clickabled");

        }
    }
    else
    {
            Console.WriteLine("Element is not Visible");
    }

    return false;
}

public static class Validate
{
    public static void validateText(String locatorName, String expValue)
    {
        WebElement WE = getWebElement(locatorName);
        	}
public static void validateText(WebElement WE, String expValue)
{
    String actText = WE.Text;
    if (actText.ToLower().Equals(expValue))
    {
                Console.WriteLine("Passed");
    }
    else
    {
                Console.WriteLine("Failed");
    }

}
public static void ValidateTextContains()
{

}

public static void ValidateEnabled()
{

}
        	
        }


    }