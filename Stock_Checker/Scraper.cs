using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace Stock_Checker
{
    class Scraper
    {
        public String url;

        public Scraper(String url) {
            this.url = url;
        }



        public String Url {
            get { return url; }
            set { url = value; }
        }
        

    }
}
