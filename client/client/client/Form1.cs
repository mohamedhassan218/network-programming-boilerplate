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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        Socket server;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        bool flag = true;



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

            while (true)
            {
                tmp = await Task.Run(() => sr.ReadLine());
                tmp = "Server: " + tmp;
                ChatArea.Text += tmp;
                ChatArea.AppendText(Environment.NewLine);
            }
        }

        private async void RequestFileButton_Click(object sender, EventArgs e)
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

        private async void RequestDirectoryButton_Click(object sender, EventArgs e)
        {
            // Send directory path to server
            string directoryPath = DirectoryArea.Text;
            await Task.Run(() => sw.WriteLine(directoryPath));
            sw.Flush();

            // Receive and display directory information
            ReceiveDirectoryInfo();
        }

        private void ReceiveDirectoryInfo()
        {
            try
            {
                string response = sr.ReadLine();

                if (response.StartsWith("FilesCount:"))
                {
                    int filesCount = int.Parse(response.Split(':')[1]);
                    int directoriesCount = int.Parse(sr.ReadLine().Split(':')[1]);

                    // Read and display file names
                    for (int i = 0; i < filesCount; i++)
                    {
                        string fileName = sr.ReadLine();
                        DirectoryListBox.Items.Add(fileName);
                    }

                    // Read and display directory names
                    for (int i = 0; i < directoriesCount; i++)
                    {
                        string dirName = sr.ReadLine().TrimEnd('/');
                        DirectoryListBox.Items.Add(dirName);
                    }
                }
                else
                {
                    MessageBox.Show(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}