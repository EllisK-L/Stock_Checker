using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace Stock_Checker
{
    class Program
    {
        static void Main(string[] args) {

            //setting up the options
            ChromeOptions opts = new ChromeOptions();
            Proxy proxy = new Proxy();
            proxy.HttpProxy = "173.208.235.202:3128";
            proxy.SslProxy = "173.208.235.202:3128";
            opts.Proxy = proxy;

            IWebDriver driver = new ChromeDriver(opts);
            ArrayList GPUURLs = new ArrayList();

            driver.Navigate().GoToUrl("https://www.canadacomputers.com/index.php?cPath=43&sf=:3_7,3_8,3_9,3_29,3_30,3_31,3_32&mfr=&pr=");

            driver.Navigate().GoToUrl("https://www.iplocation.net/");

            /*
            driver.FindElement(By.Name("keywords")).SendKeys("RTX 3090 ti");
            ReadOnlyCollection<IWebElement> products;
            products = driver.FindElements(By.ClassName("productImageSearch"));
            foreach(IWebElement prod in products) {
                GPUURLs.Add(prod.FindElement(By.TagName("a")).GetAttribute("href"));
            }

            //going through each URL
            foreach (String url in GPUURLs) {
                Thread.Sleep(10000);
                driver.Navigate().GoToUrl(url);
                Console.WriteLine(url);
            }
            


            driver.Quit();
            */

        }
    }
}
