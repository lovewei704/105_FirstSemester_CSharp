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

namespace A103223013_FinalTerm_GuessNumber
{
    public partial class TCP_GuessNumber : Form
    {
        public TCP_GuessNumber()
        {
            InitializeComponent();
        }

        Socket T;
        Thread Th;
        string User;

        int myGuessCount = 0, otherGuessCount = 0;

        private void TCP_GuessNumber_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(login_Button.Enabled == false)
            {
                Send("9" + User);
                T.Close();
            }
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            User = userName_TextBox.Text;
            string IP = serverIP_TextBox.Text;
            int Port = int.Parse(serverPort_TextBox.Text);
            try
            {
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse(IP), Port);
                T = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                T.Connect(EP);
                Th = new Thread(Listen);
                Th.IsBackground = true;
                Th.Start();
                systemMessage_ListBox.Items.Clear();
                systemMessage_ListBox.Items.Add("已連接伺服器！");
                Send("0" + User);
                login_Button.Enabled = false;
                restart_Button.Enabled = true;

                serverIP_TextBox.Enabled = false;
                serverPort_TextBox.Enabled = false;
                userName_TextBox.Enabled = false;
            }
            catch
            {
                systemMessage_ListBox.Items.Clear();
                systemMessage_ListBox.Items.Add("無法連上伺服器！");
            }
        }

        private void Listen()
        {
            EndPoint ServerEP = (EndPoint)T.RemoteEndPoint;
            byte[] B = new byte[1023];
            int inLen = 0;
            string Msg;
            string St;
            string Str;

            while(true)
            {
                try
                {
                    inLen = T.ReceiveFrom(B, ref ServerEP);
                }
                catch
                {
                    T.Close();
                    onlineUser_ListBox.Items.Clear();
                    systemMessage_ListBox.Items.Add("伺服器斷線了！");
                    login_Button.Enabled = true;
                    Th.Abort();
                }

                Msg = Encoding.Default.GetString(B, 0, inLen);
                serverMessage_ListBox.Items.Add("Receive : " + Msg);
                St = Msg.Substring(0, 1);
                Str = Msg.Substring(1);
                switch(St)
                {
                    case "L":
                        onlineUser_ListBox.Items.Clear();
                        string[] M = Str.Split(',');
                        for (int i = 0; i < M.Length; i++) onlineUser_ListBox.Items.Add(M[i]);
                        onlineUser_ListBox.Enabled = true;
                        break;
                    case "S":
                        onlineUser_ListBox.Items.Clear();
                        systemMessage_ListBox.Items.Add("User Name 重複，請重新輸入！");
                        login_Button.Enabled = true;
                        break;
                    case "G":
                        string K = chk(Str);
                        Send("K" + K + "|" + onlineUser_ListBox.SelectedItem);
                        otherGuess_ListBox.Items.Add(Str + ">" + K);
                        otherGuessCount++;
                        otherGuessCount_Show.Text = otherGuessCount.ToString();
                        send_Button.Enabled = true;
                        if (K == "4A0B") 
                        {
                            systemMessage_ListBox.Items.Add("你輸了！");
                            restart_Button.Enabled = true;
                            send_Button.Enabled = false;
                            ExitGame_Button.Enabled = true;
                        }
                        break;
                    case "K":
                        myGuessCount++;
                        myGuessCount_Show.Text = myGuessCount.ToString();
                        myGuess_ListBox.Items.Add(myNumber_TextBox.Text + ">" + Str);
                        send_Button.Enabled = false;
                        if (Str == "4A0B")
                        {
                            systemMessage_ListBox.Items.Add("你贏了！");
                            restart_Button.Enabled = true;
                            ExitGame_Button.Enabled = true;
                        }
                        break;
                }
            }
        }
        
        private void Send(string Str)
        {
            serverMessage_ListBox.Items.Add("Send : " + Str);
            byte[] B = Encoding.Default.GetBytes(Str);
            T.Send(B, 0, B.Length, SocketFlags.None);
        }

        private void send_Button_Click(object sender, EventArgs e)
        {
            if (chkNum("猜測數字", guessNumber_TextBox.Text))
            {
                Send("G" + guessNumber_TextBox.Text + "|" + onlineUser_ListBox.SelectedItem);
                send_Button.Enabled = false;
            }
        }

        private void lock_Button_Click(object sender, EventArgs e)
        {
            if (chkNum("我的數字", myNumber_TextBox.Text))
            {
                myNumber_TextBox.Enabled = false;
                lock_Button.Enabled = false;
                send_Button.Enabled = true;
            }
        }

        private bool chkNum(string Str, string Num)
        {
            int rv;
            bool isnum = int.TryParse(Num, out rv);

            if (Num.Length != 4 || isnum == false)
            {
                systemMessage_ListBox.Items.Add(Str + "必須是四個數字！");
                return false;
            }
            if (Repeat(Num))
            {
                systemMessage_ListBox.Items.Add(Str + "不能重複！");
                return false;
            }

            return true;
        }

        private bool Repeat(string Num)
        {
            char[] C = Num.ToCharArray();

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (C[i] == C[j] && i != j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private string chk(string G)
        {
            int A = 0, B = 0;
            char[] C = myNumber_TextBox.Text.ToCharArray();
            char[] D = G.ToCharArray();

            for(int i = 0; i <= 3; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    if(C[i] == D[j])
                    {
                        if(i == j)
                        {
                            A += 1;
                        }
                        else
                        {
                            B += 1;
                        }
                    }
                }
            }
            return A.ToString() + "A" + B.ToString() + "B";
        }

        private void restart_Button_Click(object sender, EventArgs e)
        {
            if (onlineUser_ListBox.SelectedIndex < 0 || onlineUser_ListBox.SelectedItem.ToString() == User)
            {
                systemMessage_ListBox.Items.Clear();
                systemMessage_ListBox.Items.Add("請選擇非自己的玩家");
            }
            else
            {
                myGuessCount = 0;
                otherGuessCount = 0;
                myGuessCount_Show.Text = myGuessCount.ToString();
                otherGuessCount_Show.Text = otherGuessCount.ToString();
                send_Button.Enabled = false;
                lock_Button.Enabled = true;
                myNumber_TextBox.Enabled = true;

                myNumber_TextBox.Text = "";
                guessNumber_TextBox.Text = "";
                myGuess_ListBox.Items.Clear();
                otherGuess_ListBox.Items.Clear();
                systemMessage_ListBox.Items.Clear();

                onlineUser_ListBox.Enabled = false;
                restart_Button.Enabled = false;
                restart_Button.Text = "重玩";
                ExitGame_Button.Enabled = false;
            }
        }

        private void ExitGame_Button_Click(object sender, EventArgs e)
        {
            myGuessCount = 0;
            otherGuessCount = 0;
            myGuessCount_Show.Text = myGuessCount.ToString();
            otherGuessCount_Show.Text = otherGuessCount.ToString();
            send_Button.Enabled = false;
            lock_Button.Enabled = false;
            myNumber_TextBox.Enabled = true;

            myNumber_TextBox.Text = "";
            guessNumber_TextBox.Text = "";
            myGuess_ListBox.Items.Clear();
            otherGuess_ListBox.Items.Clear();
            systemMessage_ListBox.Items.Clear();

            restart_Button.Text = "開始";
            onlineUser_ListBox.Enabled = true;
            ExitGame_Button.Enabled = false;
        }
    }
}
