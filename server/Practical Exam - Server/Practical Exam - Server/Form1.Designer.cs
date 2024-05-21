namespace Practical_Exam___Server
{
    partial class Server
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WaitFileButton = new System.Windows.Forms.Button();
            this.MnitoringFileSharingArea = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WaitDirectoryButton = new System.Windows.Forms.Button();
            this.MonitoringDirectoryInfoArea = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StopVideoStreaming = new System.Windows.Forms.Button();
            this.StartVideoStreaming = new System.Windows.Forms.Button();
            this.ListenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GoButton);
            this.groupBox1.Controls.Add(this.MessageArea);
            this.groupBox1.Controls.Add(this.ChatArea);
            this.groupBox1.Location = new System.Drawing.Point(31, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(345, 414);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(45, 51);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "GO";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MessageArea
            // 
            this.MessageArea.Location = new System.Drawing.Point(6, 414);
            this.MessageArea.Multiline = true;
            this.MessageArea.Name = "MessageArea";
            this.MessageArea.Size = new System.Drawing.Size(332, 51);
            this.MessageArea.TabIndex = 1;
            // 
            // ChatArea
            // 
            this.ChatArea.Location = new System.Drawing.Point(6, 21);
            this.ChatArea.Multiline = true;
            this.ChatArea.Name = "ChatArea";
            this.ChatArea.Size = new System.Drawing.Size(384, 387);
            this.ChatArea.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WaitFileButton);
            this.groupBox2.Controls.Add(this.MnitoringFileSharingArea);
            this.groupBox2.Location = new System.Drawing.Point(446, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitoring File Sharing";
            // 
            // WaitFileButton
            // 
            this.WaitFileButton.Location = new System.Drawing.Point(112, 183);
            this.WaitFileButton.Name = "WaitFileButton";
            this.WaitFileButton.Size = new System.Drawing.Size(122, 33);
            this.WaitFileButton.TabIndex = 9;
            this.WaitFileButton.Text = "Wait";
            this.WaitFileButton.UseVisualStyleBackColor = true;
            this.WaitFileButton.Click += new System.EventHandler(this.WaitFileButton_Click);
            // 
            // MnitoringFileSharingArea
            // 
            this.MnitoringFileSharingArea.Location = new System.Drawing.Point(6, 21);
            this.MnitoringFileSharingArea.Multiline = true;
            this.MnitoringFileSharingArea.Name = "MnitoringFileSharingArea";
            this.MnitoringFileSharingArea.Size = new System.Drawing.Size(339, 156);
            this.MnitoringFileSharingArea.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WaitDirectoryButton);
            this.groupBox3.Controls.Add(this.MonitoringDirectoryInfoArea);
            this.groupBox3.Location = new System.Drawing.Point(446, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 227);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitoring Directory Info";
            // 
            // WaitDirectoryButton
            // 
            this.WaitDirectoryButton.Location = new System.Drawing.Point(112, 187);
            this.WaitDirectoryButton.Name = "WaitDirectoryButton";
            this.WaitDirectoryButton.Size = new System.Drawing.Size(122, 33);
            this.WaitDirectoryButton.TabIndex = 6;
            this.WaitDirectoryButton.Text = "Wait";
            this.WaitDirectoryButton.UseVisualStyleBackColor = true;
            this.WaitDirectoryButton.Click += new System.EventHandler(this.WaitDirectoryButton_Click);
            // 
            // MonitoringDirectoryInfoArea
            // 
            this.MonitoringDirectoryInfoArea.Location = new System.Drawing.Point(6, 21);
            this.MonitoringDirectoryInfoArea.Multiline = true;
            this.MonitoringDirectoryInfoArea.Name = "MonitoringDirectoryInfoArea";
            this.MonitoringDirectoryInfoArea.Size = new System.Drawing.Size(328, 160);
            this.MonitoringDirectoryInfoArea.TabIndex = 8;
            this.MonitoringDirectoryInfoArea.TextChanged += new System.EventHandler(this.MonitoringDirectoryInfoArea_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.StopVideoStreaming);
            this.groupBox4.Controls.Add(this.StartVideoStreaming);
            this.groupBox4.Location = new System.Drawing.Point(823, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(549, 330);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monitoring Video Streaming";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(537, 244);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // StopVideoStreaming
            // 
            this.StopVideoStreaming.Location = new System.Drawing.Point(385, 271);
            this.StopVideoStreaming.Name = "StopVideoStreaming";
            this.StopVideoStreaming.Size = new System.Drawing.Size(138, 39);
            this.StopVideoStreaming.TabIndex = 6;
            this.StopVideoStreaming.Text = "Stop";
            this.StopVideoStreaming.UseVisualStyleBackColor = true;
            // 
            // StartVideoStreaming
            // 
            this.StartVideoStreaming.Location = new System.Drawing.Point(41, 271);
            this.StartVideoStreaming.Name = "StartVideoStreaming";
            this.StartVideoStreaming.Size = new System.Drawing.Size(138, 39);
            this.StartVideoStreaming.TabIndex = 7;
            this.StartVideoStreaming.Text = "Start";
            this.StartVideoStreaming.UseVisualStyleBackColor = true;
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(823, 369);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(138, 39);
            this.ListenButton.TabIndex = 3;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(823, 439);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(138, 39);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1384, 526);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ListenButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox MessageArea;
        private System.Windows.Forms.TextBox ChatArea;
        private System.Windows.Forms.TextBox MnitoringFileSharingArea;
        private System.Windows.Forms.TextBox MonitoringDirectoryInfoArea;
        private System.Windows.Forms.Button WaitFileButton;
        private System.Windows.Forms.Button WaitDirectoryButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button StopVideoStreaming;
        private System.Windows.Forms.Button StartVideoStreaming;
    }
}

