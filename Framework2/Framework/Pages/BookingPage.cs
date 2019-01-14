using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    class BookingPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "cheapest_price")]
        private IWebElement cheapestPrice;

        [FindsBy(How = How.ClassName, Using = "book_surname")]
        private IWebElement touristSurname;

        [FindsBy(How = How.ClassName, Using = "book_name")]
        private IWebElement touristName;

        [FindsBy(How = How.ClassName, Using = "book_birth_date")]
        private IWebElement touristBirthDate;

        [FindsBy(How = How.ClassName, Using = "book_country")]
        private IWebElement nationality;

        [FindsBy(How = How.ClassName, Using = "book_number")]
        private IWebElement passportID;

        [FindsBy(How = How.ClassName, Using = "book_doc_exp_date")]
        private IWebElement passportLimit;

        [FindsBy(How = How.XPath, Using = "//*[@id='booking_form']/div[1]/div[3]/div[3]/label[2]")]
        private IWebElement touristGender;

        [FindsBy(How = How.Id, Using = "country")]
        private IWebElement touristCountry;

        [FindsBy(How = How.ClassName, Using = "book_phone")]
        private IWebElement touristPhone;

        [FindsBy(How = How.ClassName, Using = "book_email")]
        private IWebElement touristEmail;

        [FindsBy(How = How.XPath, Using = "//*[@id='booking_form']/div[8]/div[1]/label")]
        private IWebElement bookingAgreeBtn;

        [FindsBy(How = How.ClassName, Using = "btn-action-large")]
        private IWebElement bookingButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[1]/div[2]/div[1]/div[2]/div/div/div[3]")]
        private IWebElement errorMessage;

        public BookingPage(IWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
            PageFactory.InitElements(Driver, this);
        }

        public string GetErrorMessage()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(errorMessage));
            return errorMessage.Text;
        }

        public void SetData(string Surname, string Name, string BirthDate, string Nationality, string PassportID, string PassportLimit, string Country, string Phone, string Email)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(cheapestPrice));
            cheapestPrice.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(touristSurname));
            touristSurname.SendKeys(Surname + Keys.Enter);
            touristName.SendKeys(Name + Keys.Enter);
            touristBirthDate.SendKeys(BirthDate + Keys.Enter);
            touristGender.Click();
            nationality.SendKeys(Nationality + Keys.Enter);
            passportID.SendKeys(PassportID + Keys.Enter);
            passportLimit.SendKeys(PassportLimit + Keys.Enter);
            touristCountry.SendKeys(Country + Keys.Enter);
            touristPhone.SendKeys(Phone + Keys.Enter);
            touristEmail.SendKeys(Email + Keys.Enter);
            wait.Until(ExpectedConditions.ElementToBeClickable(bookingAgreeBtn));
            bookingAgreeBtn.Click();
            bookingButton.Click();
        }
    }
}
