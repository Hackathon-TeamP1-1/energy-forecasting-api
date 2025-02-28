namespace EnergyForecastingAPI.DTOs
{
    public class UserLoginDto
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
    }
}
