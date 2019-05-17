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

namespace FinalProject
{
    public partial class FinalProject : Form
    {
        public FinalProject() // Initialize
        {
            InitializeComponent();
        }

        Socket T;
        Thread Th;
        string User;
        string Room = "";
        bool logout = false;


        /*      ---------------------------------------------------     Form        ---------------------------------------------------     */
        private void FinalProject_Load(object sender, EventArgs e) // Form Load
        {
            Form.CheckForIllegalCrossThreadCalls = false;

            Lobby_Panel.Visible = false;
            Room_Panel.Visible = false;
            Game_Panel.Visible = false;
            Result_Panel.Visible = false;

            ChangeTeam_Panel.Location = new System.Drawing.Point(1840, 200);
            Room_Panel.Controls.Add(roomPlayerR1Name_Label);
            Room_Panel.Controls.Add(roomPlayerB1Name_Label);
            Room_Panel.Controls.Add(roomPlayerR2Name_Label);
            Room_Panel.Controls.Add(roomPlayerB2Name_Label);
            Game_Panel.Controls.Add(gameTime_Label);
            Game_Panel.Controls.Add(gameWall_Label);
            Game_Panel.Controls.Add(gamePlayerR1_PictureBox);
            Game_Panel.Controls.Add(gamePlayerR2_PictureBox);
            Game_Panel.Controls.Add(gamePlayerB1_PictureBox);
            Game_Panel.Controls.Add(gamePlayerB2_PictureBox);

            gameTime_Timer.Elapsed += gameTime_Timer_Tick;
            gameTime_Timer.Enabled = false;

            itemAction_Timer.Elapsed += ItemAction_Tick;
            itemAction_Timer.Enabled = false;

            itemsTime_Timer.Elapsed += itemsTime_Timer_Tick;
            itemsTime_Timer.Enabled = false;

            ClearTimer.Elapsed += ClearTimer_Tick;
            itemsTime_Timer.Enabled = false;
        }

