namespace OnlineChat
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_forgot_password_title = new System.Windows.Forms.Label();
            this.btn_sent_password = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(12, 227);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(363, 35);
            this.tb_email.TabIndex = 4;
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // lbl_forgot_password_title
            // 
            this.lbl_forgot_password_title.AutoSize = true;
            this.lbl_forgot_password_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_forgot_password_title.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgot_password_title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_forgot_password_title.Location = new System.Drawing.Point(12, 139);
            this.lbl_forgot_password_title.Name = "lbl_forgot_password_title";
            this.lbl_forgot_password_title.Size = new System.Drawing.Size(296, 18);
            this.lbl_forgot_password_title.TabIndex = 5;
            this.lbl_forgot_password_title.Text = "Enter Email to Recover Password:";
            this.lbl_forgot_password_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_sent_password
            // 
            this.btn_sent_password.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_sent_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sent_password.Location = new System.Drawing.Point(101, 328);
            this.btn_sent_password.Name = "btn_sent_password";
            this.btn_sent_password.Size = new System.Drawing.Size(177, 47);
            this.btn_sent_password.TabIndex = 6;
            this.btn_sent_password.Text = "Sent Password";
            this.btn_sent_password.UseVisualStyleBackColor = false;
            this.btn_sent_password.Click += new System.EventHandler(this.btn_sent_password_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 41);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 415);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_sent_password);
            this.Controls.Add(this.lbl_forgot_password_title);
            this.Controls.Add(this.tb_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_forgot_password_title;
        private System.Windows.Forms.Button btn_sent_password;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}