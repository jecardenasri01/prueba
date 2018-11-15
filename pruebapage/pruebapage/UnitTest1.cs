using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using pruebapage.page;
using pruebapage.entidades;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace pruebapage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            RemoteWebDriver driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize();
            //    driver.Navigate().GoToUrl("file:///C:/Users/jcarderi/Desktop/prueba/Tiquetes%20Baratos%20-%20Tiquetes%20y%20Vuelos%20Baratos.html");
            driver.Navigate().GoToUrl("https://www.tiquetesbaratos.com/?gclid=CjwKCAiArK_fBRABEiwA0gOOcwFRJIsAj1RBS-PJT9JtQcCwl0P8r2KU3Bf3BxZAcKgBq3AslWMkrxoCc2kQAvD_BwE");


            vuelo vuelo = new vuelo();
            iniciopage inicio = new iniciopage(driver);

            vuelo.ciudadOrigen = "valle";
            vuelo.ciudadDestino = "cali";



            inicio.Buscarvuelo(vuelo);

        }
    }
}
