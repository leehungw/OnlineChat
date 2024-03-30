using OnlineChat.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace OnlineChat.Services
{
    public static class UserServices
    {
        public static string filePath = FilePathManager.GetFilePath("users");

        public static void SaveToFile(List<User> users, string filePath)
        {
            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText(filePath, json);
        }


        public static void AddUser(string fullName, string password, string email, string avaPath)
        {
            List<User> users = LoadUsersFromFile();
            User user = new User(fullName, password, email, avaPath);
            user.Id = users.Count();
            users.Add(user);
            SaveToFile(users, filePath);
        }

        public static List<User> LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                return users == null ? new List<User>() : users;
            }
            return new List<User>();
        }

        public static bool IsUserExists(string email, string password)
        {
            List<User> users = LoadUsersFromFile();
            return users.Any(u => u.Email == email && u.Password == password);
        }

        public static User Login(string email, string password)
        {
            List<User> users = LoadUsersFromFile();
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public static bool IsEmailExists(string email)
        {
            List<User> users = LoadUsersFromFile();
            return users.Any(u => u.Email == email);
        }

        public static User GetUserByEmail(string email)
        {
            List<User> users = LoadUsersFromFile();
            return users.FirstOrDefault(u => u.Email == email);
        }
        public static void UpdatePassword(string email, string newPassword)
        {
            List<User> users = LoadUsersFromFile();
            User user = users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                user.Password = newPassword;
                SaveToFile(users, filePath);
            }
            else
            {
                MessageBox.Show(ConfigurationManager.AppSettings["Language"] == "en" ? "User Doesn't Exist!" : "Tài khoản không tồn tại!");
            }
        }
    }
}
