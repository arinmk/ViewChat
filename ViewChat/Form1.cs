using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;
using System.Net.Sockets;
using System.Net;

namespace ViewChat
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public string Id;
        public string MSG;
        private static UdpClient udpClient = new UdpClient();
        private static readonly int ListenPort = 11000;
        private static bool isRunning = true;
        public string YourMSG;
        public Form1()
        {
            InitializeComponent();
            textEdit1.Visible = false;
            StartClient();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UserSideDisplay()
        {
            var Mtime = DateTime.Now.ToShortTimeString();
            memoEdit1.AppendLine($"{Mtime.Replace("PM", "")} {Id.ToUpper()}: {textEdit1.Text}");
           
            //memoEdit1.AppendLine($"{Mtime.Replace("PM", "")} {Id.ToUpper()}: {MSG}");
            textEdit1.Text = "";
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (simpleButton2.Visible)
            {
                if (keyData == Keys.Enter)
                {
                    idSetter();
                    return true;
                }
            }
            else
            {
                if (keyData == Keys.Enter)
                {
                    UserSideDisplay();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public  void StartClient()
        {
            new Thread(() =>
            {
                // Allow sending broadcast messages
                udpClient.EnableBroadcast = true;

                // Start receiving messages in a separate thread
                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                //Console.WriteLine("Enter messages to send, 'exit' to quit:");
                while (isRunning)
                {
                    string message = YourMSG;
                    //byte[] bytes = Encoding.ASCII.GetBytes(message);
                    //udpClient.Send(bytes, bytes.Length, new IPEndPoint(IPAddress.Broadcast, ListenPort));
                }

                udpClient.Close();
            })
            {IsBackground = true }.Start();
        }

        private  void ReceiveMessages()
        {
            new Thread(() =>
            {
                udpClient = new UdpClient(ListenPort);
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, ListenPort);

                try
                {
                    while (isRunning)
                    {
                        byte[] bytes = udpClient.Receive(ref remoteEndPoint);
                        string message = Encoding.ASCII.GetString(bytes);
                        MSG = message;
                    }
                }
                catch (Exception e)
                {

                }
                finally
                {
                    udpClient.Close();
                }
            })
            {IsBackground = true }.Start();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UserSideDisplay();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            idSetter();
        }
        private void idSetter()
        {
            Id = textEdit2.Text;
            simpleButton2.Visible = false;
            textEdit2.Visible = false;
            labelControl1.Visible = false;
            textEdit1.Visible = true;
        }
    }
}
