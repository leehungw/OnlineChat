namespace OnlineChat.UserControls
{
    partial class VideoChatUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoChatUserControl));
            this.lb_sentTime = new System.Windows.Forms.Label();
            this.pb_ava = new System.Windows.Forms.PictureBox();
            this.mediaPlayer_content = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer_content)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sentTime
            // 
            this.lb_sentTime.AutoSize = true;
            this.lb_sentTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sentTime.Location = new System.Drawing.Point(3, 251);
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
            // mediaPlayer_content
            // 
            this.mediaPlayer_content.Enabled = true;
            this.mediaPlayer_content.Location = new System.Drawing.Point(90, 3);
            this.mediaPlayer_content.Name = "mediaPlayer_content";
            this.mediaPlayer_content.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer_content.OcxState")));
            this.mediaPlayer_content.Size = new System.Drawing.Size(264, 209);
            this.mediaPlayer_content.TabIndex = 15;
            // 
            // VideoChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mediaPlayer_content);
            this.Controls.Add(this.lb_sentTime);
            this.Controls.Add(this.pb_ava);
            this.Name = "VideoChatUserControl";
            this.Size = new System.Drawing.Size(460, 268);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer_content)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sentTime;
        private System.Windows.Forms.PictureBox pb_ava;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer_content;
    }
}
