using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Selenium.WebDriver.WaitExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebapage.comun
{
    
        public class comun
        {
            public static void esperar(RemoteWebDriver driver)
            {

                IWebElement esperar = driver.FindElementById("onesignal-popover-cancel-button");
                if (esperar != null)
                {
                    esperar.Wait(900 * 100).ForElement().ToBeVisible();
                }

            }
        }
    
}
