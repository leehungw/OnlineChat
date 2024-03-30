namespace OnlineChat.UserControls
{
    partial class IconChatUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_sentTime = new System.Windows.Forms.Label();
            this.pb_ava = new System.Windows.Forms.PictureBox();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sentTime
            // 
            this.lb_sentTime.AutoSize = true;
            this.lb_sentTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sentTime.Location = new System.Drawing.Point(3, 68);
            this.lb_sentTime.MaximumSize = new System.Drawing.Size(150, 0);
            this.lb_sentTime.Name = "lb_sentTime";
            this.lb_sentTime.Size = new System.Drawing.Size(67, 17);
            this.lb_sentTime.TabIndex = 14;
            this.lb_sentTime.Text = "Time Sent";
            // 
            // pb_ava
            // 
            this.pb_ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ava.Location = new System.Drawing.Point(360, 3);
            this.pb_ava.Name = "pb_ava";
            this.pb_ava.Size = new System.Drawing.Size(97, 79);
            this.pb_ava.TabIndex = 13;
            this.pb_ava.TabStop = false;
            // 
            // pb_icon
            // 
            this.pb_icon.BackColor = System.Drawing.Color.Transparent;
            this.pb_icon.Location = new System.Drawing.Point(280, 3);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(60, 60);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 15;
            this.pb_icon.TabStop = false;
            // 
            // IconChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.lb_sentTime);
            this.Controls.Add(this.pb_ava);
            this.Name = "IconChatUserControl";
            this.Size = new System.Drawing.Size(460, 87);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sentTime;
        private System.Windows.Forms.PictureBox pb_ava;
        private System.Windows.Forms.PictureBox pb_icon;
    }
}
