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


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public TextChatUserControl()
        {
            InitializeComponent();
        }

        public void LoadData(string avatarPath, string content, string time)
        {
            pb_ava.BackgroundImage = Image.FromFile(avatarPath);
            lb_sentTime.Text = time;
            rtb_content.Text = content;
            this.content = content;
        }

        public void updateTheme(Color backColor, Color foreColor)
        {
            rtb_content.BackColor = backColor;
            rtb_content.ForeColor = foreColor;
            HideCaret(rtb_content.Handle);
            rtb_content.ReadOnly = true;
        }
        public void hightlightText(string text, Color color)
        {
            deHightlightText(SystemColors.Control);
            rtb_content.Select(rtb_content.Text.IndexOf(text), text.Length);
            rtb_content.SelectionBackColor = color;
        }
        public void deHightlightText(Color color)
        {
            rtb_content.SelectionBackColor = color;
        }
    }
}
