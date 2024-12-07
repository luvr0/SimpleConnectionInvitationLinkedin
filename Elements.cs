
namespace Elements
{
    public class ElementList
    {
        public string Work;
        public string Login;
        public string FinalPage;
        public string ConnectButton;
        public string InviteButton;

        public ElementList()
        {
            this.Login = "//header[@id='global-nav']";
            this.Work = "//p[contains(@class, 'XBCKjEEFZVaBfRYPQWcjqHZDizrjqPb')]";
            this.FinalPage = "/html/body/div[6]/div[3]/div[2]/div/div[1]/main/div/div/div[1]/section/h2";
            this.ConnectButton = ".//ancestor::div[1]/following-sibling::div/div/button";
            this.InviteButton = "//button[@aria-label='Enviar convite']";
        }

    }

}
