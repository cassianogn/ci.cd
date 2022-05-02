using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace cicd.teste.selenium
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private readonly IWebDriver browser = WebDriverFactory.CreateWebDriver();
        public WebDriverWait WaitRapido;
        public Feature1StepDefinitions()
        {
            WaitRapido = new WebDriverWait(browser, TimeSpan.FromSeconds(5));
        }
        [Given(@"O browser é aberto")]
        public void GivenOBrowserEAberto()
        {
            browser.Navigate().GoToUrl("https://localhost:7073" + "/swagger/index.html");
        }

        [When(@"carregar a tela")]
        public void WhenCarregarATela()
        {
            var element = WaitRapido.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"operations-tag-WeatherForecast\"]/a/span")));
            var teste = element.Text;
            Assert.Equal("WeatherForecast", teste);
        }

        [Then(@"o valor teste deve estrar lá")]
        public void ThenOValorTesteDeveEstrarLa()
        {
            
        }
    }
}
