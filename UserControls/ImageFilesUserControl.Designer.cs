namespace OnlineChat.UserControls
{
    partial class ImageFilesUserControl
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
            this.lb_time = new System.Windows.Forms.Label();
            this.pb_content = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_content)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(3, 145);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(100, 19);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "12:00:00 pm";
            // 
            // pb_content
            // 
            this.pb_content.BackColor = System.Drawing.Color.Transparent;
            this.pb_content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_content.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_content.Location = new System.Drawing.Point(0, 0);
            this.pb_content.Name = "pb_content";
            this.pb_content.Size = new System.Drawing.Size(180, 142);
            this.pb_content.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_content.TabIndex = 0;
            this.pb_content.TabStop = false;
            // 
            // ImageFilesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.pb_content);
            this.Name = "ImageFilesUserControl";
            this.Size = new System.Drawing.Size(180, 168);
            ((System.ComponentModel.ISupportInitialize)(this.pb_content)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_content;
        private System.Windows.Forms.Label lb_time;
    }
}
