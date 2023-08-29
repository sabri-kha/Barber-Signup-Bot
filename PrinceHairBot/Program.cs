using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PrinceHairBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver("D:\\3rdparty\\chrome\\chromedriver.exe");

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromHours(24));
            //IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("/html[1]/body[1]/div[1]/p[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[2]/div[1]/input[1]")));

            //url for form
            driver.Url = "https://www.waitlist.me/w/theprincehairsalon";

            //define elements of the form
            IWebElement nameBox = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/p[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[2]/div[1]/input[1]"));
            IWebElement phoneBox = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/p[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/input[1]"));
            IWebElement barberDropdown = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/p[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[4]/select[1]"));

            //fill textboxes
            nameBox.SendKeys("Sabri Khaled");
            phoneBox.SendKeys("6787358424");

            //simulate clicking into dropdown and selecting barber
            SelectElement select = new SelectElement(barberDropdown);
            select.SelectByValue("4  - PJ / Bajat (New location: 1905 Beaver Ruin Rd, Norcross, GA 30071)");
            barberDropdown.Click();

        }
    }
}
