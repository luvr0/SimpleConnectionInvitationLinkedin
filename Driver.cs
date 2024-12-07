using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using Elements;

namespace Drivers
{
    public class Driver : ElementList
    {
        private EdgeDriver _webDriver;

        public string link;
        public int currentPage;

        public Driver(string link)
        {
            this.link = link;
            this.currentPage = 1;
        }

        public void InitiateDriver()
        {
            _webDriver = new EdgeDriver();
            _webDriver.Navigate().GoToUrl(this.link);
        }

        public void CloseDriver()
        {
            _webDriver.Quit();
        }

        public bool IsLoggedIn()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(60));

            try
            {
                IWebElement loginElement = wait.Until(_webDriver =>
                    _webDriver.FindElement(By.XPath(Login))
                );

                Console.WriteLine("Logged");

                return loginElement != null;
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Login timeout, try again.");
                return false;
            }
        }
        public void NextPagePeople(string keyWord, int page)
        {
            _webDriver.Navigate().GoToUrl($"https://www.linkedin.com/search/results/people/?keywords={keyWord}&origin=SWITCH_SEARCH_VERTICAL&page={page}&sid=!)8");
        }

        public void NavigateForPeople(string word)
        {

            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));

            try
            {
                IReadOnlyCollection<IWebElement> peoples = wait.Until(_webDriver =>
                    _webDriver.FindElements(By.XPath(Work))
                );

                foreach (var person in peoples)
                {
                    Console.WriteLine("Found people: " + person.Text);

                    if (ContainsString(word, person.Text))
                    {
                        InvitePerson(person);
                    }
                }
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Element people not found.");
            }
        }

        public bool ContainsString(string verify, string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            return str.Contains(verify);
        }

        public bool VerifyFinalPage()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(2));

            try
            {
                IWebElement finalPage = wait.Until(_webDriver =>
                    _webDriver.FindElement(By.XPath(FinalPage))
                );

                Console.WriteLine("Element FinalPage found.");

                return finalPage != null;
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Element FinalPage not found.");
                return false;
            }
        }

        public void InvitePerson(IWebElement driver)
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5));

            try
            {
                wait.Until(_webDriver =>
                    driver.FindElement(By.XPath(ConnectButton))
                ).Click();

                Console.WriteLine("Element ConnectButton found");

                try
                {
                    wait.Until(_webDriver =>
                        _webDriver.FindElement(By.XPath(InviteButton))
                    ).Click();

                    Console.WriteLine("Element InviteButton found");
                }
                catch
                {
                    Console.WriteLine("Element InviteButton not found");
                }

            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Element ConnectButton not found");
            }
        }
    }
}
