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
    public partial class ImageFilesUserControl : UserControl
    {
        public ImageFilesUserControl()
        {
            InitializeComponent();
        }

        public void LoadData(string path, string time)
        {
            pb_content.Image = Image.FromFile(path);
            lb_time.Text = time;
        }
    }
}
