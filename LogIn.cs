using OnlineChat.Models;
using OnlineChat.Services;
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
    public partial class LogInForm : Form
    {

        private string passwordHintText;
        private string emailHintText;
        private string logInFailedNoti;
        public LogInForm()
        {
            InitializeComponent();
            cbb_Language.SelectedItem = ConfigurationManager.AppSettings["Language"] == "en" ? "English" : "Tiếng Việt";
            cbb_Language.SelectedIndexChanged += cbb_Language_SelectedIndexChanged;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            User user = UserServices.Login(email, password);
            if (user != null)
            {
                Hide();
                ChatForm home = new ChatForm(user);
                home.Show();
            }
            else
            {
                MessageBox.Show(logInFailedNoti);
            }
        }

        private void lb_sign_up_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            this.Hide();
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
        private void UpdateUI(string lang)
        {
            switch (lang)
            {
                case "en":
                    btn_log_in.Text = "LOG IN";
                    tb_email.Text = tb_email.Text == "Nhập Email" ? "Enter Email" : tb_email.Text;
                    emailHintText = "Enter Email";
                    tb_password.Text = tb_password.Text == "Nhập Password" ? "Enter Password" : tb_password.Text;
                    passwordHintText = "Enter Password";
                    lbl_login_title.Text = "Log In To Your Account";
                    lb_forgot_password.Text = "Forgot Password";
                    logInFailedNoti = "Wrong email or password!";
                    lbl_DontHaveAccount.Text = "Don't Have Account?";
                    lb_sign_up.Text = "Sign Up now";
                    lbl_language.Text = "Language";
                    break;

                case "vn":
                    btn_log_in.Text = "ĐĂNG NHẬP";
                    tb_email.Text = tb_email.Text == "Enter Email" ? "Nhập Email" : tb_email.Text;
                    emailHintText = "Nhập Email";
                    tb_password.Text = tb_password.Text == "Enter Password" ? "Nhập Password" : tb_password.Text;
                    passwordHintText = "Nhập Password";
                    lbl_login_title.Text = "Đăng Nhập Vào Tài Khoản Của Bạn";
                    lb_forgot_password.Text = "Quên Mật Khẩu";
                    logInFailedNoti = "Sai tài khoản hoặc mật khẩu";
                    lbl_DontHaveAccount.Text = "Không có tài khoản?";
                    lb_sign_up.Text = "Đăng Kí ngay";
                    lbl_language.Text = "Ngôn ngữ";
                    break;
                default:
                    break;
            }
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

        private void cbb_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = cbb_Language.SelectedItem.ToString() == "English" ? "en" : "vn";
            //if (ConfigurationManager.AppSettings["Language"] == selectedLanguage)
            //    return;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            switch (selectedLanguage)
            {
                case "en":
                    config.AppSettings.Settings["Language"].Value = "en";
                    config.Save(ConfigurationSaveMode.Modified);
                    break;
                case "vn":
                    config.AppSettings.Settings["Language"].Value = "vn";
                    config.Save(ConfigurationSaveMode.Modified);
                    break;
                default:
                    break;
            }
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

            UpdateUI(selectedLanguage);
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            UpdateUI(ConfigurationManager.AppSettings["Language"]);
            tb_email.Text = emailHintText;
            tb_email.ForeColor = Color.Silver;
            tb_password.Text = passwordHintText;
            tb_password.ForeColor = Color.Silver;
            tb_password.PasswordChar = '\0';
        }

        private void lb_forgot_password_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }
    }
}
