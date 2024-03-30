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
            this.roundedTb1 = new BaiThucHanh1.UserControls.RoundedTb();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sentTime
            // 
            this.lb_sentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sentTime.AutoSize = true;
            this.lb_sentTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sentTime.Location = new System.Drawing.Point(3, 129);
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
            // roundedTb1
            // 
            this.roundedTb1.AutoSize = true;
            this.roundedTb1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.roundedTb1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedTb1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedTb1.BorderRadius = 8;
            this.roundedTb1.BorderSize = 1;
            this.roundedTb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundedTb1.Location = new System.Drawing.Point(103, 4);
            this.roundedTb1.Margin = new System.Windows.Forms.Padding(4);
            this.roundedTb1.Multiline = true;
            this.roundedTb1.Name = "roundedTb1";
            this.roundedTb1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedTb1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.roundedTb1.Size = new System.Drawing.Size(250, 35);
            this.roundedTb1.TabIndex = 14;
            this.roundedTb1.Texts = "";
            this.roundedTb1.UnderlinedStyle = false;
            // 
            // TextChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedTb1);
            this.Controls.Add(this.lb_sentTime);
            this.Controls.Add(this.pb_ava);
            this.Name = "TextChatUserControl";
            this.Size = new System.Drawing.Size(460, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ava;
        private System.Windows.Forms.Label lb_sentTime;
        private BaiThucHanh1.UserControls.RoundedTb roundedTb1;
    }
}
