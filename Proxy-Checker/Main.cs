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

namespace Proxy_Checker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private int goodCount = 0;
        private int badCount = 0;
        List<string> ProxyList = new List<string>();
        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    file_path_tx.Text = selectedFilePath;

                    string[] lines = File.ReadAllLines(selectedFilePath);

                    ProxyList.Clear(); // Clear the list before adding new lines.
                    ProxyList.AddRange(lines); // Add the lines to the emailList.

                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void CheckProxiesParallel(List<string> proxies)
        {
            object lockObject = new object(); // Lock for synchronization

            Parallel.ForEach(proxies, proxy =>
            {
                string[] parts = proxy.Split(':');
                if (parts.Length == 2)
                {
                    string ip = parts[0];
                    int port;
                    if (int.TryParse(parts[1], out port))
                    {
                        bool isGood = false;

                        if (radio_http.Checked)
                            isGood = TestHttpProxy(ip, port);
                        else if (radio_socks4.Checked)
                            isGood = TestSocks4Proxy(ip, port);
                        else
                            isGood = TestSocks5Proxy(ip, port);

                        lock (lockObject)
                        {
                            if (isGood)
                            {
                                goodProxies.Add(proxy);
                                goodCount++;
                            }
                            else
                            {
                                badProxies.Add(proxy);
                                badCount++;
                            }
                            UpdateCounts();
                        }
                    }
                }
            });
        }

        private List<string> goodProxies = new List<string>();
        private List<string> badProxies = new List<string>();


        private void SaveProxiesToFile(string filePath, List<string> proxyList)
        {
            File.WriteAllLines(filePath, proxyList);
        }

        private bool TestHttpProxy(string ip, int port)
        {
            try
            {
                // Test the proxy by making a web request
                WebRequest request = WebRequest.Create("http://www.example.com");
                request.Proxy = new WebProxy(ip, port);
                using (WebResponse response = request.GetResponse())
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool TestSocks4Proxy(string ip, int port)
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    IPAddress ipAddress = IPAddress.Parse(ip);
                    IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, port);

                    // Connect using SOCKS4 handshake
                    socket.Connect(remoteEndPoint);
                    byte[] socks4Request = new byte[9];
                    socks4Request[0] = 4; // SOCKS version 4
                    socks4Request[1] = 1; // Establish a TCP stream connection
                    socks4Request[2] = (byte)(port >> 8);
                    socks4Request[3] = (byte)port;
                    Array.Copy(ipAddress.GetAddressBytes(), 0, socks4Request, 4, 4);
                    socks4Request[8] = 0; // Null terminator for user ID

                    socket.Send(socks4Request);
                    byte[] socks4Response = new byte[8];
                    socket.Receive(socks4Response);

                    // Check if the proxy response indicates success
                    if (socks4Response[1] == 0x5A)
                    {
                        // Proxy connection successful
                        return true;
                    }
                    else
                    {
                        // Proxy connection failed
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool TestSocks5Proxy(string ip, int port)
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.Connect(ip, port);

                    // Send SOCKS5 handshake
                    byte[] socks5Handshake = { 5, 1, 0 };
                    socket.Send(socks5Handshake);

                    // Receive SOCKS5 handshake response
                    byte[] response = new byte[2];
                    socket.Receive(response);

                    if (response[0] == 5 && response[1] == 0)
                    {
                        // SOCKS5 proxy connection established

                        // Create a SOCKS5 request
                        byte[] socks5Request = new byte[10];
                        socks5Request[0] = 5;   // SOCKS version
                        socks5Request[1] = 1;   // Connect command
                        socks5Request[2] = 0;   // Reserved field
                        socks5Request[3] = 1;   // Address type (IPv4)
                        IPAddress ipAddress = IPAddress.Parse(ip);
                        Buffer.BlockCopy(ipAddress.GetAddressBytes(), 0, socks5Request, 4, 4);
                        socks5Request[8] = (byte)(port >> 8);
                        socks5Request[9] = (byte)port;

                        socket.Send(socks5Request);

                        byte[] socks5Response = new byte[10];
                        socket.Receive(socks5Response);

                        if (socks5Response[1] == 0)
                        {
                            // Proxy connection successful
                            return true;
                        }
                    }

                    // Proxy connection failed
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void UpdateCounts()
        {
            // Update the UI label with the good and bad proxy counts
            if (InvokeRequired)
            {
                Invoke((Action)UpdateCounts);
                return;
            }
            good.Text = $"{goodCount}";
            bad.Text = $"{badCount}";
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            goodCount = 0;
            badCount = 0;
            UpdateCounts();

            await Task.Run(() => CheckProxiesParallel(ProxyList)); // Using Parallel.ForEach

            SaveProxiesToFile("good_proxies.txt", goodProxies);
            SaveProxiesToFile("bad_proxies.txt", badProxies);
        }
    }
}
