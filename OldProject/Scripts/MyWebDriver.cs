using System.Threading;
using System.Data.Common;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Xml.XPath;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace TrainerConsole
{
    public interface MyWebDriver
    {
        public void get();
        public void close();
        public void getTitle();
        public void findElement(string url);
    }
}