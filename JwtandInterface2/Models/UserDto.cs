﻿namespace JwtandInterface2.Controllers.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public UserInfoDto UserInfo { get; set; }
    }
}
