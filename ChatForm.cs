using AxWMPLib;
using Newtonsoft.Json.Linq;
using OnlineChat.Model;
using OnlineChat.Models;
using OnlineChat.Services;
using OnlineChat.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineChat
{
    public partial class ChatForm : Form
    {
        enum CurrentPage { Chat, File, Setting }
        int userLocation = 3;
        Point mouseLocation;
        DataTable dt;
        User currentUser;
        string searchInChatHint;
        int currentChatFriend;
        CurrentPage currentPage;

        List<ChatContent> chatContents = new List<ChatContent>();
        public ChatForm(User user)
        {
            this.currentUser = user;
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        }
        void LoadUser(int id)
        {
            UserUserControl userControl = new UserUserControl();
            userControl.LoadData(id,
                (string)(dt.Rows[id]["ava"]),
                (string)(dt.Rows[id]["name"]).ToString(),
                (string)(dt.Rows[id]["text"]).ToString());
            this.pn_friends_list.Controls.Add(userControl);
            userControl.Location = new Point(3, userLocation);
            userControl.Click += new System.EventHandler(this.friendControl_Click);
            userLocation += 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            UpdateLanguageUI();
            UpdateThemeUI();
            SetUpIcons();
            loadSettings();

            currentPage = CurrentPage.Chat;

            tb_searchInChat.Text = searchInChatHint;
            tb_searchInChat.ForeColor = Color.Silver;

            pn_friends_list.HorizontalScroll.Maximum = 0;
            pn_friends_list.AutoScroll = false;
            pn_friends_list.VerticalScroll.Visible = false;
            pn_friends_list.AutoScroll = true;

            uct_current_user.LoadData(currentUser.Id, currentUser.avaPath, currentUser.FullName, currentUser.Status.ToString());

            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ava", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("text", typeof(string));

            List<User> users = UserServices.LoadUsersFromFile();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id != currentUser.Id)
                {
                    dt.Rows.Add(users[i].Id, users[i].avaPath, users[i].FullName, users[i].Status);
                }
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoadUser(i);
            }

            currentChatFriend = 0;
            loadFriendInfo(currentChatFriend);
            chatContents = ChatService.LoadChatContent(currentUser.Id.ToString(), currentChatFriend.ToString());
            ReloadChatContent(chatContents);
        }

        private void loadFriendInfo(int id)
        {
            lbl_name_current_chatbox.Text = dt.Rows[id]["name"].ToString();
            lb_status_current_chatbox.Text = dt.Rows[id]["text"].ToString();
            pb_ava_current_chatbox.BackgroundImage = Image.FromFile(dt.Rows[id]["ava"].ToString());
            if (dt.Rows[id]["text"].ToString() == "Online")
            {
                pb_status_current_chatbox.BackgroundImage = OnlineChat.Properties.Resources.on;
            }
            else
            {
                pb_status_current_chatbox.BackgroundImage = Properties.Resources.off;
            }
        }

        private void friendControl_Click(object sender, EventArgs e)
        {
            UserUserControl userControl = (UserUserControl)sender;
            currentChatFriend = userControl.getId();
            loadFriendInfo(currentChatFriend);
            chatContents = ChatService.LoadChatContent(currentUser.Id.ToString(), currentChatFriend.ToString());
            if (currentPage == CurrentPage.Chat)
            {
                ReloadChatContent(chatContents);
            }
            else
            {
                filesUpdate();
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string content = tb_chatBox.Text;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            //Add Text Chat
            TextChatUserControl textChatUserControl = new TextChatUserControl();
            textChatUserControl.LoadData(currentUser.avaPath, content, time);
            fl_pn_chatBox.Controls.Add(textChatUserControl);
            fl_pn_chatBox.AutoScrollPosition = new Point(0, fl_pn_chatBox.DisplayRectangle.Height);
            tb_chatBox.Clear();

            //Save Text Chat
            ChatContent chatContent = new ChatContent(currentUser.Id.ToString(), currentChatFriend.ToString(), "Text", content, DateTime.Now);
            chatContents.Add(chatContent);
            ChatService.SaveToFile(chatContents, currentUser.Id.ToString(), currentChatFriend.ToString());
        }

        private void pn_title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pn_title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void tb_searchInChat_Enter(object sender, EventArgs e)
        {
            if (tb_searchInChat.Text == searchInChatHint)
            {
                tb_searchInChat.Text = "";
                tb_searchInChat.ForeColor = Color.Black;
            }
        }

        private void tb_searchInChat_Leave(object sender, EventArgs e)
        {
            foreach (TextChatUserControl tc in fl_pn_chatBox.Controls.OfType<TextChatUserControl>())
            {
                tc.deHightlightText(SystemColors.Control);
            }
            if (tb_searchInChat.Text == "")
            {
                tb_searchInChat.Text = searchInChatHint;
                tb_searchInChat.ForeColor = Color.Silver;
            }
        }


        private void UpdateLanguageUI()
        {
            switch (ConfigurationManager.AppSettings["Language"])
            {
                case "en":
                    tb_searchInChat.Text = tb_searchInChat.Text == searchInChatHint ? "Search..." : tb_searchInChat.Text;
                    searchInChatHint = "Search...";
                    lb_photo.Text = "Photos";
                    lb_btn_files.Text = "File";
                    lb_btn_setting.Text = "Setting";
                    lb_darkMode.Text = "Dark mode setting";
                    lb_language.Text = "Language";
                    rbtn_dark.Text = "Dark";
                    rbtn_light.Text = "Light";
                    break;

                case "vn":
                    tb_searchInChat.Text = tb_searchInChat.Text == searchInChatHint ? "Tìm kiếm..." : tb_searchInChat.Text;
                    searchInChatHint = "Tìm kiếm...";
                    lb_photo.Text = "Hình ảnh";
                    lb_btn_files.Text = "Tệp";
                    lb_btn_setting.Text = "Cài đặt";
                    lb_darkMode.Text = "Cài đặt chế độ tối";
                    lb_language.Text = "Ngôn ngữ";
                    rbtn_dark.Text = "Tối";
                    rbtn_light.Text = "Sáng";
                    break;
                default:
                    break;
            }
        }
        private void UpdateThemeUI()
        {
            switch (ConfigurationManager.AppSettings["UIMode"])
            {
                case "light":
                    this.BackColor = SystemColors.Window;
                    this.ForeColor = SystemColors.WindowText;
                    break;

                case "dark":
                    this.BackColor = SystemColors.WindowText;
                    this.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
            tb_searchInChat.BackColor = this.BackColor;
            tb_searchInChat.ForeColor = this.ForeColor;
            tb_chatBox.BackColor = this.BackColor;
            tb_chatBox.ForeColor = this.ForeColor;

        }

        private void ReloadChatContent(List<ChatContent> chatContents)
        {
            fl_pn_chatBox.Controls.Clear();
            foreach (ChatContent chatContent in chatContents)
            {
                switch (chatContent.ContentType)
                {
                    case "Text":
                        TextChatUserControl textChatUserControl = new TextChatUserControl();
                        textChatUserControl.LoadData(currentUser.avaPath, chatContent.Content, chatContent.TimeStamp.ToString("h:mm:ss tt"));
                        fl_pn_chatBox.Controls.Add(textChatUserControl);
                        break;
                    case "Image":
                        ImageChatUserControl imageChatUserControl = new ImageChatUserControl();
                        imageChatUserControl.LoadData(currentUser.avaPath, chatContent.Content, chatContent.TimeStamp.ToString("h:mm:ss tt"));
                        fl_pn_chatBox.Controls.Add(imageChatUserControl);
                        break;
                    case "Icon":
                        IconChatUserControl iconChatUserControl = new IconChatUserControl();
                        iconChatUserControl.LoadData(currentUser.avaPath, chatContent.Content, chatContent.TimeStamp.ToString("h:mm:ss tt"));
                        fl_pn_chatBox.Controls.Add(iconChatUserControl);
                        break;
                    case "Video":
                        VideoChatUserControl videoChatUserControl = new VideoChatUserControl();
                        videoChatUserControl.LoadData(currentUser.avaPath, chatContent.Content, chatContent.TimeStamp.ToString("h:mm:ss tt"));
                        fl_pn_chatBox.Controls.Add(videoChatUserControl);
                        break;
                }
            }
            fl_pn_chatBox.AutoScrollPosition = new Point(0, fl_pn_chatBox.VerticalScroll.Maximum);
        }

        private void btn_icon_Click(object sender, EventArgs e)
        {
            pn_icon.Visible = !pn_icon.Visible;
        }

        private void SetUpIcons()
        {
            pb_emo1.Image = Image.FromFile(ChatService.IconDirectory + "emo.png");
            pb_emo2.Image = Image.FromFile(ChatService.IconDirectory + "emo1.png");
            pb_emo3.Image = Image.FromFile(ChatService.IconDirectory + "emo2.png");
            pb_emo4.Image = Image.FromFile(ChatService.IconDirectory + "emo3.png");
            pb_emo5.Image = Image.FromFile(ChatService.IconDirectory + "emo4.png");
            pb_emo6.Image = Image.FromFile(ChatService.IconDirectory + "emo5.png");
            pb_emo7.Image = Image.FromFile(ChatService.IconDirectory + "emo6.png");
            pb_emo8.Image = Image.FromFile(ChatService.IconDirectory + "emo7.png");
            pb_emo9.Image = Image.FromFile(ChatService.IconDirectory + "emo8.png");

            pb_emo1.ImageLocation = ChatService.IconDirectory + "emo.png";
            pb_emo2.ImageLocation = ChatService.IconDirectory + "emo1.png";
            pb_emo3.ImageLocation = ChatService.IconDirectory + "emo2.png";
            pb_emo4.ImageLocation = ChatService.IconDirectory + "emo3.png";
            pb_emo5.ImageLocation = ChatService.IconDirectory + "emo4.png";
            pb_emo6.ImageLocation = ChatService.IconDirectory + "emo5.png";
            pb_emo7.ImageLocation = ChatService.IconDirectory + "emo6.png";
            pb_emo8.ImageLocation = ChatService.IconDirectory + "emo7.png";
            pb_emo9.ImageLocation = ChatService.IconDirectory + "emo8.png";

            foreach (Control control in pn_icon.Controls)
            {
                control.Click += Icon_Click;
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string iconPath = pictureBox.ImageLocation;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            IconChatUserControl iconChatUserControl = new IconChatUserControl();
            iconChatUserControl.LoadData(currentUser.avaPath, iconPath, time);
            fl_pn_chatBox.Controls.Add(iconChatUserControl);
            fl_pn_chatBox.AutoScrollPosition = new Point(0, fl_pn_chatBox.VerticalScroll.Maximum);


            // luu vao file
            ChatContent chatContent = new ChatContent(currentUser.Id.ToString(), currentChatFriend.ToString(), "Icon", iconPath, DateTime.Now);
            chatContents.Add(chatContent);
            ChatService.SaveToFile(chatContents, currentUser.Id.ToString(), currentChatFriend.ToString());

        }

        private void btn_sendVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mp4, *.avi, *.flv) | *.mp4; *.avi; *.flv";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string time = DateTime.Now.ToString("h:mm:ss tt");

            CopyToStorage(openFileDialog.FileNames);

            //Add video to chatbox
            foreach (string path in openFileDialog.FileNames)
            {
                VideoChatUserControl videoChatUserControl = new VideoChatUserControl();
                videoChatUserControl.LoadData(currentUser.avaPath, path, time);
                fl_pn_chatBox.Controls.Add(videoChatUserControl);
                fl_pn_chatBox.AutoScrollPosition = new Point(0, fl_pn_chatBox.VerticalScroll.Maximum);
            }

            //save to file
            foreach (string path in openFileDialog.FileNames)
            {
                ChatContent chatContent = new ChatContent(currentUser.Id.ToString(), currentChatFriend.ToString(), "Video", path, DateTime.Now);
                chatContents.Add(chatContent);
                ChatService.SaveToFile(chatContents, currentUser.Id.ToString(), currentChatFriend.ToString());
            }
        }

        private void btn_sendImage_Click(object sender, EventArgs e)
        {
            // Open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string avatarPath = currentUser.avaPath;
            string time = DateTime.Now.ToString("h:mm:ss tt");

            CopyToStorage(openFileDialog.FileNames);

            //Add Image to Chatbox
            foreach (string path in openFileDialog.FileNames)
            {
                ImageChatUserControl imageChatUserControl = new ImageChatUserControl();
                imageChatUserControl.LoadData(currentUser.avaPath, path, time);
                fl_pn_chatBox.Controls.Add(imageChatUserControl);
                fl_pn_chatBox.AutoScrollPosition = new Point(0, fl_pn_chatBox.VerticalScroll.Maximum);

            }

            foreach (string path in openFileDialog.FileNames)
            {
                ChatContent chatContent = new ChatContent(currentUser.Id.ToString(), currentChatFriend.ToString(), "Image", path, DateTime.Now);
                chatContents.Add(chatContent);
                ChatService.SaveToFile(chatContents, currentUser.Id.ToString(), currentChatFriend.ToString());
            }
        }
        private void CopyToStorage(string[] fileNames)
        {
            foreach (string path in fileNames)
            {
                string fileName = Path.GetFileName(path);
                string destPath = ChatService.MediaDirectory + fileName;
                File.Copy(path, destPath, true);
            }
        }

        private void tb_searchInChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (TextChatUserControl tc in fl_pn_chatBox.Controls.OfType<TextChatUserControl>())
                {
                    tc.deHightlightText(SystemColors.Control);
                    if (tc.getContent().Contains(tb_searchInChat.Text))
                    {
                        tc.hightlightText(tb_searchInChat.Text, Color.Yellow);
                        fl_pn_chatBox.ScrollControlIntoView(tc);
                    }
                }
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            currentPage = CurrentPage.Setting;
            pn_friend_info.Visible = false;
            pn_setting.Visible = true;
            fl_pn_chatBox.Visible = false;
            pn_chat.Visible = false;
            pn_files.Visible = false;
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            currentPage = CurrentPage.Chat;
            pn_friend_info.Visible = true;
            pn_setting.Visible = false;
            fl_pn_chatBox.Visible = true;
            pn_chat.Visible = true;
            pn_files.Visible = false;
        }

        private void btn_files_Click(object sender, EventArgs e)
        {
            currentPage = CurrentPage.File;
            pn_friend_info.Visible = true;
            pn_setting.Visible = false;
            fl_pn_chatBox.Visible = false;
            pn_chat.Visible = false;
            pn_files.Visible = true;

            filesUpdate();
        }

        private void filesUpdate()
        {
            fl_pn_photos.Controls.Clear();
            fl_pn_videos.Controls.Clear();
            foreach (ChatContent ct in chatContents)
            {
                if (ct.ContentType == "Image")
                {
                    ImageFilesUserControl pb = new ImageFilesUserControl();
                    pb.LoadData(ct.Content, ct.TimeStamp.ToString("g"));

                    fl_pn_photos.Controls.Add(pb);
                }
                else if (ct.ContentType == "Video")
                {

                    VideoFilesUserControl mediaPlayer = new VideoFilesUserControl();
                    mediaPlayer.LoadData(ct.Content, ct.TimeStamp.ToString("g"));
                    fl_pn_videos.Controls.Add(mediaPlayer);

                }
            }
        }

        private void loadSettings()

        {
            if (ConfigurationManager.AppSettings["UIMode"] == "light")
            {
                rbtn_light.Checked = true;
            }
            else
            {
                rbtn_dark.Checked = true;
            }

            if (ConfigurationManager.AppSettings["Language"] == "vn")
            {
                rbtn_vietnamese.Checked = true;
            }
            else
            {
                rbtn_english.Checked = true;
            }

            rbtn_dark.CheckedChanged += rbtn_UIMode_CheckedChanged;
            rbtn_light.CheckedChanged += rbtn_UIMode_CheckedChanged;
            rbtn_english.CheckedChanged += rbtn_language_CheckedChanged;
            rbtn_vietnamese.CheckedChanged += rbtn_language_CheckedChanged;
        }

        private void rbtn_UIMode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    if (rb.Name == "rbtn_light")
                    {
                        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["UIMode"].Value = "light";
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                        UpdateThemeUI();
                    }
                    else
                    {
                        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["UIMode"].Value = "dark";
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                        UpdateThemeUI();
                    }
                }
            }
        }

        private void rbtn_language_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    if (rb.Name == "rbtn_english")
                    {
                        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["Language"].Value = "en";
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                        UpdateLanguageUI();
                    }
                    else
                    {
                        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["Language"].Value = "vn";
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                        UpdateLanguageUI();
                    }
                }
            }
        }
    }
}
