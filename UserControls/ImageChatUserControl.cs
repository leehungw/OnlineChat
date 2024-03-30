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
    public partial class ImageChatUserControl : UserControl
    {
        public ImageChatUserControl()
        {
            InitializeComponent();
        }

        public void LoadData(string avaPath, string path, string time)
        {
            pb_ava.BackgroundImage = Image.FromFile(avaPath);
            pb_content.BackgroundImage = Image.FromFile(path);
            lb_sentTime.Text = time;
        }
    }
}
