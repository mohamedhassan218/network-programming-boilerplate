using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace client
{
    public partial class Form1 : Form
    {
        Socket server;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        bool flag = true;
        private CancellationTokenSource cancellationTokenSource;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            await Task.Run(() => server.Connect(ipep));
            ns = new NetworkStream(server);
            sw = new StreamWriter(ns);
            sr = new StreamReader(ns);
        }

        private async void GoButton_Click(object sender, EventArgs e)
        {
            string tmp = MessageArea.Text;
            sw.WriteLine(tmp);
            sw.Flush();
            MessageArea.Text = "";
            tmp = "Me (client): " + tmp;
            ChatArea.Text += tmp;
            ChatArea.AppendText(Environment.NewLine);

            while (flag)
            {
                tmp = await Task.Run(() => sr.ReadLine());
                tmp = "Server: " + tmp;
                ChatArea.Text += tmp;
                ChatArea.AppendText(Environment.NewLine);
            }
        }

        private async void RequestFileButton_Click(object sender, EventArgs e)
        {
            flag = false;
            try
            {
                // Send the file path
                sw.WriteLine(FilePathArea.Text);
                sw.Flush();

                // Recieve the length of the data
                string fileSize = await Task.Run(() => sr.ReadLine());

                // out is called parameter modifier
                if (int.TryParse(fileSize, out int fileSizeParsed))
                {
                    byte[] bytes = new byte[200];
                    int recievedBytes = 0, tmp;

                    using (FileStream fs = new FileStream("tmp.txt", FileMode.Create))
                    {
                        while (recievedBytes < fileSizeParsed && (tmp = ns.Read(bytes, 0, bytes.Length)) > 0)
                        {
                            fs.Write(bytes, 0, tmp);
                            recievedBytes += tmp;
                        }
                    }

                    string result = File.ReadAllText("tmp.txt");
                    MonitorFileSharingArea.Text = result;
                }
                else
                {
                    MonitorFileSharingArea.Text = "Invalid file Size";
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MonitorFileSharingArea.Text = "Error receiving file: " + ex.Message;
            }
        }

        private async void RequestDirectoryButton_Click(object sender, EventArgs e)
        {
            flag = false;
            string path = DirectoryArea.Text;
            sw.WriteLine(path);
            sw.Flush();
            DirectoryListBox.Items.Clear();
            string response;
            while ((response = await sr.ReadLineAsync()) != null)
            {
                // Debugging: Check response format
                var parts = response.Split('|');
                {
                    ListViewItem item = new ListViewItem(parts[0]);
                    item.SubItems.Add(parts[1]);
                    item.SubItems.Add(parts.Length > 2 ? parts[2] : "");
                    DirectoryListBox.Items.Add(item);
                }

            }
            DirectoryListBox.View = View.LargeIcon;
        }

        private void DirectoryArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void DirectoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void StartVideoButton_Click(object sender, EventArgs e)
        {
            string tempFilePath = Path.GetTempFileName();
            byte[] buffer = new byte[1024];

            long fileSize = long.Parse(await sr.ReadLineAsync());
            long bytesReceived = 0;

            using (FileStream fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
            {
                while (bytesReceived < fileSize)
                {
                    int bytesToRead = (int)Math.Min(buffer.Length, fileSize - bytesReceived);
                    int bytesRead = await ns.ReadAsync(buffer, 0, bytesToRead);

                    if (bytesRead == 0)
                    {
                        break;
                    }

                    await fs.WriteAsync(buffer, 0, bytesRead);
                    bytesReceived += bytesRead;
                }
            }

            // Play the video from the temporary file
            // You can use a media player control or a method to play the video file
            PlayVideo(tempFilePath);
        }

        private void PlayVideo(string filePath)
        {
            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                // Handle the exception if the video file cannot be played
                MessageBox.Show("Error playing video: " + ex.Message);
            }
        }


        private void StopVideoButton_Click(object sender, EventArgs e)
        {

        }
    }
}