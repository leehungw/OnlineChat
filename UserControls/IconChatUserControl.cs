using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineChat.UserControls
{
    public partial class IconChatUserControl : UserControl
    {
        public IconChatUserControl()
        {
            InitializeComponent();
        }
        internal void LoadData(string avaPath, string iconPath, string time)
        {
            pb_ava.BackgroundImage = Image.FromFile(avaPath);
            pb_icon.Image = Image.FromFile(iconPath);
            lb_sentTime.Text = time;
        }
    }
}
