namespace WebApp.Settings
{
    public class ApiOptions
    {
        public string BaseUri { get; set; }
        public CardSettings Card { get; set; }

        public UserSettings User { get; set; }
    }
}