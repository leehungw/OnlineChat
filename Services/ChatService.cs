using Newtonsoft.Json;
using OnlineChat.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat.Services
{
    public static class ChatService
    {
        public static string ContentDirectory = $"{Environment.CurrentDirectory}\\ChatContent\\";
        public static string MediaDirectory = $"{Environment.CurrentDirectory}\\Media\\";
        public static string IconDirectory = $"{Environment.CurrentDirectory}\\Icons\\";

        public static void SaveToFile(List<ChatContent> chats, string idFrom, string idTo)
        {
            // tao duong dan den thu muc chua noi dung chat cua nguoi gui
            string fromDirectory = $"{ContentDirectory}\\{idFrom}";
            if (!Directory.Exists(fromDirectory))
                Directory.CreateDirectory(fromDirectory);

            string json = JsonConvert.SerializeObject(chats);
            string filePath = $"{fromDirectory}\\{idTo}.json";
            File.WriteAllText(filePath, json);

        }

        internal static List<ChatContent> LoadChatContent(string idFrom, string idTo)
        {
            string filePath = $"{ContentDirectory}\\{idFrom}\\{idTo}.json";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<ChatContent> chats = JsonConvert.DeserializeObject<List<ChatContent>>(json);
                return chats == null ? new List<ChatContent>() : chats;
            }
            return new List<ChatContent>();
        }
    }
}
