namespace OnlineChat.UserControls
{
    partial class TextChatUserControl
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
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sentTime
            // 
            this.lb_sentTime.AutoSize = true;
            this.lb_sentTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sentTime.Location = new System.Drawing.Point(3, 67);
            this.lb_sentTime.MaximumSize = new System.Drawing.Size(150, 0);
            this.lb_sentTime.Name = "lb_sentTime";
            this.lb_sentTime.Size = new System.Drawing.Size(67, 17);
            this.lb_sentTime.TabIndex = 12;
            this.lb_sentTime.Text = "Time Sent";
            // 
            // pb_ava
            // 
            this.pb_ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ava.Location = new System.Drawing.Point(360, 3);
            this.pb_ava.Name = "pb_ava";
            this.pb_ava.Size = new System.Drawing.Size(97, 79);
            this.pb_ava.TabIndex = 9;
            this.pb_ava.TabStop = false;
            // 
            // rtb_content
            // 
            this.rtb_content.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtb_content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_content.Location = new System.Drawing.Point(93, 3);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.ReadOnly = true;
            this.rtb_content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_content.Size = new System.Drawing.Size(261, 79);
            this.rtb_content.TabIndex = 13;
            this.rtb_content.Text = "123";
            // 
            // TextChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rtb_content);
            this.Controls.Add(this.lb_sentTime);
            this.Controls.Add(this.pb_ava);
            this.Name = "TextChatUserControl";
            this.Size = new System.Drawing.Size(460, 88);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ava;
        private System.Windows.Forms.Label lb_sentTime;
        private System.Windows.Forms.RichTextBox rtb_content;
    }
}
