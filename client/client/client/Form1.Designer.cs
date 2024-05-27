namespace client
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.MessageArea = new System.Windows.Forms.TextBox();
            this.ChatArea = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FilePathArea = new System.Windows.Forms.TextBox();
            this.MonitorFileSharingArea = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DirectoryListBox = new System.Windows.Forms.ListView();
            this.RequestDirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryArea = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.StopVideoButton = new System.Windows.Forms.Button();
            this.StartVideoButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RequestFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.RecieveImageButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GoButton);
            this.groupBox1.Controls.Add(this.MessageArea);
            this.groupBox1.Controls.Add(this.ChatArea);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 521);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(411, 466);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(74, 49);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MessageArea
            // 
            this.MessageArea.Location = new System.Drawing.Point(6, 466);
            this.MessageArea.Multiline = true;
            this.MessageArea.Name = "MessageArea";
            this.MessageArea.Size = new System.Drawing.Size(399, 49);
            this.MessageArea.TabIndex = 1;
            // 
            // ChatArea
            // 
            this.ChatArea.Location = new System.Drawing.Point(6, 21);
            this.ChatArea.Multiline = true;
            this.ChatArea.Name = "ChatArea";
            this.ChatArea.Size = new System.Drawing.Size(479, 439);
            this.ChatArea.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FilePathArea);
            this.groupBox2.Controls.Add(this.MonitorFileSharingArea);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(518, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitoring File Sharing";
            // 
            // FilePathArea
            // 
            this.FilePathArea.Location = new System.Drawing.Point(6, 21);
            this.FilePathArea.Multiline = true;
            this.FilePathArea.Name = "FilePathArea";
            this.FilePathArea.Size = new System.Drawing.Size(310, 34);
            this.FilePathArea.TabIndex = 3;
            // 
            // MonitorFileSharingArea
            // 
            this.MonitorFileSharingArea.Location = new System.Drawing.Point(6, 61);
            this.MonitorFileSharingArea.Multiline = true;
            this.MonitorFileSharingArea.Name = "MonitorFileSharingArea";
            this.MonitorFileSharingArea.Size = new System.Drawing.Size(353, 206);
            this.MonitorFileSharingArea.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 302);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DirectoryListBox);
            this.groupBox4.Controls.Add(this.RequestDirectoryButton);
            this.groupBox4.Controls.Add(this.DirectoryArea);
            this.groupBox4.Location = new System.Drawing.Point(524, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 252);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monitoring Directory Info";
            // 
            // DirectoryListBox
            // 
            this.DirectoryListBox.HideSelection = false;
            this.DirectoryListBox.Location = new System.Drawing.Point(6, 61);
            this.DirectoryListBox.Name = "DirectoryListBox";
            this.DirectoryListBox.Size = new System.Drawing.Size(347, 181);
            this.DirectoryListBox.TabIndex = 9;
            this.DirectoryListBox.UseCompatibleStateImageBehavior = false;
            // 
            // RequestDirectoryButton
            // 
            this.RequestDirectoryButton.Location = new System.Drawing.Point(316, 21);
            this.RequestDirectoryButton.Name = "RequestDirectoryButton";
            this.RequestDirectoryButton.Size = new System.Drawing.Size(37, 34);
            this.RequestDirectoryButton.TabIndex = 8;
            this.RequestDirectoryButton.Text = "Go";
            this.RequestDirectoryButton.UseVisualStyleBackColor = true;
            this.RequestDirectoryButton.Click += new System.EventHandler(this.RequestDirectoryButton_Click);
            // 
            // DirectoryArea
            // 
            this.DirectoryArea.Location = new System.Drawing.Point(6, 21);
            this.DirectoryArea.Multiline = true;
            this.DirectoryArea.Name = "DirectoryArea";
            this.DirectoryArea.Size = new System.Drawing.Size(304, 34);
            this.DirectoryArea.TabIndex = 4;
            this.DirectoryArea.TextChanged += new System.EventHandler(this.DirectoryArea_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ImageBox);
            this.groupBox5.Controls.Add(this.StopVideoButton);
            this.groupBox5.Controls.Add(this.StartVideoButton);
            this.groupBox5.Location = new System.Drawing.Point(904, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(505, 359);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Video Streaming";
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(6, 21);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(493, 273);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 10;
            this.ImageBox.TabStop = false;
            // 
            // StopVideoButton
            // 
            this.StopVideoButton.Location = new System.Drawing.Point(322, 300);
            this.StopVideoButton.Name = "StopVideoButton";
            this.StopVideoButton.Size = new System.Drawing.Size(132, 44);
            this.StopVideoButton.TabIndex = 8;
            this.StopVideoButton.Text = "Stop";
            this.StopVideoButton.UseVisualStyleBackColor = true;
            this.StopVideoButton.Click += new System.EventHandler(this.StopVideoButton_Click);
            // 
            // StartVideoButton
            // 
            this.StartVideoButton.Location = new System.Drawing.Point(29, 300);
            this.StartVideoButton.Name = "StartVideoButton";
            this.StartVideoButton.Size = new System.Drawing.Size(132, 44);
            this.StartVideoButton.TabIndex = 9;
            this.StartVideoButton.Text = "Start";
            this.StartVideoButton.UseVisualStyleBackColor = true;
            this.StartVideoButton.Click += new System.EventHandler(this.StartVideoButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(904, 400);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(132, 44);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(904, 489);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(132, 44);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // RequestFileButton
            // 
            this.RequestFileButton.Location = new System.Drawing.Point(840, 33);
            this.RequestFileButton.Name = "RequestFileButton";
            this.RequestFileButton.Size = new System.Drawing.Size(37, 34);
            this.RequestFileButton.TabIndex = 7;
            this.RequestFileButton.Text = "Go";
            this.RequestFileButton.UseVisualStyleBackColor = true;
            this.RequestFileButton.Click += new System.EventHandler(this.RequestFileButton_Click);
            // 
            // RecieveImageButton
            // 
            this.RecieveImageButton.Location = new System.Drawing.Point(1187, 428);
            this.RecieveImageButton.Name = "RecieveImageButton";
            this.RecieveImageButton.Size = new System.Drawing.Size(132, 44);
            this.RecieveImageButton.TabIndex = 8;
            this.RecieveImageButton.Text = "Recieve Image";
            this.RecieveImageButton.UseVisualStyleBackColor = true;
            this.RecieveImageButton.Click += new System.EventHandler(this.RecieveImageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1435, 556);
            this.Controls.Add(this.RecieveImageButton);
            this.Controls.Add(this.RequestFileButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox MessageArea;
        private System.Windows.Forms.TextBox ChatArea;
        private System.Windows.Forms.TextBox MonitorFileSharingArea;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox FilePathArea;
        private System.Windows.Forms.Button RequestFileButton;
        private System.Windows.Forms.Button RequestDirectoryButton;
        private System.Windows.Forms.TextBox DirectoryArea;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button StopVideoButton;
        private System.Windows.Forms.Button StartVideoButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListView DirectoryListBox;
        private System.Windows.Forms.Button RecieveImageButton;
    }
}

