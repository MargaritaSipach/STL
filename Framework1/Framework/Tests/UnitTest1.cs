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

    }
}
