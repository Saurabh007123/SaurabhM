using System;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Data;
using OpenQA.Selenium;
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
using System.Drawing.Imaging;
using System.Text.RegularExpressions;


namespace TrainerConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            WebUtil WebObj = new WebUtil();
            WebObj.OpenApp("FF", "https://gmail.com");
            //WebObj.input(" ", " ");

        }


    }
}
