using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    class FirstPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        private readonly string url = "https://www.chocotravel.com/";

        [FindsBy(How = How.Id, Using = "city_1_user")]
        private IWebElement departureCity;

        [FindsBy(How = How.Id, Using = "city_2_user")]
        private IWebElement cityOfArrival;

        [FindsBy(How = How.Id, Using = "fir_date_mobile")]
        private IWebElement departureDate;

        [FindsBy(How = How.Id, Using = "sec_date_mobile")]
        private IWebElement dateOfArrival;

        [FindsBy(How = How.ClassName, Using = "psngrs_type")]
        private IWebElement passengersType;
                
        [FindsBy(How = How.ClassName, Using = "search-form__button_search__mobile")]
        private IWebElement buttonSearch;

        [FindsBy(How = How.XPath, Using = "//*[@id='win2']/div/div[2]/div[2]")]
        private IWebElement errorMessage;

        public FirstPage(IWebDriver Driver, WebDriverWait Wait)
        {
            this.driver = Driver;
            wait = Wait;
            PageFactory.InitElements(Driver, this);
        }

        public string GetErrorMessage()
        {
            return errorMessage.Text;
        }
                
        public void NewMainData(string DepartureCity, string CityOfArrival, string DepartureDate, string DateOfArrival)
        {
            driver.Navigate().GoToUrl(this.url);
            wait.Until(ExpectedConditions.ElementToBeClickable(departureCity));
            departureCity.SendKeys(DepartureCity + Keys.Enter);
            cityOfArrival.SendKeys(CityOfArrival + Keys.Enter);
            departureDate.SendKeys(DepartureDate + Keys.Enter);
            dateOfArrival.SendKeys(DateOfArrival + Keys.Enter);
            passengersType.Click();
            buttonSearch.Click();
        }
    }
}
