using OnlineChat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineChat.Models;
using System.Configuration;

namespace OnlineChat
{
    public partial class ForgotPassword : Form
    {
        string emailHintText;
        string emailNotExistError;
        string emailSentSuccessNoti;
        public ForgotPassword()
        {
            InitializeComponent();
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
        private void UpdateUI()
        {
            switch (ConfigurationManager.AppSettings["Language"])
            {
                case "en":
                    lbl_forgot_password_title.Text = "Enter Email to Recover Password:";
                    emailHintText = "Enter Email";
                    btn_sent_password.Text = "Send Password";
                    emailNotExistError = "Email Doesn't Exist!";
                    emailSentSuccessNoti = "Email Sent Successfully! Check your email for the password!";
                    break;

                case "vn":
                    lbl_forgot_password_title.Text = "Nhập email để khôi phục mật khẩu:";
                    emailHintText = "Nhập email";
                    btn_sent_password.Text = "Gửi Mật Khẩu";
                    emailNotExistError = "Email không tồn tại!";
                    emailSentSuccessNoti = "Gửi email thành công! Kiểm tra hòm thư của bạn!";
                    break;
                default:
                    break;
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            UpdateUI();
            tb_email.Text = emailHintText;
            tb_email.ForeColor = Color.Silver;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sent_password_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UserServices.IsEmailExists(tb_email.Text))
                {
                    MessageBox.Show(emailNotExistError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string password = GetOldPassword(tb_email.Text);

                //nguoi gui
                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("hungttalop14@gmail.com");
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "slljqdbmtixortku");
                smtp.Host = "smtp.gmail.com";

                //nguoi nhan
                mail.To.Add(new MailAddress(tb_email.Text));
                mail.IsBodyHtml = true;
                mail.Subject = "Password Recovery";
                mail.Body = $"Your forgotten password is: {password}";


                smtp.Send(mail);
                UserServices.UpdatePassword(tb_email.Text, password);
                MessageBox.Show(emailSentSuccessNoti, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetOldPassword(string texts)
        {
            User user = UserServices.GetUserByEmail(texts);
            return user.Password;
        }
    }
}
