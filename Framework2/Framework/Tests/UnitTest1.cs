using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Framework
{
    [TestFixture]
    public class UnitTest1
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void SetupTest()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void TeardownTest()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void TestEmptyDepartureCity()
        {
            steps.SetMainData("Москва", "", "2019-02-12", "2019-02-13");
            Assert.AreEqual(steps.GetMainPageError(), "Не выбран аэропорт отправления/прибытия или введен некорректно.");
        }

        [Test]
        public void TestEmptyName()
        {
            steps.SetMainData("Лондон", "Москва", "2019-02-12", "2019-02-13");
            steps.SetData("Margo", "", "10-10-1990", "ггггггггг", "122345678", "10-10-2020", "ггггггггг", "12341234567", "qwerty@mail.ru");
            Assert.AreEqual(steps.GetBookingPageError(), "Введите имя (латинскими буквами)");
        }

        [Test]
        public void TestEmptySurname()
        {
            steps.SetMainData("Лондон", "Москва", "2019-02-12", "2019-02-13");
            steps.SetData("", "Margo", "10-10-1990", "ггггггггг", "122345678", "10-10-2020", "ггггггггг", "12341234567", "qwerty@mail.ru");
            Assert.AreEqual(steps.GetBookingPageError(), "Введите фамилию (латинскими буквами)");
        }        

        [Test]
        public void TestExpiredPassport()
        {
            steps.SetMainData("Лондон", "Москва", "2019-02-12", "2019-02-13");
            steps.SetData("qwerty", "qwerty", "10-10-2018", "ггггггггг", "122345678", "10-10-2020", "ггггггггг", "12341234567", "qwerty@mail.ru");
            Assert.AreEqual(steps.GetBookingPageError(), "Взрослому пассажиру должно быть старше 12 лет (включительно)");
        }

        [Test]
        public void TestOldMan()
        {
            steps.SetMainData("Лондон", "Москва", "2019-01-12", "2019-01-13");
            steps.SetData("qwerty", "qwerty", "10-10-1869", "ггггггггг", "122345678", "10-10-2020", "ггггггггг", "12341234567", "qwerty@mail.ru");
            Assert.AreEqual(steps.GetBookingPageError(), "Введите корректную дату рождения");
        }

        [Test]
        public void TestRoundTheWorld()
        {
            steps.SetMainData("Москва", "Москва", "2019-02-12", "2019-02-13");
            Assert.AreEqual(steps.GetMainPageError(), "Пункты отправления/прибытия должны быть разными");
        }

        [Test]
        public void TestUncorrectDate()
        {
            steps.SetMainData("Москва", "Лондон", "2019-02-11", "2019-02-10");
            Assert.AreEqual(steps.GetMainPageError(), "Выбраны неверные даты");
        }

        
        [Test]
        public void TestUncorrectName()
        {
            steps.SetMainData("Лондон", "Москва", "2019-02-12", "2019-02-13");
            steps.SetData("123", "456", "10-10-1990", "ггггггггг", "122345678", "10-10-2020", "ггггггггг", "12341234567", "qwerty@mail.ru");
            Assert.AreEqual(steps.GetBookingPageError(), "Введите фамилию (латинскими буквами)");
        }

        [Test]
        public void TestUncorrectPassportDate()
        {
            steps.SetMainData("Лондон", "Москва", "2019-01-12", "2019-01-13");
            steps.SetData("qwerty", "qwerty", "10-10-1990", "ггггггггг", "122345678", "10-10-1868", "ггггггггг", "12341234567", "qwerty@mail.ru");
            Assert.AreEqual(steps.GetBookingPageError(), "Неверный формат срока документа.");
        }

        [Test]
        public void TestYoungMan()
        {
            steps.SetMainData("Минск", "Москва", "2019-02-12", "2019-02-13");
            steps.SetData("qwerty", "Virus", "10-10-2011", "ггггггггг", "122345678", "10-10-2020", "ггггггггг", "12341234567", "qwerty@mail.ru");
            Assert.AreEqual(steps.GetBookingPageError(), "Взрослому пассажиру должно быть старше 12 лет (включительно)");
        }    
    }
}
