namespace ProjectBigBang.Models.DTO
{
    public class UserDTO
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Token { get; set; }
        public string? Role { get; set; }
    }
}
