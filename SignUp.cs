using OnlineChat.Services;
using System;
using System.Configuration;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace OnlineChat
{
    public partial class SignUp : Form
    {
        private string avarPath = "";
        private string userNameHintText;
        private string passwordHintText;
        private string emailHintText;
        private string emailExistError;
        private string createSuccessNoti;
        public SignUp()
        {
            InitializeComponent();
            avarPath = FilePathManager.GetFilePath("images") + "defaultAvatar.png";
            pb_Avatar.Image = Image.FromFile(avarPath);
        }

        private bool validateEmail(string mail)
        {
            var trimmedEmail = mail.ToString().Trim();
            try
            {
                var email = new MailAddress(trimmedEmail);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool validatePassword(string password)
        {
            if (password != null && password != "")
            {
                return true;
            }
            else { return false; }
        }
        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            if (UserServices.IsEmailExists(tb_email.Text))
            {
                MessageBox.Show(emailExistError);
                return;
            }

            UserServices.AddUser(tb_user_name.Text, tb_password.Text, tb_email.Text, avarPath);

            MessageBox.Show(createSuccessNoti);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UpdateUI()
        {
            switch (ConfigurationManager.AppSettings["Language"])
            {
                case "en":
                    btn_sign_up.Text = "Sign Up";
                    userNameHintText = "Full Name";
                    emailHintText = "Enter Email";
                    passwordHintText = "Enter Password";
                    lbl_login_title.Text = "Sign Up";
                    createSuccessNoti = "Sign Up Successfully!";
                    emailExistError = "User existed!";
                    btn_choose_ava.Text = "Choose Avatar";
                    break;

                case "vn":
                    btn_sign_up.Text = "Đăng ký";
                    userNameHintText = "Họ và tên";
                    emailHintText = "Nhập email";
                    passwordHintText = "Nhập mật khẩu";
                    lbl_login_title.Text = "Đăng ký";
                    createSuccessNoti = "Đăng ký thành công!";
                    emailExistError = "Tài khoản đã tồn tại!";
                    btn_choose_ava.Text= "Chọn Avatar";
                    break;
                default:
                    break;
            }
        }

        private void tb_user_name_Enter(object sender, EventArgs e)
        {
            if (tb_user_name.Text == userNameHintText)
            {
                tb_user_name.Text = "";
                tb_user_name.ForeColor = Color.Black;
            }
        }

        private void tb_user_name_Leave(object sender, EventArgs e)
        {
            if (tb_user_name.Text == "")
            {
                tb_user_name.Text = userNameHintText;
                tb_user_name.ForeColor = Color.Silver;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            UpdateUI();
            this.ActiveControl = null;
            tb_user_name.Text = userNameHintText;
            tb_user_name.ForeColor = Color.Silver;
            tb_email.Text = emailHintText;
            tb_email.ForeColor = Color.Silver;
            tb_password.Text = passwordHintText;
            tb_password.ForeColor = Color.Silver;
        }

        private void tb_email_Enter(object sender, EventArgs e)
        {
            if (tb_email.Text == emailHintText)
            {
                tb_email.Text = "";
                tb_email.ForeColor = Color.Black;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                tb_email.Text = emailHintText;
                tb_email.ForeColor = Color.Silver;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == passwordHintText)
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
                tb_password.PasswordChar = '*';
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = passwordHintText;
                tb_password.ForeColor = Color.Silver;
                tb_password.PasswordChar = '\0';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_choose_ava_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avarPath = openFileDialog.FileName;
                pb_Avatar.Image = Image.FromFile(avarPath);
            }
        }
    }
}
