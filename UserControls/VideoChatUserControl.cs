using AxWMPLib;
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
    public partial class VideoChatUserControl : UserControl
    {
        public VideoChatUserControl()
        {
            InitializeComponent();
        }

        internal void LoadData(string avaPath, string path, string time)
        {
            pb_ava.BackgroundImage = Image.FromFile(avaPath);
            mediaPlayer_content.URL = path;
            mediaPlayer_content.Ctlcontrols.stop();
            lb_sentTime.Text = time;
        }
    }
}