        private void FinalProject_FormClosing(object sender, FormClosingEventArgs e) // Form Closing
        {
            if (Lobby_Panel.Visible == false && Room_Panel.Visible == false && Game_Panel.Visible == false) { }
            else
            {
                if (Room != "") Send("Exit" + "|" + Room + "|" + User);
                Thread.Sleep(50);
                Send("9" + User);
                T.Close();
            }
        }
        /*      ---------------------------------------------------     Login       ---------------------------------------------------      */
        private void loginButton_Click(object sender, EventArgs e) // 登入按鈕
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            if (userName_TextBox.Text == "") return;
            User = userName_TextBox.Text;
            if (User.Length > 10)
            {
                login_Button.Text = "名稱太長，重新輸入";
                return;
            }
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
                Send("0" + User);
                Lobby_Panel.Visible = true;
                logout = false;
                //login_Button.Enabled = false;
            }
            catch
            {
                login_Button.Text = "無法連上伺服器！";
            }
        }

        /*      ---------------------------------------------------     Lobby     ---------------------------------------------------     */
        private void lobbyMessage_TextBox_MouseClick(object sender, MouseEventArgs e) // 大廳訊息TextBox Click
        {
            if (lobbyMessage_TextBox.Text == "按下 Enter 鍵輸入")
            {
                lobbyMessage_TextBox.Text = "";
                lobbyMessage_TextBox.ForeColor = Color.Black;
            }
        }

        private void lobbyMessage_TextBox_Leave(object sender, EventArgs e)  // 離開(unfocus)大廳訊息TextBox
        {
            if (lobbyMessage_TextBox.Text == "")
            {
                lobbyMessage_TextBox.Text = "按下 Enter 鍵輸入";
                lobbyMessage_TextBox.ForeColor = Color.Silver;
            }
        }

        private void lobbyMessage_TextBox_KeyDown(object sender, KeyEventArgs e)  // 大廳訊息TextBox KeyDown
        {
            if (lobbyMessage_TextBox.Text == "") return;
            if (e.KeyCode == Keys.Enter)
            {
                if (lobbyOnlineUser_ListBox.SelectedIndex < 0)
                {
                    Send("1" + User + "：" + lobbyMessage_TextBox.Text);
                }
                else
                {
                    if (lobbyOnlineUser_ListBox.SelectedItem.ToString() != User)
                    {
                        Send("2" + User + "私密我：" + lobbyMessage_TextBox.Text + "|" + lobbyOnlineUser_ListBox.SelectedItem);
                        lobbyMessage_ListBox.Items.Add("我私密" + lobbyOnlineUser_ListBox.SelectedItem + "：" + lobbyMessage_TextBox.Text);
                    }
                }
                lobbyMessage_TextBox.Text = "";
            }
        }

        private void lobbySendMessage_Button_Click(object sender, EventArgs e)  // 訊息送出按鈕
        {
            lobbyOnlineUser_ListBox.ClearSelected();
        }

        private void lobbyRefresh_Button_Click(object sender, EventArgs e)  //  刷新房間按鈕
        {
            Send("ShowAllRoom" + "|" + User);
        }

        private void lobbyCreateRoom_Button_Click(object sender, EventArgs e)   //  創建房間按鈕
        {
            roomPlayerR1Name_Label.Text = User;
            createRoom_GroupBox.Visible = false;
        }

        private void lobbyCreateOK_Button_Click(object sender, EventArgs e)  //  創建確定按鈕
        {
            if (lobbyCreateName_TextBox.Text == "" || lobbyCreateName_TextBox.Text == "房名重複，請重新輸入") return;
            else
            {
                Send("R" + lobbyCreateName_TextBox.Text + "|" + User);
                Room = lobbyCreateName_TextBox.Text;
                Room_Panel.Visible = true;
                createRoom_GroupBox.Visible = true;
                lobbyCreateName_TextBox.Text = "";
            }
        }

        private void lobbyCreateCencel_Button_Click(object sender, EventArgs e) //  創建取消按鈕
        {
            lobbyCreateName_TextBox.Text = "";
            createRoom_GroupBox.Visible = true;
        }

        private void lobbyJoinRoom_Button_Click(object sender, EventArgs e) // 加入房間按鈕
        {
            if (lobbyRoom_ListBox.SelectedIndex < 0 || lobbyRoom_ListBox.SelectedItem.ToString() == "") return;
            else if (lobbyRoom_ListBox.SelectedItem.ToString().Substring(0, 1) == "4") return;
            else
            {
                string[] infoJ = lobbyRoom_ListBox.SelectedItem.ToString().Split('\t');
                Room = infoJ[1];
                Send("Join" + "|" + Room + "|" + User);
                Room_Panel.Visible = true;
            }
        }

        private void lobbyLogOut_Button_Click(object sender, EventArgs e)   //  登出按鈕
        {
            logout = true;
            Lobby_Panel.Visible = false;
            Send("9" + User);
            T.Close();
        }

        /*      ---------------------------------------------------     Room        ---------------------------------------------------     */
        private void roomMessage_TextBox_MouseClick(object sender, MouseEventArgs e)  // 房間訊息TextBox Click
        {
            if (roomMessage_TextBox.Text == "按下 Enter 鍵輸入")
            {
                roomMessage_TextBox.Text = "";
                roomMessage_TextBox.ForeColor = Color.Black;
            }
        }

        private void roomMessage_TextBox_Leave(object sender, EventArgs e)  // 離開(unfocus)房間訊息TextBox
        {
            if (roomMessage_TextBox.Text == "")
            {
                roomMessage_TextBox.Text = "按下 Enter 鍵輸入";
                roomMessage_TextBox.ForeColor = Color.Silver;
            }
        }

        private void roomMessage_TextBox_KeyDown(object sender, KeyEventArgs e)  // 房間訊息TextBox KeyDown
        {
            if (roomMessage_TextBox.Text == "") return;
            if (e.KeyCode == Keys.Enter)
            {
                Send("3" + Room + "|" + User + "：" + roomMessage_TextBox.Text);
                roomMessage_TextBox.Text = "";
            }
        }

        private void roomPlayer_Label_Click(object sender, EventArgs e) // R1  R2  B1  B2 Label Click
        {
            try
            {
                Label label = (Label)sender;
                Label name = this.Controls.Find("roomPlayer" + label.Text + "Name_Label", true).FirstOrDefault() as Label;

                string test = name.Text;
                if (name.Text == User || name.Text == "Empty") return;
                else
                {
                    changeCheckUser_Label.Text = name.Text;
                    ChangeCheck_Panel.Visible = true;
                }
            }
            catch { }
        }

        private void changeCheckOK_Button_Click(object sender, EventArgs e) // 交換對象確認按鈕
        {
            Send("C" + User + "|" + changeCheckUser_Label.Text);
            ChangeCheck_Panel.Visible = false;
        }

        private void changeCheckNOK_Button_Click(object sender, EventArgs e) // 交換對象取消按鈕
        {
            changeCheckUser_Label.Text = "";
            ChangeCheck_Panel.Visible = false;
        }

        private void changeTeamAccept_Button_Click(object sender, EventArgs e) // 交換請求確認按鈕
        {
            Send("OK" + "|" + changeTeamUser_Label.Text + "|" + User + "|" + Room);
            ChangeTeam_Panel.Location = new System.Drawing.Point(1840, 200);
        }

        private void changeTeamRefuse_Button_Click(object sender, EventArgs e) // 交換請求取消按鈕
        {
            //ChangeTeam_Panel.Visible = false;
            Send("3" + Room + "|(系統)" + User + "拒絕和" + changeTeamUser_Label.Text + "交換。");

            changeTeamUser_Label.Text = "";
            ChangeTeam_Panel.Location = new System.Drawing.Point(1840, 200);
        }

        private void roomReady_Button_Click(object sender, EventArgs e) //  準備按鈕
        {
            if (roomReady_Button.Text == "準   備")
            {
                roomReady_Button.Text = "取消準備";
            }
            else
            {
                roomReady_Button.Text = "準   備";
            }

            Send("Go" + "|" + Room + "|" + User);
        }

        private void roomLeave_Button_Click(object sender, EventArgs e) //  離開按鈕
        {
            Send("Exit" + "|" + Room + "|" + User);
            Room = "";
            roomMessage_ListBox.Items.Clear();
            Room_Panel.Visible = false;
            createRoom_GroupBox.Visible = true;
        }

        private void illustrate_Button_Paint(object sender, PaintEventArgs e) // 說明按鈕設計
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            myGraphicsPath.AddEllipse(5, 5, 50, 50);
            illustrate_Button.Region = new Region(myGraphicsPath);
        }

        private void illustrate_Button_Click(object sender, EventArgs e) // 說明按鈕
        {
            illustrate_Form form = new illustrate_Form();
            form.Show();
        }

        /*      ---------------------------------------------------     Game        ---------------------------------------------------     */
        // 物件
        string R1_Name, R2_Name, B1_Name, B2_Name;
        PictureBox TOP1, TOP2, BOT1, BOT2;
        PictureBox Player;

        // 權限
        bool GAMER = false;  // 房主
        bool gameStart = false;
        bool Attacker = false;
        int players = 0;

        // 變數
        const int STEP_PIXEL = 7;
        int timeLeft = 180;
        int redScore = 0, blueScore = 0;

        int nowBullet = 5, // 5 ~ 9 (+-1)
            maxBullet = 5; // 5 ~ 9 (+-1)
        int poo_width = 45, // 45 ~ 90 (+-9)
            poo_height = 37; // 37 ~ 72 (+-7)
        int poo_SPEED = 5; // 5 ~ 13 (+-2)
        bool freezing = false;
        bool blocking = false;

        // 道具位置,數量
        string rnd_Result = "";
        int x = 0, y = 0;
        int big = 20;
        int small = 12;
        int fast = 20;
        int slow = 12;
        int max = 20;
        int min = 12;
        int freeze = 10;
        //int invincible = 8;
        int block = 10;
        int change = 20;

        // 其他用途 ( Timer, List, Random)
        private List<Keys> pressKeys = new List<Keys>();
        private static System.Timers.Timer gameTime_Timer = new System.Timers.Timer(1000);
        private static System.Timers.Timer itemsTime_Timer = new System.Timers.Timer(500);
        private static System.Timers.Timer itemAction_Timer = new System.Timers.Timer(100);
        Random random = new Random();


        private void itemsTime_Timer_Tick(object sender, EventArgs e)  // 物品產生計時器
        {
            if (random.Next(1, 14) == 7)
            {
                /*  random location : 
                 *   0,200                  790,200
                 *   0,572                  790,572         
                 */

                x = random.Next(0, 791);
                y = random.Next(200, 573);
                rnd_Result = itemsAppear(1, 138); // 1 ~ 145 ( 1 ~ 138 )

                Send("Item|" + Room + "|" + rnd_Result + "|" + x + "|" + y);
            }
        }

        private string itemsAppear(int ran_min, int ran_max) // 道具亂數產生Fuction
        {
            int itemRan = random.Next(ran_min, ran_max);
            if (itemRan <= 20) return checkItems(ref big, "big", 21, 145, 21, 145);                             // 1 ~ 20
            else if (itemRan >= 21 && itemRan <= 32) return checkItems(ref small, "small", 1, 21, 33, 145);     //21 ~ 32
            else if (itemRan >= 33 && itemRan <= 52) return checkItems(ref fast, "fast", 1, 33, 53, 145);       //33 ~ 52
            else if (itemRan >= 53 && itemRan <= 64) return checkItems(ref slow, "slow", 1, 53, 65, 145);       //53 ~ 64
            else if (itemRan >= 65 && itemRan <= 84) return checkItems(ref max, "max", 1, 65, 85, 145);         //65 ~ 84
            else if (itemRan >= 85 && itemRan <= 96) return checkItems(ref min, "min", 1, 85, 97, 145);         //85 ~ 96
            else if (itemRan >= 97 && itemRan <= 106) return checkItems(ref freeze, "freeze", 1, 97, 107, 145); //97 ~ 106
            //else if (itemRan >= 107 && itemRan <= 114) return checkItems(ref invincible, "invincible", 1, 107, 115, 145); 107 ~ 114
            else if (itemRan >= 107 && itemRan <= 116) return checkItems(ref block, "block", 1, 115, 125, 145); //115 ~ 124 ( 107 ~ 116 )
            else return checkItems(ref change, "change", 1, 117, 1, 117);                                       //124 ~ 145 ( 117 ~ 138 )
        }

        private string checkItems(ref int item, string itemS, int ran_min0, int ran_max0, int ran_min1, int ran_max1)  // 檢查道具是否為0
        {
            if (item == 0)
            {
                if (random.Next(0, 2) == 0) return itemsAppear(ran_min0, ran_max0);
                else return itemsAppear(ran_min1, ran_max1);
            }
            else
            {
                item--;
                return itemS;
            }
        }

        int freezCount = 0;
        int blockCount = 0;
        private void gameTime_Timer_Tick(object sender, EventArgs e)  // 遊戲時間計時器
        {
            if (freezing)
            {
                freezCount++;
                if (freezCount == 4)
                {
                    freezing = false;
                    freezCount = 0;
                }
            }

            if (blocking)
            {
                gameWall_PictureBox.Location = new System.Drawing.Point(-192, 196);
                blockCount++;
                if (blockCount == 11)
                {
                    gameWall_PictureBox.Location = new System.Drawing.Point(1800, 1800);
                    blocking = false;
                    blockCount = 0;
                }
            }

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                gameTime_Label.Text = timeLeft.ToString();
            }
            else // 時間到
            {
                gameTime_Timer.Enabled = false;
                itemAction_Timer.Enabled = false;
                itemsTime_Timer.Enabled = false;

                ClearTimer.Enabled = true;
                gameStart = false;
                Result_Panel.Visible = true;
                roomReady_Button.Enabled = true;
                resultRedScore_Label.Text = redScore.ToString();
                resultBlueScore_Label.Text = blueScore.ToString();
                if (redScore > blueScore) resultRed_Label.Text = "紅隊勝";
                else resultBlue_Label.Text = "藍隊勝";
            }
        }

        int bulletCount = 0;
        private void ItemAction_Tick(object sender, EventArgs e)  // 物品動作計時器
        {
            bulletCount++;
            if (bulletCount == 8)
            {
                if (nowBullet < maxBullet)
                {
                    nowBullet++;
                }
                gameBullet_Label.Text = nowBullet.ToString() + "/" + maxBullet.ToString();
                bulletCount = 0;
            }

            foreach (Control control in Game_Panel.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox item = (PictureBox)control;
                    if (item.Tag != null)
                    {
                        string bullet_Tag = item.Tag.ToString();
                        switch (bullet_Tag)
                        {
                            case "Bullet":
                                item.Top += poo_SPEED;
                                if (item.Bottom < 0) item.Dispose();
                                if (!Attacker)
                                {
                                    if (chkHit((PictureBox)item, Player))
                                    {
                                        Send("Hit|" + Room + "|" + User);
                                        item.Image = global::FinalProject.Properties.Resources.bulletBomb;
                                        item.Tag = "Bomb";
                                        Thread.Sleep(200);
                                        item.Dispose();
                                    }
                                }
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2))
                                {
                                    item.Image = global::FinalProject.Properties.Resources.bulletBomb;
                                    item.Tag = "Bomb";
                                    Thread.Sleep(200);
                                    item.Dispose();
                                }
                                break;
                            case "big":
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2) || chkHit((PictureBox)item, Player))
                                {
                                    if (poo_height < 90)
                                    {
                                        poo_height += 9;
                                        poo_width += 7;
                                    }
                                    item.Dispose();
                                }
                                break;
                            case "small":
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2) || chkHit((PictureBox)item, Player))
                                {
                                    if (poo_height > 37)
                                    {
                                        poo_height -= 9;
                                        poo_width -= 7;
                                    }
                                    item.Dispose();
                                }
                                break;
                            case "fast":
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2) || chkHit((PictureBox)item, Player))
                                {
                                    if (poo_SPEED < 13)
                                    {
                                        poo_SPEED += 2;
                                    }
                                    item.Dispose();
                                }
                                break;
                            case "slow":
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2) || chkHit((PictureBox)item, Player))
                                {
                                    if (poo_SPEED > 5)
                                    {
                                        poo_SPEED -= 2;
                                    }
                                    item.Dispose();
                                }
                                break;
                            case "max":
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2) || chkHit((PictureBox)item, Player))
                                {
                                    if (maxBullet < 9)
                                    {
                                        maxBullet++;
                                    }
                                    item.Dispose();
                                }
                                break;
                            case "min":
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2) || chkHit((PictureBox)item, Player))
                                {
                                    if (maxBullet > 5)
                                    {
                                        maxBullet--;
                                    }
                                    item.Dispose();
                                }
                                break;
                            case "freeze":
                                if (Attacker)
                                {
                                    if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2))
                                    {
                                        item.Dispose();
                                    }
                                }
                                else
                                {
                                    if (chkHit((PictureBox)item, Player))
                                    {
                                        freezing = true;
                                        item.Dispose();
                                    }
                                    else if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2))
                                    {
                                        item.Dispose();
                                    }
                                }
                                break;
                            /*case "invincible":
                                if (Attacker)
                                {
                                    if (chkHit((PictureBox)item, B1) || chkHit((PictureBox)item, B2))
                                    {
                                        if (poo_height > 37)
                                        {
                                            poo_height -= 9;
                                            poo_width -= 7;
                                        }
                                        item.Dispose();
                                    }
                                }
                                else
                                {
                                    if (chkHit((PictureBox)item, B1) || chkHit((PictureBox)item, B2) || chkHit((PictureBox)item, Player))
                                    {
                                        if (poo_height > 37)
                                        {
                                            poo_height -= 9;
                                            poo_width -= 7;
                                        }
                                        item.Dispose();
                                    }
                                }
                                break;*/
                            case "block":
                                if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2) || chkHit((PictureBox)item, Player))
                                {
                                    blocking = true;
                                    item.Dispose();
                                }
                                break;
                            case "change":
                                if (Attacker)
                                {
                                    if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2))
                                    {
                                        item.Dispose();
                                    }
                                }
                                else
                                {
                                    if (chkHit((PictureBox)item, Player))
                                    {
                                        Thread.Sleep(50);
                                        Send("A" + Room); // Attack
                                        item.Dispose();
                                    }
                                    else if (chkHit((PictureBox)item, BOT1) || chkHit((PictureBox)item, BOT2))
                                    {
                                        item.Dispose();
                                    }
                                }
                                break;

                        }
                    }
                }
            }
        }

        bool sendMsg = false;
        private void FinalProject_KeyDown(object sender, KeyEventArgs e) // 按下按鈕
        {
            if (!gameStart) return;
            if (freezing) return;

            if ((e.KeyCode.Equals(Keys.W) || e.KeyCode.Equals(Keys.S) ||
                                e.KeyCode.Equals(Keys.A) || e.KeyCode.Equals(Keys.D) || e.KeyCode.Equals(Keys.P)))
            {

                switch (e.KeyCode)
                {
                    case Keys.W: if (!Attacker) Player.Top -= STEP_PIXEL; sendMsg = true; break;
                    case Keys.S: if (!Attacker) Player.Top += STEP_PIXEL; sendMsg = true; break;
                    case Keys.A: Player.Left -= STEP_PIXEL; sendMsg = true; break;
                    case Keys.D: Player.Left += STEP_PIXEL; sendMsg = true; break;
                    case Keys.P: if (Attacker) POOP(); sendMsg = true; break;
                }

                if (chkTouchLR(Player)) sendMsg = false;
                if (!Attacker) { if (chkTouchTB(Player)) sendMsg = false; }

                if (sendMsg)
                {
                    sendMsg = false;
                    Send("Move|" + Player.Top.ToString() + "|" + Player.Left.ToString() + "|" + User + "|" + Room);
                }
            }
        }

        private bool chkTouchLR(PictureBox item) // 檢查左右到牆壁
        {
            if (item.Location.X < 0) { item.Location = new System.Drawing.Point(0, item.Location.Y); return true; }
            if (item.Location.X > 766) { item.Location = new System.Drawing.Point(766, item.Location.Y); return true; }
            return false;
        }

        private bool chkTouchTB(PictureBox item) // 檢查上下到牆壁
        {
            if (!Attacker)
            {
                if (item.Top < 200) { item.Location = new System.Drawing.Point(item.Location.X, 200); return true; }
                if (item.Top > 509) { item.Location = new System.Drawing.Point(item.Location.X, 509); return true; }
            }
            else return true;
            return false;
        }

        private bool chkHit(PictureBox item, PictureBox role)  // 碰撞偵測
        {
            try
            {
                if (item.Right < role.Left) return false;
                if (item.Left > role.Right) return false;
                if (item.Top > role.Bottom) return false;
                if (item.Bottom < role.Top) return false;
            }
            catch { }
            return true;
        }

        /*      ---------------------------------------------------     Resault     ---------------------------------------------------     */
        private void resaultBack_Button_Click(object sender, EventArgs e)  // 返回房間按鈕
        {
            Result_Panel.Visible = false;
            Game_Panel.Visible = false;
        }

        /*      ---------------------------------------------------     Public      ---------------------------------------------------     */
        private void Listen()
        {
            EndPoint ServerEP = (EndPoint)T.RemoteEndPoint;
            byte[] B = new byte[2013];
            int inLen = 0;
            string Msg;
            string St;
            string Str;

            while (true)
            {
                try
                {
                    inLen = T.ReceiveFrom(B, ref ServerEP);
                }
                catch (Exception)
                {
                    T.Close();
                    lobbyOnlineUser_ListBox.Items.Clear();
                    Lobby_Panel.Visible = false;
                    if (!logout) login_Button.Text = ("伺服器斷線了！");
                    login_Button.Enabled = true;
                    Th.Abort();
                }
                string[] info;
                Msg = Encoding.Default.GetString(B, 0, inLen);
                St = Msg.Substring(0, 1);
                Str = Msg.Substring(1);
                switch (St)
                {
                    case "R": // Repeat 名稱重複
                        Lobby_Panel.Visible = false;
                        login_Button.Text = "名稱重複，重新輸入";
                        break;
                    case "L":
                        info = Str.Split(',');
                        lobbyOnlineUser_ListBox.Items.Clear();
                        for (int i = 0; i < info.Length; i++)
                        {
                            lobbyOnlineUser_ListBox.Items.Add(info[i]);
                        }
                        break;
                    case "1":
                        string[] N = Str.Split('：');
                        if (N[0] == User)
                        {
                            lobbyMessage_ListBox.Items.Add("我：" + N[1]);
                        }
                        else
                        {
                            lobbyMessage_ListBox.Items.Add(Str);
                        }
                        break;
                    case "2":
                        lobbyMessage_ListBox.Items.Add(Str);
                        break;
                    case "3":
                        string[] O = Str.Split('：');
                        if (O[0] == User)
                        {
                            roomMessage_ListBox.Items.Add("我：" + O[1]);
                        }
                        else
                        {
                            roomMessage_ListBox.Items.Add(Str);
                        }
                        break;
                    case "Z": // 房名重複
                        Room_Panel.Visible = false;
                        createRoom_GroupBox.Visible = false;
                        lobbyCreateName_TextBox.Text = "房名重複，請重新輸入";
                        break;
                    case "F": // Full 房間已滿
                        Lobby_Panel.Visible = true;
                        break;
                    case "S": // Show All Room 顯示所有房間
                        lobbyRoom_ListBox.Items.Clear();
                        string[] AllRooms = Str.Split(',');
                        for (int i = 0; i < AllRooms.Length; i++)
                        {
                            lobbyRoom_ListBox.Items.Add(AllRooms[i]);
                        }
                        break;
                    case "J":
                        info = Str.Split(',');
                        switch (info.Length)
                        {
                            case 1:
                                roomPlayerR1Name_Label.Text = info[0];
                                roomPlayerB1Name_Label.Text = "Empty";
                                roomPlayerR2Name_Label.Text = "Empty";
                                roomPlayerB2Name_Label.Text = "Empty";
                                break;
                            case 2:
                                roomPlayerR1Name_Label.Text = info[0];
                                roomPlayerB1Name_Label.Text = info[1];
                                roomPlayerR2Name_Label.Text = "Empty";
                                roomPlayerB2Name_Label.Text = "Empty";
                                break;
                            case 3:
                                roomPlayerR1Name_Label.Text = info[0];
                                roomPlayerB1Name_Label.Text = info[1];
                                roomPlayerR2Name_Label.Text = info[2];
                                roomPlayerB2Name_Label.Text = "Empty";
                                break;
                            case 4:
                                roomPlayerR1Name_Label.Text = info[0];
                                roomPlayerB1Name_Label.Text = info[1];
                                roomPlayerR2Name_Label.Text = info[2];
                                roomPlayerB2Name_Label.Text = info[3];
                                break;
                        }
                        break;
                    case "C": // ChangeTeam 交換隊伍按鈕
                        info = Str.Split('|');
                        changeTeamUser_Label.Text = info[0];
                        //ChangeTeam_Panel.Visible = true;
                        ChangeTeam_Panel.Location = new System.Drawing.Point(275, 200);
                        break;
                    case "G":
                        if (roomPlayerR1Name_Label.Text == Str)  // R1
                        {
                            if (roomPlayerR1_Label.BackColor == Color.LimeGreen) roomPlayerR1_Label.BackColor = Color.LightCoral;
                            else roomPlayerR1_Label.BackColor = Color.LimeGreen;
                        }
                        else if (roomPlayerR2Name_Label.Text == Str)  // R2
                        {
                            if (roomPlayerR2_Label.BackColor == Color.LimeGreen) roomPlayerR2_Label.BackColor = Color.LightCoral;
                            else roomPlayerR2_Label.BackColor = Color.LimeGreen;
                        }
                        else if (roomPlayerB1Name_Label.Text == Str)  // B1
                        {
                            if (roomPlayerB1_Label.BackColor == Color.LimeGreen) roomPlayerB1_Label.BackColor = Color.CornflowerBlue;
                            else roomPlayerB1_Label.BackColor = Color.LimeGreen;
                        }
                        else if (roomPlayerB2Name_Label.Text == Str)  // B2
                        {
                            if (roomPlayerB2_Label.BackColor == Color.LimeGreen) roomPlayerB2_Label.BackColor = Color.CornflowerBlue;
                            else roomPlayerB2_Label.BackColor = Color.LimeGreen;
                        }

                        if (roomPlayerR1_Label.BackColor == Color.LimeGreen && roomPlayerR2_Label.BackColor == Color.LimeGreen &&
                            roomPlayerB1_Label.BackColor == Color.LimeGreen && roomPlayerB2_Label.BackColor == Color.LimeGreen)
                        {
                            players = 4;
                            SetGame();
                        }
                        else if (roomPlayerR1_Label.BackColor == Color.LimeGreen && roomPlayerR2_Label.BackColor == Color.LightCoral &&
                                 roomPlayerB1_Label.BackColor == Color.LimeGreen && roomPlayerB2_Label.BackColor == Color.CornflowerBlue &&
                                 roomPlayerR2Name_Label.Text == "Empty" && roomPlayerB2Name_Label.Text == "Empty")
                        {
                            players = 2;
                            SetGame();
                        }
                        break;
                    case "0": // Clear All Ready 清除所有準備
                        ClearAllReady();
                        break;
                    case "M": // Move
                        info = Str.Split('|');
                        int top = int.Parse(info[1]);
                        int left = int.Parse(info[2]);
                        string who = info[3];

                        if (User != who)
                        {
                            if (!changed)
                            {
                                if (R1_Name == who)
                                {
                                    TOP1.Top = top;
                                    TOP1.Left = left;
                                }
                                if (R2_Name == who)
                                {
                                    TOP2.Top = top;
                                    TOP2.Left = left;
                                }
                                if (B1_Name == who)
                                {
                                    BOT1.Top = top;
                                    BOT1.Left = left;
                                }
                                if (B2_Name == who)
                                {
                                    BOT2.Top = top;
                                    BOT2.Left = left;
                                }
                            }
                            else
                            {

                                if (R1_Name == who)
                                {
                                    BOT1.Top = top;
                                    BOT1.Left = left;
                                }
                                if (R2_Name == who)
                                {
                                    BOT2.Top = top;
                                    BOT2.Left = left;
                                }
                                if (B1_Name == who)
                                {
                                    TOP1.Top = top;
                                    TOP1.Left = left;
                                }
                                if (B2_Name == who)
                                {
                                    TOP2.Top = top;
                                    TOP2.Left = left;
                                }
                            }
                        }
                        break;
                    case "H": // Hit 某人被擊中
                        if (Str == R1_Name || Str == R2_Name) { blueScore++; gameBlueScore_Label.Text = blueScore.ToString(); }
                        else { redScore++; gameRedScore_Label.Text = redScore.ToString(); }
                        break;
                    case "P": // Poop 某人射擊
                        try
                        {
                            PictureBox P = new PictureBox();
                            P.Image = global::FinalProject.Properties.Resources.bullet;
                            P.Size = new System.Drawing.Size(poo_width, poo_height);
                            P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            P.Location = new System.Drawing.Point(int.Parse(Str), 51);
                            P.Tag = "Bullet";
                            CreateItem(P);
                        }
                        catch { }
                        break;
                    case "I":  // Item 產生道具
                        try
                        {
                            info = Str.Split('|');
                            PictureBox item = new PictureBox();
                            Control.CheckForIllegalCrossThreadCalls = false;
                            item.Size = new System.Drawing.Size(40, 40);
                            item.Location = new System.Drawing.Point(int.Parse(info[2]), int.Parse(info[3]));
                            item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            item.Tag = info[1];

                            switch (info[1])
                            {
                                case "big": item.Image = global::FinalProject.Properties.Resources.big; break;
                                case "small": item.Image = global::FinalProject.Properties.Resources.small; break;
                                case "fast": item.Image = global::FinalProject.Properties.Resources.fast; break;
                                case "slow": item.Image = global::FinalProject.Properties.Resources.slow; break;
                                case "max": item.Image = global::FinalProject.Properties.Resources.max; break;
                                case "min": item.Image = global::FinalProject.Properties.Resources.min; break;
                                case "freeze": item.Image = global::FinalProject.Properties.Resources.freeze; break;
                                //case "invincible": item.Image = global::FinalProject.Properties.Resources.invincible; break;
                                case "block": item.Image = global::FinalProject.Properties.Resources.block; break;
                                case "change": item.Image = global::FinalProject.Properties.Resources.change; break;
                            }
                            CreateItem(item);
                            //Game_Panel.Controls.Add(item);
                        }
                        catch { }
                        break;
                    case "A":  // Attack 交換（反擊
                        ChangeItemChangeTeam();
                        Attacker = (!Attacker);
                        break;
                }
            }
        }

        private void Send(string Str)
        {
            byte[] B = Encoding.Default.GetBytes(Str);
            T.Send(B, 0, B.Length, SocketFlags.None);
        }

        private void SetGame()  // 開始遊戲
        {
            if (players == 2)
            {
                // 初始位置
                /*      280 20          480 20
                 *      200 400         560 400
                 */

                gamePlayerR1_PictureBox.Visible = true;
                gamePlayerR2_PictureBox.Visible = false;
                gamePlayerB1_PictureBox.Visible = true;
                gamePlayerB2_PictureBox.Visible = false;

                gamePlayerR1_PictureBox.Location = new System.Drawing.Point(280, 20);
                gamePlayerR2_PictureBox.Location = new System.Drawing.Point(999, 999);
                gamePlayerB1_PictureBox.Location = new System.Drawing.Point(200, 400);
                gamePlayerB2_PictureBox.Location = new System.Drawing.Point(999, 999);
            }
            if (players == 4)
            {
                gamePlayerR1_PictureBox.Visible = true;
                gamePlayerR2_PictureBox.Visible = true;
                gamePlayerB1_PictureBox.Visible = true;
                gamePlayerB2_PictureBox.Visible = true;

                gamePlayerR1_PictureBox.Location = new System.Drawing.Point(280, 20);
                gamePlayerR2_PictureBox.Location = new System.Drawing.Point(480, 20);
                gamePlayerB1_PictureBox.Location = new System.Drawing.Point(200, 400);
                gamePlayerB2_PictureBox.Location = new System.Drawing.Point(560, 400);
            }

            gameStart = true;
            ClearTimer.Enabled = false;
            roomReady_Button.Enabled = false;
            Game_Panel.Visible = true;

            ClearAllReady();
            SetName();
            SetItem();
            SetTimer();
            SetVariable();




        }

        private void SetName()  // 設置人名人數
        {
            if (players == 4)
            {
                R1_Name = roomPlayerR1Name_Label.Text;
                R2_Name = roomPlayerR2Name_Label.Text;
                B1_Name = roomPlayerB1Name_Label.Text;
                B2_Name = roomPlayerB2Name_Label.Text;
            }
            else
            {
                R1_Name = roomPlayerR1Name_Label.Text;
                B1_Name = roomPlayerB1Name_Label.Text;
                R2_Name = "";
                B2_Name = "";
            }

            TOP1 = gamePlayerR1_PictureBox;
            TOP2 = gamePlayerR2_PictureBox;
            BOT1 = gamePlayerB1_PictureBox;
            BOT2 = gamePlayerB2_PictureBox;

            if (User == R1_Name) { Player = gamePlayerR1_PictureBox; Attacker = true; GAMER = true; }
            if (User == R2_Name) { Player = gamePlayerR2_PictureBox; Attacker = true; }
            if (User == B1_Name) { Player = gamePlayerB1_PictureBox; Attacker = false; }
            if (User == B2_Name) { Player = gamePlayerB2_PictureBox; Attacker = false; }
        }

        private void SetItem()  // 設置道具數量
        {
            big = 20;
            small = 12;
            fast = 20;
            slow = 12;
            max = 20;
            min = 12;
            freeze = 10;
            //invincible = 8;
            block = 10;
            change = 20;
        }

        private void SetTimer()  // 設置所有計時器
        {
            gameTime_Timer.Enabled = true;
            itemAction_Timer.Enabled = true;

            if (GAMER)
            {
                itemsTime_Timer.Enabled = true;
            }
        }

        private void SetVariable()  // 設置所有變數
        {
            timeLeft = 180;
            redScore = 0;
            blueScore = 0;
            gameRedScore_Label.Text = redScore.ToString();
            gameBlueScore_Label.Text = blueScore.ToString();

            nowBullet = 5;
            maxBullet = 5;
            gameBullet_Label.Text = nowBullet.ToString() + "/" + maxBullet.ToString();
            poo_width = 45;
            poo_height = 37;
            poo_SPEED = 5;

            changed = false;
            GAMER = false;
        }

        private void ClearAllReady()  // 清除所有準備
        {
            roomReady_Button.Text = "準   備";
            roomPlayerR1_Label.BackColor = Color.LightCoral;
            roomPlayerR2_Label.BackColor = Color.LightCoral;
            roomPlayerB1_Label.BackColor = Color.CornflowerBlue;
            roomPlayerB2_Label.BackColor = Color.CornflowerBlue;
        }

        private void POOP()  // 射擊
        {
            if (nowBullet > 0)
            {
                nowBullet -= 1;

                gameBullet_Label.Text = nowBullet.ToString() + "/" + maxBullet.ToString();
                Send("Poo|" + (Player.Left - 16).ToString() + "|" + Room);
            }
            else { }
        }

        private delegate void SetItemCallBack(PictureBox Item); // 委派
        private void CreateItem(PictureBox Item)
        {
            if (this.InvokeRequired)
            {
                SetItemCallBack call = new SetItemCallBack(CreateItem);
                this.Invoke(call, Item);
            }
            else
            {
                Game_Panel.Controls.Add(Item);
            }
        }

        bool changed = false;
        private void ChangeItemChangeTeam() // 交換道具
        {
            if (players == 2)
            {
                gamePlayerR1_PictureBox.Location = new System.Drawing.Point(280, 20);
                gamePlayerB1_PictureBox.Location = new System.Drawing.Point(200, 400);

                if (!changed)
                {
                    gamePlayerR1_PictureBox.Image = global::FinalProject.Properties.Resources.standB1;
                    gamePlayerB1_PictureBox.Image = global::FinalProject.Properties.Resources.runA1;
                }
                else
                {
                    gamePlayerR1_PictureBox.Image = global::FinalProject.Properties.Resources.standA1;
                    gamePlayerB1_PictureBox.Image = global::FinalProject.Properties.Resources.runB1;
                }
            }
            else // players == 4
            {
                gamePlayerR1_PictureBox.Location = new System.Drawing.Point(280, 20);
                gamePlayerR2_PictureBox.Location = new System.Drawing.Point(480, 20);
                gamePlayerB1_PictureBox.Location = new System.Drawing.Point(200, 400);
                gamePlayerB2_PictureBox.Location = new System.Drawing.Point(560, 400);

                if (!changed)
                {
                    gamePlayerR1_PictureBox.Image = global::FinalProject.Properties.Resources.standB1;
                    gamePlayerB1_PictureBox.Image = global::FinalProject.Properties.Resources.runA1;
                    gamePlayerR2_PictureBox.Image = global::FinalProject.Properties.Resources.standB2;
                    gamePlayerB2_PictureBox.Image = global::FinalProject.Properties.Resources.runA2;
                }
                else
                {
                    gamePlayerR1_PictureBox.Image = global::FinalProject.Properties.Resources.standA1;
                    gamePlayerB1_PictureBox.Image = global::FinalProject.Properties.Resources.runB1;
                    gamePlayerR2_PictureBox.Image = global::FinalProject.Properties.Resources.standA2;
                    gamePlayerB2_PictureBox.Image = global::FinalProject.Properties.Resources.runB2;
                }
            }

            TOP1 = gamePlayerR1_PictureBox;
            TOP2 = gamePlayerR2_PictureBox;
            BOT1 = gamePlayerB1_PictureBox;
            BOT2 = gamePlayerB2_PictureBox;

            if (!changed)
            {
                if (User == R1_Name) { Player = BOT1; }
                if (User == R2_Name) { Player = BOT2; }
                if (User == B1_Name) { Player = TOP1; }
                if (User == B2_Name) { Player = TOP2; }
            }
            else
            {
                if (User == R1_Name) { Player = TOP1; }
                if (User == R2_Name) { Player = TOP2; }
                if (User == B1_Name) { Player = BOT1; }
                if (User == B2_Name) { Player = BOT2; }
            }

            changed = !changed;
        }

        private static System.Timers.Timer ClearTimer = new System.Timers.Timer(100); // 清除物品計時器

        private void ClearTimer_Tick(object sender, EventArgs e)  // 清除物品計時器動作
        {
            foreach (Control control in Game_Panel.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox item = (PictureBox)control;
                    if (item.Tag != null)
                    {
                        item.Dispose();
                    }
                }
            }
        }
    }
}
