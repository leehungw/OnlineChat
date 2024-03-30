using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineChat.UserControls
{
    public partial class VideoFilesUserControl : UserControl
    {
        public VideoFilesUserControl()
        {
            InitializeComponent();
        }

        public void LoadData(string path, string time)
        {
            mediaPlayer_content.URL = path;
            mediaPlayer_content.Ctlcontrols.stop();
            lb_time.Text = time;
        }

        //private void triggerPlayButton()
        //{
        //    if (mediaPlayer_content.playState == WMPLib.WMPPlayState.wmppsPlaying)
        //    {
        //        pb_play.Visible = false;
        //        pb_pause.Visible = true;
        //    }
        //    else
        //    {
        //        pb_play.Visible = true;
        //        pb_pause.Visible = false;
        //    }
        //}

        //private void VideoFilesUserControl_MouseMove(object sender, MouseEventArgs e)
        //{
        //    Point pt = new Point(e.X, e.Y);
        //    if (this.ClientSize.Width >= pt.X &&
        //                    this.ClientSize.Height >= pt.Y &&
        //                    pt.X > 0 && pt.Y > 0)
        //    {
        //        this.triggerPlayButton();
        //    }
        //}

        private void pb_pause_Click(object sender, EventArgs e)
        {
            mediaPlayer_content.Ctlcontrols.pause();
        }

        private void pb_play_Click(object sender, EventArgs e)
        {
            mediaPlayer_content.Ctlcontrols.play();
        }
    }
}
