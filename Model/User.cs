using OnlineChat.Services;
using System;

namespace OnlineChat.Models
{
    public class User
    {
        public enum UserStatus
        {
            Online,
            Offline,
            Away,
            Busy
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string avaPath { get; set; }
        public UserStatus Status { get; set; }

        public User()
        {
            Status = UserStatus.Online;
            FullName = "Unknown";
            Password = "Unknown";
            Email = "Unknown";
            avaPath = FilePathManager.GetFilePath("images") + "defaultAvatar.png";
        }

        public User(string fullName, string password, string email, string pathToAvatar)
        {
            FullName = fullName;
            Password = password;
            Email = email;
            avaPath = pathToAvatar;
            Status = GetRandomStatus();
        }
        private UserStatus GetRandomStatus()
        {
            Array values = Enum.GetValues(typeof(UserStatus));
            Random random = new Random();
            return (UserStatus)values.GetValue(random.Next(values.Length));
        }
    }
}
