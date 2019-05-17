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

namespace Final_Server
{
    public partial class TCP_Server : Form
    {
        public TCP_Server()
        {
            InitializeComponent();
        }

        TcpListener Server;
        Socket Client;
        Thread Th_Svr;
        Thread Th_Clt;
        Hashtable HT = new Hashtable();

        string[] roomPlayer = new string[10];

        private string MyIP()
        {
            string hn = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hn).AddressList;
            foreach (IPAddress it in ip)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork)
                { return it.ToString(); }
            }
            return "";
        }

        private void TCP_Server_Load(object sender, EventArgs e)
        {
            serverIP_TextBox.Text = MyIP();
        }

        private void startServer_Button_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Th_Svr = new Thread(ServerSub);
            Th_Svr.IsBackground = true;
            Th_Svr.Start();
            startServer_Button.Enabled = false;
            serverIP_TextBox.Enabled = false;
            serverPort_TextBox.Enabled = false;
        }

        private void ServerSub()
        {
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(MyIP()), int.Parse(serverPort_TextBox.Text));
            Server = new TcpListener(EP);
            Server.Start(100);

            while (true)
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
            while (true)
            {
                try
                {
                    byte[] B = new byte[1023];
                    int inLen = sck.Receive(B);
                    string Msg = Encoding.Default.GetString(B, 0, inLen);
                    message_ListBox.Items.Add("Receive：" + Msg);

                    string Cmd = Msg.Substring(0, 1);
                    string Str = Msg.Substring(1);
                    switch (Cmd)
                    {
                        case "0": // 有人登入
                            if (HT.Contains(Str))
                            {
                                byte[] D = Encoding.Default.GetBytes("Repeat");
                                sck.Send(D, 0, D.Length, SocketFlags.None);
                            }
                            else
                            {
                                HT.Add(Str, sck);
                                onlineUser_Listbox.Items.Add(Str);
                                SendAll(OnlineList());
                                SendTo(OnlineRoom(), Str);
                            }
                            break;
                        case "9": // 有人登出
                            HT.Remove(Str);
                            onlineUser_Listbox.Items.Remove(Str);
                            SendAll(OnlineList());
                            Th.Abort();
                            break;
                        case "1": // 傳送訊息給所有人
                            SendAll(Msg);
                            message_ListBox.Items.Add("SendAll：" + Msg);
                            break;
                        case "3": // 傳送訊息給房間所有人
                            string[] info3 = Str.Split('|');
                            int index3 = onlineRoom_ListBox.FindString(info3[0]);
                            SendRoomAll(index3, "3" + info3[1]);
                            message_ListBox.Items.Add("SendRoomAll：" + info3[0] + " , " + info3[1]);
                            break;
                        case "R": // Room 創建房間按鈕
                            string[] infoR = Str.Split('|');
                            if (!onlineRoom_ListBox.Items.Contains(infoR[0]))
                            {
                                onlineRoom_ListBox.Items.Add(infoR[0]);
                                roomPlayer[onlineRoom_ListBox.Items.Count - 1] = infoR[1];
                            }
                            else
                            {
                                byte[] D = Encoding.Default.GetBytes("Z");
                                sck.Send(D, 0, D.Length, SocketFlags.None);
                            }
                            break;
                        case "J": // Join Room 加入房間按鈕
                            string[] infoJ = Str.Split('|');
                            int indexJ = onlineRoom_ListBox.FindString(infoJ[1]);
                            if (roomPlayer[indexJ].Split(',').Length < 4)
                            {
                                roomPlayer[indexJ] += "," + infoJ[2];
                                SendRoomAll(indexJ,"J" + roomPlayer[indexJ]);
                                ClearAllReady(indexJ);
                            }
                            else
                            {
                                SendTo("Full", infoJ[1]);
                            }
                            break;
                        case "S": // Show All Rooms 刷新按鈕
                            string[] infoS = Str.Split('|');
                            SendTo(OnlineRoom(), infoS[1]);
                            break;
                        case "O": // OK - ChangeTeam 確定交換隊伍
                            string[] infoO = Str.Split('|');
                            int indexO = onlineRoom_ListBox.FindString(infoO[3]);
                            string temp = "temp";

                            //change
                            roomPlayer[indexO] = roomPlayer[indexO].Replace(infoO[1],temp);
                            roomPlayer[indexO] = roomPlayer[indexO].Replace(infoO[2],infoO[1]);
                            roomPlayer[indexO] = roomPlayer[indexO].Replace(temp, infoO[2]);

                            SendRoomAll(indexO, "J" + roomPlayer[indexO]);
                            ClearAllReady(indexO);
                            break;
                        case "G": // GO - 準備按鈕
                            string[] infoG = Str.Split('|');
                            int indexG = onlineRoom_ListBox.FindString(infoG[1]);

                            SendRoomAll(indexG, "G" + infoG[2]);
                            break;
                        case "E": // Exit Room 離開房間
                            string[] infoE = Str.Split('|');
                            int indexE = onlineRoom_ListBox.FindString(infoE[1]);

                            int test = roomPlayer[indexE].Split(',').Length;
                            if (roomPlayer[indexE].Split(',').Length == 1)
                            { roomPlayer[indexE] = roomPlayer[indexE].Replace(infoE[2], ""); }
                            else
                            {
                                if (infoE[2] == roomPlayer[indexE].Split(',')[0]) roomPlayer[indexE] = roomPlayer[indexE].Replace(infoE[2] + ",", "");
                                else roomPlayer[indexE] = roomPlayer[indexE].Replace("," + infoE[2], "");
                            }

                            if (roomPlayer[indexE] == "")
                            {
                                roomPlayer[indexE] = string.Empty;
                                onlineRoom_ListBox.Items.RemoveAt(indexE);
                                SendAll(OnlineRoom());
                            }
                            else
                            {
                                SendRoomAll(indexE, "J" + roomPlayer[indexE]);
                                ClearAllReady(indexE);
                            }
                            break;
                        case "M": //Move移動
                            string[] infoM = Str.Split('|');
                            int indexM = onlineRoom_ListBox.FindString(infoM[4]);
                            SendRoomAll(indexM, "Move|" + infoM[1] + "|" + infoM[2] + "|" + infoM[3]);
                            break;
                        case "H": // Hit 被子彈擊中
                            string[] infoH = Str.Split('|');
                            int indexH = onlineRoom_ListBox.FindString(infoH[1]);
                            SendRoomAll(indexH, "H" + infoH[2]);
                            break;
                        case "P": // Poop 射擊
                            string[] infoP = Str.Split('|');
                            int indexP = onlineRoom_ListBox.FindString(infoP[2]);
                            SendRoomAll(indexP, "P" + infoP[1]);
                            break;
                        case "I": // Item 產生道具
                            string[] infoI = Str.Split('|');
                            int indexI = onlineRoom_ListBox.FindString(infoI[1]);
                            SendRoomAll(indexI, "Item|" + infoI[2] + "|" + infoI[3] + "|" + infoI[4]);
                            break;
                        case "A": // Attack 交換（反擊）
                            int indexA = onlineRoom_ListBox.FindString(Str);
                            SendRoomAll(indexA, "A");
                            break;
                        default:
                            string[] C = Str.Split('|');
                            SendTo(Cmd + C[0], C[1]);
                            message_ListBox.Items.Add("SendTo：" + C[1] + Cmd + C[0]);
                            break;
                    }
                }
                catch { }
            }
        }

        private string OnlineList()
        {
            string L = "L";
            for (int i = 0; i < onlineUser_Listbox.Items.Count; i++)
            {
                L += onlineUser_Listbox.Items[i];
                if (i < onlineUser_Listbox.Items.Count - 1) { L += ","; }
            }
            message_ListBox.Items.Add("SendAll：" + L);
            return L;
        }

        private string OnlineRoom() // Show All Rooms
        {
            string S = "S";
            for (int i = 0; i < onlineRoom_ListBox.Items.Count; i++)
            {
                S += roomPlayer[i].Split(',').Length + "/4\t" + onlineRoom_ListBox.Items[i];
                if (i < onlineUser_Listbox.Items.Count - 1) { S += ","; }
            }
            return S;
        }

        private void SendTo(string Str, string User)
        {
            byte[] B = Encoding.Default.GetBytes(Str);
            Socket Sck = (Socket)HT[User];
            Sck.Send(B, 0, B.Length, SocketFlags.None);
        }

        private void SendAll(string Str)
        {
            byte[] B = Encoding.Default.GetBytes(Str);
            foreach (Socket s in HT.Values)s.Send(B, 0, B.Length, SocketFlags.None);
        }

        private void SendRoomAll(int index, string Str)
        {
            byte[] B = Encoding.Default.GetBytes(Str);
            string[] players = roomPlayer[index].Split(',');
            for (int i = 0; i < players.Length; i++)
            {
                Socket Sck = (Socket)HT[players[i]];
                Sck.Send(B, 0, B.Length, SocketFlags.None);
            }
        }

        private void ClearAllReady(int index)
        {
            SendRoomAll(index,"0");
        }

        private void TCP_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
