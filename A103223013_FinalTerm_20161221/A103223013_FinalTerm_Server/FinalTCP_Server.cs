using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace A103223013_FinalTerm_20161221
{
    public partial class FinalTCP_Server : Form
    {
        public FinalTCP_Server()
        {
            InitializeComponent();
        }

        TcpListener Server;
        Socket Client;
        Thread Th_Svr;
        Thread Th_Clt;
        Hashtable HT = new Hashtable();

        private void FinalTCP_Server_Load(object sender, EventArgs e)
        {
            serverIP_TextBox.Text = MyIP();
        }

        private string MyIP()
        {
            string hn = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hn).AddressList;
            foreach(IPAddress it in ip)
            {
                if(it.AddressFamily == AddressFamily.InterNetwork)
                {
                    return it.ToString();
                }
            }
            return "";
        }

        private void FinalTCP_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void startServer_Button_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Th_Svr = new Thread(ServerSub);
            Th_Svr.IsBackground = true;
            Th_Svr.Start();
            startServer_Button.Enabled = false;
        }

        private void ServerSub()
        {
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(serverIP_TextBox.Text),int.Parse(serverPort_TextBox.Text));
            Server = new TcpListener(EP);
            Server.Start(100);
            while(true)
            {
                Client = Server.AcceptSocket();
                Th_Clt = new Thread(Listen);
                Th_Clt.IsBackground = true;
                Th_Clt.Start();
            }
        }

        private void Listen()
        {
            Socket sck = Client;
            Thread Th = Th_Clt;
            while(true)
            {
                try
                {
                    byte[] B = new byte[1023];
                    int inLen = sck.Receive(B);
                    string Msg = Encoding.Default.GetString(B, 0, inLen);
                    message_ListBox.Items.Add("Receive : " + Msg);
                    string Cmd = Msg.Substring(0, 1);
                    string Str = Msg.Substring(1);
                    switch (Cmd)
                    {
                        case "0":
                            if (!onlineUser_ListBox.Items.Contains(Str))
                            {
                                HT.Add(Str, sck);
                                onlineUser_ListBox.Items.Add(Str);
                                SendAll(OnlineList());
                            }
                            else
                            {
                                byte[] D = Encoding.Default.GetBytes("SameID");
                                sck.Send(D, 0, D.Length, SocketFlags.None);
                                message_ListBox.Items.Add("SendTo : SameID");
                            }
                            break;
                        case "1":
                            SendAll(Msg);
                            break;
                        case "9":
                            HT.Remove(Str);
                            onlineUser_ListBox.Items.Remove(Str);
                            SendAll(OnlineList());
                            Th.Abort();
                            break;
                        default:
                            string[] C = Str.Split('|');
                            SendTo(Cmd + C[0], C[1]);
                            break;
                    }
                }
                catch (Exception) { }
            }
        }

        private string OnlineList()
        {
            string L = "L";
            for(int i = 0; i<onlineUser_ListBox.Items.Count; i++)
            {
                L += onlineUser_ListBox.Items[i];
                if (i < onlineUser_ListBox.Items.Count - 1) { L += ","; }
            }
            return L;
        }

        private void SendTo(string Str, string User)
        {
            byte[] B = Encoding.Default.GetBytes(Str);
            Socket Sck = (Socket)HT[User];
            Sck.Send(B, 0, B.Length, SocketFlags.None);
            message_ListBox.Items.Add("SendTo : " + User + Str);
        }

        private void SendAll(string Str)
        {
            byte[] B = Encoding.Default.GetBytes(Str);
            foreach (Socket s in HT.Values) s.Send(B, 0, B.Length, SocketFlags.None);
            message_ListBox.Items.Add("SendAll : " + Str);
        }

    }
}
