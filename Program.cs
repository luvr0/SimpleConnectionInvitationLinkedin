using Drivers;
class Program
{
    public static void Main()
    {
        Driver driver = new Driver("https://www.linkedin.com/");
        driver.InitiateDriver();

        if (!driver.IsLoggedIn())
        {
            return;
        }

        while (!driver.VerifyFinalPage())
        {
            driver.NextPagePeople("Back-end", driver.currentPage);
            driver.NavigateForPeople("Atual");
            driver.currentPage++;
        }

        driver.CloseDriver();

    }
}


