namespace OnlineChat
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_login_title = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_log_in = new System.Windows.Forms.Button();
            this.lbl_DontHaveAccount = new System.Windows.Forms.Label();
            this.lb_sign_up = new System.Windows.Forms.Label();
            this.lb_forgot_password = new System.Windows.Forms.Label();
            this.lbl_language = new System.Windows.Forms.Label();
            this.cbb_Language = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 627);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1014, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_login_title
            // 
            this.lbl_login_title.AutoSize = true;
            this.lbl_login_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_title.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_login_title.Location = new System.Drawing.Point(476, 144);
            this.lbl_login_title.Name = "lbl_login_title";
            this.lbl_login_title.Size = new System.Drawing.Size(389, 34);
            this.lbl_login_title.TabIndex = 2;
            this.lbl_login_title.Text = "Log In to your account";
            this.lbl_login_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(482, 293);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(411, 35);
            this.tb_email.TabIndex = 3;
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(482, 366);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(411, 35);
            this.tb_password.TabIndex = 4;
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // btn_log_in
            // 
            this.btn_log_in.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_in.Location = new System.Drawing.Point(716, 456);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(177, 47);
            this.btn_log_in.TabIndex = 5;
            this.btn_log_in.Text = "Log In";
            this.btn_log_in.UseVisualStyleBackColor = false;
            this.btn_log_in.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // lbl_DontHaveAccount
            // 
            this.lbl_DontHaveAccount.AutoSize = true;
            this.lbl_DontHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DontHaveAccount.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DontHaveAccount.Location = new System.Drawing.Point(478, 541);
            this.lbl_DontHaveAccount.Name = "lbl_DontHaveAccount";
            this.lbl_DontHaveAccount.Size = new System.Drawing.Size(219, 21);
            this.lbl_DontHaveAccount.TabIndex = 6;
            this.lbl_DontHaveAccount.Text = "Don\'t have account?";
            // 
            // lb_sign_up
            // 
            this.lb_sign_up.AutoSize = true;
            this.lb_sign_up.BackColor = System.Drawing.Color.Transparent;
            this.lb_sign_up.Font = new System.Drawing.Font("Unispace", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sign_up.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_sign_up.Location = new System.Drawing.Point(742, 541);
            this.lb_sign_up.Name = "lb_sign_up";
            this.lb_sign_up.Size = new System.Drawing.Size(131, 21);
            this.lb_sign_up.TabIndex = 7;
            this.lb_sign_up.Text = "Sign Up now";
            this.lb_sign_up.Click += new System.EventHandler(this.lb_sign_up_Click);
            // 
            // lb_forgot_password
            // 
            this.lb_forgot_password.AutoSize = true;
            this.lb_forgot_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_forgot_password.Font = new System.Drawing.Font("Unispace", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forgot_password.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_forgot_password.Location = new System.Drawing.Point(555, 424);
            this.lb_forgot_password.Name = "lb_forgot_password";
            this.lb_forgot_password.Size = new System.Drawing.Size(127, 15);
            this.lb_forgot_password.TabIndex = 8;
            this.lb_forgot_password.Text = "Forgot password";
            this.lb_forgot_password.Click += new System.EventHandler(this.lb_forgot_password_Click);
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_language.Location = new System.Drawing.Point(449, 597);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(68, 16);
            this.lbl_language.TabIndex = 29;
            this.lbl_language.Text = "Language";
            // 
            // cbb_Language
            // 
            this.cbb_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Language.FormattingEnabled = true;
            this.cbb_Language.Items.AddRange(new object[] {
            "English",
            "Tiếng Việt"});
            this.cbb_Language.Location = new System.Drawing.Point(532, 591);
            this.cbb_Language.Name = "cbb_Language";
            this.cbb_Language.Size = new System.Drawing.Size(121, 24);
            this.cbb_Language.TabIndex = 28;
            // 
            // LogInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 627);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.lb_forgot_password);
            this.Controls.Add(this.cbb_Language);
            this.Controls.Add(this.lb_sign_up);
            this.Controls.Add(this.lbl_DontHaveAccount);
            this.Controls.Add(this.btn_log_in);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_login_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_login_title;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_log_in;
        private System.Windows.Forms.Label lbl_DontHaveAccount;
        private System.Windows.Forms.Label lb_sign_up;
        private System.Windows.Forms.Label lb_forgot_password;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.ComboBox cbb_Language;
    }
}

