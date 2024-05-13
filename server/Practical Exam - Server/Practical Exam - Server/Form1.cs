using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Exam___Server
{
    public partial class Server : Form
    {
        Socket server;
        Socket client;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        public Server()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // ipep - bind - listen
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(10);

            client = await Task.Run(() => server.Accept());
            ns = new NetworkStream(client);
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private async void GoButton_Click(object sender, EventArgs e)
        {
            string tmp = MessageArea.Text;
            sw.WriteLine(tmp);
            sw.Flush();
            MessageArea.Text = "";
            tmp = "Me (server): " + tmp;
            ChatArea.Text += tmp;
            ChatArea.AppendText(Environment.NewLine);

            while (true)
            {
                tmp = await Task.Run(() => sr.ReadLine());
                tmp = "Client: " + tmp;
                ChatArea.Text += tmp;
                ChatArea.AppendText(Environment.NewLine);
            }
        }


        private async void WaitFileButton_Click(object sender, EventArgs e)
        {
            // File Sharing
            // Recieve the file path
            string filePath = await Task.Run(() => sr.ReadLine());

            // Read all data in the file
            byte[] allBytes = File.ReadAllBytes(filePath);

            // Send the length of the data (using StreamWriter)
            sw.WriteLine(allBytes.Length);
            sw.Flush();

            // Send the data itself (using NetworkStream)
            ns.Write(allBytes, 0, allBytes.Length);
            ns.Flush();
            MnitoringFileSharingArea.Text += "File sent successfully :D";
        }

        private async void WaitDirectoryButton_Click(object sender, EventArgs e)
        {
            // Wait for client request
            string directoryPath = await Task.Run(() => sr.ReadLine());

            // Send directory information to client
            SendDirectoryInfo(directoryPath);
        }

        private void SendDirectoryInfo(string directoryPath)
        {
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    string[] files = Directory.GetFiles(directoryPath);
                    string[] directories = Directory.GetDirectories(directoryPath);

                    // Send the number of files and directories
                    sw.WriteLine($"FilesCount: {files.Length}");
                    sw.WriteLine($"DirectoriesCount: {directories.Length}");
                    sw.Flush();

                    // Send file names
                    foreach (string file in files)
                    {
                        sw.WriteLine(Path.GetFileName(file));
                    }

                    // Send directory names and recursively send files in subdirectories
                    foreach (string dir in directories)
                    {
                        sw.WriteLine(Path.GetFileName(dir) + "/");
                        SendDirectoryInfo(dir); // Recursive call for subdirectories
                    }

                    sw.Flush();
                }
                else
                {
                    sw.WriteLine("Directory not found.");
                    sw.Flush();
                }
            }
            catch (Exception ex)
            {
                sw.WriteLine($"Error: {ex.Message}");
                sw.Flush();
            }
        }
    }

    
}
