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

namespace A103223013_Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient U;
        Thread Th;
        bool Turn = true;
        int myNumber;
        int targetNumber;
        int win, lose;

        private string MyIP()
        {
            string hn = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hn).AddressList;
            foreach (IPAddress it in ip)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork)
                    return it.ToString();
            }
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.B1.Click += new System.EventHandler(this.B0_Click);
            this.B2.Click += new System.EventHandler(this.B0_Click);
            this.B3.Click += new System.EventHandler(this.B0_Click);
            this.B4.Click += new System.EventHandler(this.B0_Click);
            this.B5.Click += new System.EventHandler(this.B0_Click);

            random();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Th.Abort();
                U.Close();
            }
            catch { }
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Th = new Thread(Listen);
            Th.Start();
            listenButton.Enabled = false;
            turn_Label.Visible = true;

            for(int i=0; i<6; i++)
            { this.Controls["B" + i.ToString()].Enabled = true; }
        }

        private void Listen()
        {
            int Port = int.Parse(listenPort_TextBox.Text);
            U = new UdpClient(Port);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(MyIP()), Port);
            while (true)
            {
                byte[] B = U.Receive(ref EP);
                string A = Encoding.Default.GetString(B);

                if (A == "Re")
                {
                    random();
                    Turn = true;
                    win = 0;
                    lose = 0;
                    turn_Label.Visible = true;

                    myCard_ListBox.Items.Clear();
                    targetCard_ListBox.Items.Clear();
                    result_ListBox.Items.Clear();


                    for (int i = 0; i < 6; i++)
                    { this.Controls["B" + i.ToString()].Enabled = true; }
                }
                else
                {
                    targetNumber = int.Parse(parseToNumber(A));
                    targetCard_ListBox.Items.Add("第" + (targetCard_ListBox.Items.Count + 1) + "輪：" + A);

                    Turn = true;
                    if (myCard_ListBox.Items.Count == targetCard_ListBox.Items.Count)
                    {
                        Turn = false;
                        result_ListBox.Items.Add("第" + (result_ListBox.Items.Count + 1) + "輪：" + chk(myNumber, targetNumber));
                        if (result_ListBox.Items.Count == 6)
                        {
                            string result;
                            if (win > lose) result = "勝利";
                            else if (win < lose) result = "失敗";
                            else result = "平手";
                            result_ListBox.Items.Add("最終比數［" + win + "：" + lose + "］ → " + result);
                            turn_Label.Visible = false;
                        }
                    }
                    if (Turn) turn_Label.Visible = true;
                    else turn_Label.Visible = false;
                }
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (Turn == false) return;
            Button B = (Button)sender;
            B.Enabled = false;

            string A = B.Text;
            myNumber = int.Parse(parseToNumber(A));
            myCard_ListBox.Items.Add("第" + (myCard_ListBox.Items.Count + 1) + "輪：" + A);

            Turn = false;
            if (myCard_ListBox.Items.Count == targetCard_ListBox.Items.Count)
            {
                Turn = true;
                result_ListBox.Items.Add("第" + (result_ListBox.Items.Count + 1) + "輪：" + chk(myNumber, targetNumber));
                if(result_ListBox.Items.Count == 6)
                {
                    Turn = false;
                    string result;
                    if (win > lose) result = "勝利";
                    else if (win < lose) result = "失敗";
                    else result = "平手";
                    result_ListBox.Items.Add("最終比數［" + win + "：" + lose + "］ → " + result);
                }
            }
            if (Turn) turn_Label.Visible = true;
            else turn_Label.Visible = false;

            int Port = int.Parse(targetPort_TextBox.Text);
            UdpClient S = new UdpClient(targetIP_TextBox.Text, Port);
            byte[] K = Encoding.Default.GetBytes(A);
            S.Send(K, K.Length);
            S.Close();
        }

        private void random()
        {
            int[] myCard = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                myCard[i] = rnd.Next(1, 14);
                for (int j = 0; j < i; j++)
                {
                    if (myCard[i] == myCard[j])
                    {
                        j = 0;
                        myCard[i] = rnd.Next(1, 14);
                    }
                }

                switch (myCard[i])
                {
                    case 1:
                        this.Controls["B" + i.ToString()].Text = "A";
                        break;
                    case 11:
                        this.Controls["B" + i.ToString()].Text = "J";
                        break;
                    case 12:
                        this.Controls["B" + i.ToString()].Text = "Q";
                        break;
                    case 13:
                        this.Controls["B" + i.ToString()].Text = "K";
                        break;
                    default:
                        this.Controls["B" + i.ToString()].Text = myCard[i].ToString();
                        break;
                }
            }

        }

        private string chk(int my, int target)
        {
            if (my == 1 || target == 1)
            {
                if (my < target) { win++; return "贏"; }
                else if (my > target) { lose++; return "輸"; }
                else { return "平手"; }
            }
            else
            {
                if (my > target) { win++; return "贏"; }
                else if (my < target) { lose++; return "輸"; }
                else { return "平手"; }
            }
        }

        private string parseToNumber(string A)
        {
            switch (A)
            {
                case "A":
                    A = "1";
                    break;
                case "J":
                    A = "11";
                    break;
                case "Q":
                    A = "12";
                    break;
                case "K":
                    A = "13";
                    break;
            }
            return A;
        }

        private void restart_Button_Click(object sender, EventArgs e)
        {
            random(); 
            Turn = true;
            win = 0;
            lose = 0;
            turn_Label.Visible = true;

            myCard_ListBox.Items.Clear();
            targetCard_ListBox.Items.Clear();
            result_ListBox.Items.Clear();

            for (int i = 0; i < 6; i++)
            { this.Controls["B" + i.ToString()].Enabled = true; }

            string A = "Re";
            int Port = int.Parse(targetPort_TextBox.Text);
            UdpClient S = new UdpClient(targetIP_TextBox.Text, Port);
            byte[] K = Encoding.Default.GetBytes(A);
            S.Send(K, K.Length);
            S.Close();
        }



    }
}
