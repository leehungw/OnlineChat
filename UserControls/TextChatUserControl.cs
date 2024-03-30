using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineChat.UserControls
{
    public partial class TextChatUserControl : UserControl
    {
        string content;
        public string getContent() { return content; }
        public void setContent(string content) { this.content = content; }

        public TextChatUserControl()
        {
            InitializeComponent();
        }

        public void LoadData(string avatarPath, string content, string time)
        {
            pb_ava.BackgroundImage = Image.FromFile(avatarPath);
            lb_sentTime.Text = time;
            this.content = content;
            roundedTb1.Texts = content;
            roundedTb1.BorderColor = Color.Blue;
            roundedTb1.BorderRadius = 5;
        }

        public void hightlightText(string text, Color color)
        {
            deHightlightText(SystemColors.Control);
            roundedTb1.Select(roundedTb1.Texts.IndexOf(text), text.Length);
            roundedTb1.SelectionBackColor = color;
        }
        public void deHightlightText(Color color)
        {
            roundedTb1.SelectionBackColor = color;
        }
    }
}
