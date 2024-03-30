using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat.Model
{
    public class ChatContent
    {
        public string IdFrom { get; set; }
        public string IdTo { get; set; }
        public enum ContentTypeList
        {
            Text,
            Image,
            Video,
            Icon
        }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public ChatContent(string from, string to, string contentType, string content, DateTime time)
        {
            IdFrom = from;
            IdTo = to;
            ContentType = contentType;
            Content = content;
            TimeStamp = time;
        }
    }
}
