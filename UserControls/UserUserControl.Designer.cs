namespace OnlineChat.UserControls
{
    partial class UserUserControl
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pb_ava = new System.Windows.Forms.PictureBox();
            this.pb_status = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(157, 58);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 20);
            this.lbl_status.TabIndex = 11;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(108, 6);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 25);
            this.lbl_name.TabIndex = 9;
            // 
            // pb_ava
            // 
            this.pb_ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ava.Location = new System.Drawing.Point(3, 3);
            this.pb_ava.Name = "pb_ava";
            this.pb_ava.Size = new System.Drawing.Size(97, 79);
            this.pb_ava.TabIndex = 8;
            this.pb_ava.TabStop = false;
            // 
            // pb_status
            // 
            this.pb_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_status.Location = new System.Drawing.Point(106, 46);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(44, 36);
            this.pb_status.TabIndex = 10;
            this.pb_status.TabStop = false;
            // 
            // UserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_ava);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pb_status);
            this.Controls.Add(this.lbl_name);
            this.Name = "UserUserControl";
            this.Size = new System.Drawing.Size(322, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.PictureBox pb_ava;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Label lbl_name;
    }
}
