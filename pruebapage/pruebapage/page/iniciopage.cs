using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using pruebapage.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebapage.page
{
    class iniciopage
    {
         
        private RemoteWebDriver driver;

        public iniciopage(RemoteWebDriver driver) => this.driver = driver;



        private IWebElement txtciudadOrigen => driver.FindElement(By.Id("ptags1"));
        private IWebElement txtciudadDestino => driver.FindElement(By.Id("ptags2"));
        private IWebElement btnsalir => driver.FindElement(By.Id("onesignal-popover-cancel-button"));


        public void Buscarvuelo(vuelo vuelo)
        {
            comun.comun.esperar(driver);

            AceptarAlerta();
            escribirCiudadOrigen(vuelo.ciudadOrigen);
            escribirCiudadDestino(vuelo.ciudadDestino);
        }


        private void escribirCiudadOrigen(string ciudadOrigen)
        {
            txtciudadOrigen.Click();
            txtciudadOrigen.SendKeys(ciudadOrigen);
        }
        private void escribirCiudadDestino(string ciudadDestino)
        {
            txtciudadDestino.Click();
            txtciudadDestino.SendKeys(ciudadDestino);
        }


        public void AceptarAlerta()
        {

            if ((btnsalir == null) && (btnsalir.Displayed))
            {
                System.Threading.Thread.Sleep(15000);
            }
            else if ((btnsalir != null))
            {
                btnsalir.Click();
            }

        }
    }
}

