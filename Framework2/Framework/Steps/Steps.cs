using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Steps
{
    class Steps
    {
        IWebDriver driver;
        WebDriverWait wait;
        Pages.FirstPage firstPage;
        Pages.BookingPage bookingPage;

        public void InitBrowser()
        {
            driver = Driver.Driver.GetInstance();
            wait = Driver.Driver.GetWait();
        }

        public void CloseBrowser()
        {
            Driver.Driver.CloseBrowser();
        }

        public void SetMainData(string DepartureCity, string CityOfArrival, string DepartureDate, string DateOfArrival)
        {
            firstPage = new Pages.FirstPage(this.driver, this.wait);
            firstPage.NewMainData(DepartureCity, CityOfArrival, DepartureDate, DateOfArrival);
        }

        public void SetData(string Surname, string Name, string BirthDate, string PassportCountry, string PassportNumber, string PassportDate, string Country, string Phone, string Email)
        {
            bookingPage = new Pages.BookingPage(this.driver, this.wait);
            bookingPage.SetData(Surname, Name, BirthDate, PassportCountry, PassportNumber, PassportDate, Country, Phone, Email);
        }

        public string GetBookingPageError()
        {
            return bookingPage.GetErrorMessage();
        }

        public string GetMainPageError()
        {
            return firstPage.GetErrorMessage();
        }

    }
}
