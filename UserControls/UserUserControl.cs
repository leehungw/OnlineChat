using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OnlineChat.UserControls
{
    public partial class UserUserControl : UserControl
    {        
        int id;
        public int getId() {  return id; }
        public void setId(int Id) { this.id = Id; }
        public UserUserControl()
        {
            InitializeComponent();
            this.lbl_name.Click += ControlClicked;
            this.lbl_status.Click += ControlClicked;
            this.pb_ava.Click += ControlClicked;
            this.pb_status.Click += ControlClicked; 
        }
        public void LoadData(int id, string avatarPath, string name, string status)
        {
            pb_ava.BackgroundImage = Image.FromFile(avatarPath);
            if (status == "Online")
            {
                pb_status.BackgroundImage = OnlineChat.Properties.Resources.on;
            }
            else
            {
                pb_status.BackgroundImage = Properties.Resources.off;
            }
            lbl_name.Text = name;
            lbl_status.Text = status;
            this.id = id;
        }
        private void ControlClicked(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }
    }
}
