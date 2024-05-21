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
        bool flag = true;

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
            flag = true;
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
            MessageBox.Show("Entered wait.");
            flag = false;
            try
            {
                // File Sharing
                // Recieve the file path
                string filePath = await Task.Run(() => sr.ReadLine());

                MessageBox.Show("Received file path.");

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
            catch (Exception ex)
            {
                // Handle the exception
                MnitoringFileSharingArea.Text += "Error sending file: " + ex.Message;
            }
        }

        private async void WaitDirectoryButton_Click(object sender, EventArgs e)
        {
            flag = false;
            // Read the directory path asynchronously from the stream
            string path = await Task.Run(() => sr.ReadLine());

            // Create a DirectoryInfo object to access directory information
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            // StringBuilder to store the directory listing response
            StringBuilder response = new StringBuilder();

            // Loop through each directory in the specified directory
            foreach (var directory in directoryInfo.GetDirectories())
            {
                // Append directory name and type (Folder) to the response string
                response.AppendLine($"{directory.Name}|Folder|");
            }

            // Loop through each file in the specified directory
            foreach (var file in directoryInfo.GetFiles())
            {
                // Append file name, type (File), and file size in KB to the response string
                response.AppendLine($"{file.Name}|File|{(file.Length / 1024)} KB");
            }

            // Write the directory listing response to the network stream asynchronously
            await sw.WriteAsync(response.ToString());

            // Flush the stream to ensure all data is sent immediately
            await sw.FlushAsync();

            // Update a UI element (DirectoryMessage) to indicate that the directory information has been sent
            MonitoringDirectoryInfoArea.Text += "Directory Sent";

        }

        private void SendDirectoryInfo(string directoryPath)
        {
            flag = false;
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

        private void MonitoringDirectoryInfoArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
