namespace WebApp.Settings
{
    public class ApiSettings
    {
        public string BaseUrl { get; set; }
        public CardSettings Card { get; set; }

        public UserSettings User { get; set; }
    }
}
