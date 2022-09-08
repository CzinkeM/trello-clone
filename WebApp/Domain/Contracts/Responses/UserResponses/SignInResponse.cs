namespace WebApp.Models.Responses.UserResponse
{
    public class SignInResponse
    {
        public Guid UserId { get; set; }

        public string Token { get; set; }

        public string ExpiresAt { get; set; }
    }
}
