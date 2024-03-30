namespace OnlineChat.UserControls
{
    partial class VideoFilesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoFilesUserControl));
            this.lb_time = new System.Windows.Forms.Label();
            this.pb_play = new System.Windows.Forms.PictureBox();
            this.mediaPlayer_content = new AxWMPLib.AxWindowsMediaPlayer();
            this.pb_pause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer_content)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(3, 200);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(100, 19);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "12:00:00 pm";
            // 
            // pb_play
            // 
            this.pb_play.BackColor = System.Drawing.Color.Transparent;
            this.pb_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_play.BackgroundImage")));
            this.pb_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_play.Location = new System.Drawing.Point(66, 43);
            this.pb_play.Name = "pb_play";
            this.pb_play.Size = new System.Drawing.Size(52, 51);
            this.pb_play.TabIndex = 3;
            this.pb_play.TabStop = false;
            this.pb_play.Visible = false;
            this.pb_play.Click += new System.EventHandler(this.pb_play_Click);
            // 
            // mediaPlayer_content
            // 
            this.mediaPlayer_content.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaPlayer_content.Enabled = true;
            this.mediaPlayer_content.Location = new System.Drawing.Point(0, 0);
            this.mediaPlayer_content.Name = "mediaPlayer_content";
            this.mediaPlayer_content.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer_content.OcxState")));
            this.mediaPlayer_content.Size = new System.Drawing.Size(180, 161);
            this.mediaPlayer_content.TabIndex = 1;
            // 
            // pb_pause
            // 
            this.pb_pause.BackColor = System.Drawing.Color.Transparent;
            this.pb_pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pause.BackgroundImage")));
            this.pb_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_pause.Location = new System.Drawing.Point(66, 43);
            this.pb_pause.Name = "pb_pause";
            this.pb_pause.Size = new System.Drawing.Size(52, 51);
            this.pb_pause.TabIndex = 3;
            this.pb_pause.TabStop = false;
            this.pb_pause.Visible = false;
            this.pb_pause.Click += new System.EventHandler(this.pb_pause_Click);
            // 
            // VideoFilesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_pause);
            this.Controls.Add(this.pb_play);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.mediaPlayer_content);
            this.Name = "VideoFilesUserControl";
            this.Size = new System.Drawing.Size(180, 222);
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer_content)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer_content;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.PictureBox pb_play;
        private System.Windows.Forms.PictureBox pb_pause;
    }
}
