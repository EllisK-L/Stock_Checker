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
            //Proxy proxy = new Proxy();
            //proxy.HttpProxy = "165.232.175.162:8080";
            //proxy.SslProxy = "165.232.175.162:8080";
            //opts.Proxy = proxy;

            IWebDriver driver = new ChromeDriver(opts);
            ArrayList GPUURLs = new ArrayList();


            driver.Navigate().GoToUrl("https://www.bestbuy.ca/en-ca/product/samsung-galaxy-watch-active-40mm-smartwatch-with-heart-rate-monitor-black/13399165");
            IWebElement checkOutButton = driver.FindElement(By.Id("test"));
            checkOutButton = checkOutButton.FindElement(By.TagName("button"));


            Random rand = new Random();
            int randRef;

            while (true) {
                //randRef = rand.Next
                Thread.Sleep(10000);
                //sold out
                if (checkOutButton.GetAttribute("class") == "button_2m0Gt primary_RXOwf addToCartButton_1op0t addToCartButton regular_23pTm disabled_LqxUL") {
                    Console.WriteLine("SOLD OUT");
                }
                //in stock
                else if (checkOutButton.GetAttribute("class") == "button_2m0Gt primary_RXOwf addToCartButton_1op0t addToCartButton regular_23pTm") {
                    Console.WriteLine("IN STOCK");
                }
            }



            //driver.Navigate().GoToUrl("https://www.iplocation.net/");

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
            */


            driver.Quit();
            

        }
    }
}
