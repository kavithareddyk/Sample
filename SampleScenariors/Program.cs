using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleScenariors
{

     //Static IWebDriver driver = new ChromeDriver();
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.co.uk");

            TakeScreenshot st = new TakeScreenshot();
            st.Screenshot();
        }
    }
}
