namespace FinalProject
{
    partial class FinalProject
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalProject));
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.Lobby_Panel = new System.Windows.Forms.Panel();
            this.Room_Panel = new System.Windows.Forms.Panel();
            this.Game_Panel = new System.Windows.Forms.Panel();
            this.gameWall_Label = new System.Windows.Forms.Label();
            this.gameWall_PictureBox = new System.Windows.Forms.PictureBox();
            this.gameTime_Label = new System.Windows.Forms.Label();
            this.gamePlayerB2_PictureBox = new System.Windows.Forms.PictureBox();
            this.gamePlayerB1_PictureBox = new System.Windows.Forms.PictureBox();
            this.gamePlayerR2_PictureBox = new System.Windows.Forms.PictureBox();
            this.gamePlayerR1_PictureBox = new System.Windows.Forms.PictureBox();
            this.Result_Panel = new System.Windows.Forms.Panel();
            this.resultBack_Button = new System.Windows.Forms.Button();
            this.resultBlueScore_Label = new System.Windows.Forms.Label();
            this.resultBlue_Label = new System.Windows.Forms.Label();
            this.resultRedScore_Label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.resultRed_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameBullet_Label = new System.Windows.Forms.Label();
            this.gameBlueScore_Label = new System.Windows.Forms.Label();
            this.gameRedScore_Label = new System.Windows.Forms.Label();
            this.ChangeTeam_Panel = new System.Windows.Forms.Panel();
            this.changeTeamRefuse_Button = new System.Windows.Forms.Button();
            this.changeTeamAccept_Button = new System.Windows.Forms.Button();
            this.changeTeamUser_Label = new System.Windows.Forms.Label();
            this.changeTeam_Label = new System.Windows.Forms.Label();
            this.ChangeCheck_Panel = new System.Windows.Forms.Panel();
            this.changeCheckNOK_Button = new System.Windows.Forms.Button();
            this.changeCheckOK_Button = new System.Windows.Forms.Button();
            this.changeCheckUser_Label = new System.Windows.Forms.Label();
            this.changeCheck_Label = new System.Windows.Forms.Label();
            this.illustrate_Button = new System.Windows.Forms.Button();
            this.roomLeave_Button = new System.Windows.Forms.Button();
            this.roomReady_Button = new System.Windows.Forms.Button();
            this.roomPlayerB2_Label = new System.Windows.Forms.Label();
            this.roomPlayerB1_Label = new System.Windows.Forms.Label();
            this.roomPlayerR2_Label = new System.Windows.Forms.Label();
            this.roomPlayerR1_Label = new System.Windows.Forms.Label();
            this.roomMessage_TextBox = new System.Windows.Forms.TextBox();
            this.roomMessage_ListBox = new System.Windows.Forms.ListBox();
            this.roomPlayerR1Name_Label = new System.Windows.Forms.Label();
            this.roomPlayerB1Name_Label = new System.Windows.Forms.Label();
            this.roomPlayerR2Name_Label = new System.Windows.Forms.Label();
            this.roomPlayerB2Name_Label = new System.Windows.Forms.Label();
            this.createRoom_GroupBox = new System.Windows.Forms.GroupBox();
            this.lobbyJoinRoom_Button = new System.Windows.Forms.Button();
            this.lobbyCreateRoom_Button = new System.Windows.Forms.Button();
            this.lobbyLogOut_Button = new System.Windows.Forms.Button();
            this.lobbyCreateCencel_Button = new System.Windows.Forms.Button();
            this.lobbyCreateOK_Button = new System.Windows.Forms.Button();
            this.lobbyCreateName_TextBox = new System.Windows.Forms.TextBox();
            this.lobbyOnlineUser_Label = new System.Windows.Forms.Label();
            this.lobbyOnlineUser_ListBox = new System.Windows.Forms.ListBox();
            this.lobbyBroadcast_Button = new System.Windows.Forms.Button();
            this.lobbyMessage_TextBox = new System.Windows.Forms.TextBox();
            this.lobbyMessage_ListBox = new System.Windows.Forms.ListBox();
            this.lobbyRoom_ListBox = new System.Windows.Forms.ListBox();
            this.lobbyRefresh_Button = new System.Windows.Forms.Button();
            this.lobbyRoom_Label = new System.Windows.Forms.Label();
            this.serverPort_TextBox = new System.Windows.Forms.TextBox();
            this.serverPort_Label = new System.Windows.Forms.Label();
            this.serverIP_TextBox = new System.Windows.Forms.TextBox();
            this.serverIP_Label = new System.Windows.Forms.Label();
            this.login_Button = new System.Windows.Forms.Button();
            this.userName_TextBox = new System.Windows.Forms.TextBox();
            this.userName_Label = new System.Windows.Forms.Label();
            this.gaming = new System.Windows.Forms.Button();
            this.Login_Panel.SuspendLayout();
            this.Lobby_Panel.SuspendLayout();
            this.Room_Panel.SuspendLayout();
            this.Game_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameWall_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerB2_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerB1_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerR2_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerR1_PictureBox)).BeginInit();
            this.Result_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ChangeTeam_Panel.SuspendLayout();
            this.ChangeCheck_Panel.SuspendLayout();
            this.createRoom_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackgroundImage = global::FinalProject.Properties.Resources.homePage;
            this.Login_Panel.Controls.Add(this.Lobby_Panel);
            this.Login_Panel.Controls.Add(this.serverPort_TextBox);
            this.Login_Panel.Controls.Add(this.serverPort_Label);
            this.Login_Panel.Controls.Add(this.serverIP_TextBox);
            this.Login_Panel.Controls.Add(this.serverIP_Label);
            this.Login_Panel.Controls.Add(this.login_Button);
            this.Login_Panel.Controls.Add(this.userName_TextBox);
            this.Login_Panel.Controls.Add(this.userName_Label);
            this.Login_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Panel.Location = new System.Drawing.Point(0, 0);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(834, 612);
            this.Login_Panel.TabIndex = 25;
            // 
            // Lobby_Panel
            // 
            this.Lobby_Panel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Lobby_Panel.Controls.Add(this.Room_Panel);
            this.Lobby_Panel.Controls.Add(this.createRoom_GroupBox);
            this.Lobby_Panel.Controls.Add(this.lobbyCreateCencel_Button);
            this.Lobby_Panel.Controls.Add(this.lobbyCreateOK_Button);
            this.Lobby_Panel.Controls.Add(this.lobbyCreateName_TextBox);
            this.Lobby_Panel.Controls.Add(this.lobbyOnlineUser_Label);
            this.Lobby_Panel.Controls.Add(this.lobbyOnlineUser_ListBox);
            this.Lobby_Panel.Controls.Add(this.lobbyBroadcast_Button);
            this.Lobby_Panel.Controls.Add(this.lobbyMessage_TextBox);
            this.Lobby_Panel.Controls.Add(this.lobbyMessage_ListBox);
            this.Lobby_Panel.Controls.Add(this.lobbyRoom_ListBox);
            this.Lobby_Panel.Controls.Add(this.lobbyRefresh_Button);
            this.Lobby_Panel.Controls.Add(this.lobbyRoom_Label);
            this.Lobby_Panel.Location = new System.Drawing.Point(0, 0);
            this.Lobby_Panel.Name = "Lobby_Panel";
            this.Lobby_Panel.Size = new System.Drawing.Size(834, 612);
            this.Lobby_Panel.TabIndex = 39;
            // 
            // Room_Panel
            // 
            this.Room_Panel.Controls.Add(this.Game_Panel);
            this.Room_Panel.Controls.Add(this.ChangeTeam_Panel);
            this.Room_Panel.Controls.Add(this.ChangeCheck_Panel);
            this.Room_Panel.Controls.Add(this.illustrate_Button);
            this.Room_Panel.Controls.Add(this.roomLeave_Button);
            this.Room_Panel.Controls.Add(this.roomReady_Button);
            this.Room_Panel.Controls.Add(this.roomPlayerB2_Label);
            this.Room_Panel.Controls.Add(this.roomPlayerB1_Label);
            this.Room_Panel.Controls.Add(this.roomPlayerR2_Label);
            this.Room_Panel.Controls.Add(this.roomPlayerR1_Label);
            this.Room_Panel.Controls.Add(this.roomMessage_TextBox);
            this.Room_Panel.Controls.Add(this.roomMessage_ListBox);
            this.Room_Panel.Controls.Add(this.roomPlayerR1Name_Label);
            this.Room_Panel.Controls.Add(this.roomPlayerB1Name_Label);
            this.Room_Panel.Controls.Add(this.roomPlayerR2Name_Label);
            this.Room_Panel.Controls.Add(this.roomPlayerB2Name_Label);
            this.Room_Panel.Location = new System.Drawing.Point(0, 0);
            this.Room_Panel.Name = "Room_Panel";
            this.Room_Panel.Size = new System.Drawing.Size(834, 612);
            this.Room_Panel.TabIndex = 25;
            this.Room_Panel.Click += new System.EventHandler(this.roomPlayer_Label_Click);
            // 
            // Game_Panel
            // 
            this.Game_Panel.BackColor = System.Drawing.Color.LavenderBlush;
            this.Game_Panel.Controls.Add(this.gameWall_Label);
            this.Game_Panel.Controls.Add(this.gameWall_PictureBox);
            this.Game_Panel.Controls.Add(this.gameTime_Label);
            this.Game_Panel.Controls.Add(this.gamePlayerB2_PictureBox);
            this.Game_Panel.Controls.Add(this.gamePlayerB1_PictureBox);
            this.Game_Panel.Controls.Add(this.gamePlayerR2_PictureBox);
            this.Game_Panel.Controls.Add(this.gamePlayerR1_PictureBox);
            this.Game_Panel.Controls.Add(this.Result_Panel);
            this.Game_Panel.Controls.Add(this.gameBullet_Label);
            this.Game_Panel.Controls.Add(this.gameBlueScore_Label);
            this.Game_Panel.Controls.Add(this.gameRedScore_Label);
            this.Game_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game_Panel.Location = new System.Drawing.Point(0, 0);
            this.Game_Panel.Name = "Game_Panel";
            this.Game_Panel.Size = new System.Drawing.Size(834, 612);
            this.Game_Panel.TabIndex = 34;
            // 
            // gameWall_Label
            // 
            this.gameWall_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameWall_Label.Location = new System.Drawing.Point(1, 126);
            this.gameWall_Label.Name = "gameWall_Label";
            this.gameWall_Label.Size = new System.Drawing.Size(833, 71);
            this.gameWall_Label.TabIndex = 39;
            // 
            // gameWall_PictureBox
            // 
            this.gameWall_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.gameWall_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gameWall_PictureBox.Image")));
            this.gameWall_PictureBox.Location = new System.Drawing.Point(1800, 1800);
            this.gameWall_PictureBox.Name = "gameWall_PictureBox";
            this.gameWall_PictureBox.Padding = new System.Windows.Forms.Padding(2);
            this.gameWall_PictureBox.Size = new System.Drawing.Size(1220, 198);
            this.gameWall_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameWall_PictureBox.TabIndex = 38;
            this.gameWall_PictureBox.TabStop = false;
            // 
            // gameTime_Label
            // 
            this.gameTime_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameTime_Label.ForeColor = System.Drawing.Color.Purple;
            this.gameTime_Label.Location = new System.Drawing.Point(387, 9);
            this.gameTime_Label.Name = "gameTime_Label";
            this.gameTime_Label.Size = new System.Drawing.Size(57, 23);
            this.gameTime_Label.TabIndex = 37;
            this.gameTime_Label.Text = "180";
            this.gameTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamePlayerB2_PictureBox
            // 
            this.gamePlayerB2_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.gamePlayerB2_PictureBox.Image = global::FinalProject.Properties.Resources.runB2;
            this.gamePlayerB2_PictureBox.Location = new System.Drawing.Point(560, 400);
            this.gamePlayerB2_PictureBox.Name = "gamePlayerB2_PictureBox";
            this.gamePlayerB2_PictureBox.Padding = new System.Windows.Forms.Padding(2);
            this.gamePlayerB2_PictureBox.Size = new System.Drawing.Size(60, 108);
            this.gamePlayerB2_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePlayerB2_PictureBox.TabIndex = 36;
            this.gamePlayerB2_PictureBox.TabStop = false;
            // 
            // gamePlayerB1_PictureBox
            // 
            this.gamePlayerB1_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.gamePlayerB1_PictureBox.Image = global::FinalProject.Properties.Resources.runB1;
            this.gamePlayerB1_PictureBox.Location = new System.Drawing.Point(200, 400);
            this.gamePlayerB1_PictureBox.Name = "gamePlayerB1_PictureBox";
            this.gamePlayerB1_PictureBox.Padding = new System.Windows.Forms.Padding(2);
            this.gamePlayerB1_PictureBox.Size = new System.Drawing.Size(60, 108);
            this.gamePlayerB1_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePlayerB1_PictureBox.TabIndex = 35;
            this.gamePlayerB1_PictureBox.TabStop = false;
            // 
            // gamePlayerR2_PictureBox
            // 
            this.gamePlayerR2_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.gamePlayerR2_PictureBox.Image = global::FinalProject.Properties.Resources.standA2;
            this.gamePlayerR2_PictureBox.Location = new System.Drawing.Point(480, 20);
            this.gamePlayerR2_PictureBox.Name = "gamePlayerR2_PictureBox";
            this.gamePlayerR2_PictureBox.Padding = new System.Windows.Forms.Padding(2);
            this.gamePlayerR2_PictureBox.Size = new System.Drawing.Size(69, 103);
            this.gamePlayerR2_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePlayerR2_PictureBox.TabIndex = 34;
            this.gamePlayerR2_PictureBox.TabStop = false;
            // 
            // gamePlayerR1_PictureBox
            // 
            this.gamePlayerR1_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.gamePlayerR1_PictureBox.Image = global::FinalProject.Properties.Resources.standA1;
            this.gamePlayerR1_PictureBox.Location = new System.Drawing.Point(280, 20);
            this.gamePlayerR1_PictureBox.Name = "gamePlayerR1_PictureBox";
            this.gamePlayerR1_PictureBox.Padding = new System.Windows.Forms.Padding(2);
            this.gamePlayerR1_PictureBox.Size = new System.Drawing.Size(68, 103);
            this.gamePlayerR1_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePlayerR1_PictureBox.TabIndex = 33;
            this.gamePlayerR1_PictureBox.TabStop = false;
            // 
            // Result_Panel
            // 
            this.Result_Panel.BackColor = System.Drawing.Color.White;
            this.Result_Panel.Controls.Add(this.gaming);
            this.Result_Panel.Controls.Add(this.resultBack_Button);
            this.Result_Panel.Controls.Add(this.resultBlueScore_Label);
            this.Result_Panel.Controls.Add(this.resultBlue_Label);
            this.Result_Panel.Controls.Add(this.resultRedScore_Label);
            this.Result_Panel.Controls.Add(this.pictureBox2);
            this.Result_Panel.Controls.Add(this.resultRed_Label);
            this.Result_Panel.Controls.Add(this.pictureBox1);
            this.Result_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result_Panel.Location = new System.Drawing.Point(0, 0);
            this.Result_Panel.Name = "Result_Panel";
            this.Result_Panel.Size = new System.Drawing.Size(834, 612);
            this.Result_Panel.TabIndex = 31;
            // 
            // resultBack_Button
            // 
            this.resultBack_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resultBack_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultBack_Button.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultBack_Button.Location = new System.Drawing.Point(317, 455);
            this.resultBack_Button.Name = "resultBack_Button";
            this.resultBack_Button.Size = new System.Drawing.Size(201, 85);
            this.resultBack_Button.TabIndex = 30;
            this.resultBack_Button.Text = "回到房間";
            this.resultBack_Button.UseVisualStyleBackColor = false;
            this.resultBack_Button.Click += new System.EventHandler(this.resaultBack_Button_Click);
            // 
            // resultBlueScore_Label
            // 
            this.resultBlueScore_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.resultBlueScore_Label.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultBlueScore_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.resultBlueScore_Label.Location = new System.Drawing.Point(524, 247);
            this.resultBlueScore_Label.Name = "resultBlueScore_Label";
            this.resultBlueScore_Label.Size = new System.Drawing.Size(222, 113);
            this.resultBlueScore_Label.TabIndex = 28;
            this.resultBlueScore_Label.Text = "321";
            this.resultBlueScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultBlue_Label
            // 
            this.resultBlue_Label.AutoSize = true;
            this.resultBlue_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.resultBlue_Label.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultBlue_Label.ForeColor = System.Drawing.Color.Blue;
            this.resultBlue_Label.Location = new System.Drawing.Point(550, 105);
            this.resultBlue_Label.Name = "resultBlue_Label";
            this.resultBlue_Label.Size = new System.Drawing.Size(163, 81);
            this.resultBlue_Label.TabIndex = 27;
            this.resultBlue_Label.Text = "藍隊";
            // 
            // resultRedScore_Label
            // 
            this.resultRedScore_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resultRedScore_Label.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultRedScore_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.resultRedScore_Label.Location = new System.Drawing.Point(100, 247);
            this.resultRedScore_Label.Name = "resultRedScore_Label";
            this.resultRedScore_Label.Size = new System.Drawing.Size(222, 113);
            this.resultRedScore_Label.TabIndex = 29;
            this.resultRedScore_Label.Text = "123";
            this.resultRedScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox2.Location = new System.Drawing.Point(416, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 600);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // resultRed_Label
            // 
            this.resultRed_Label.AutoSize = true;
            this.resultRed_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resultRed_Label.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultRed_Label.ForeColor = System.Drawing.Color.Red;
            this.resultRed_Label.Location = new System.Drawing.Point(122, 105);
            this.resultRed_Label.Name = "resultRed_Label";
            this.resultRed_Label.Size = new System.Drawing.Size(163, 81);
            this.resultRed_Label.TabIndex = 26;
            this.resultRed_Label.Text = "紅隊";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 600);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // gameBullet_Label
            // 
            this.gameBullet_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameBullet_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameBullet_Label.Location = new System.Drawing.Point(779, 41);
            this.gameBullet_Label.Name = "gameBullet_Label";
            this.gameBullet_Label.Size = new System.Drawing.Size(46, 20);
            this.gameBullet_Label.TabIndex = 30;
            this.gameBullet_Label.Text = "9 / 9";
            // 
            // gameBlueScore_Label
            // 
            this.gameBlueScore_Label.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameBlueScore_Label.ForeColor = System.Drawing.Color.Blue;
            this.gameBlueScore_Label.Location = new System.Drawing.Point(775, 5);
            this.gameBlueScore_Label.Name = "gameBlueScore_Label";
            this.gameBlueScore_Label.Size = new System.Drawing.Size(51, 26);
            this.gameBlueScore_Label.TabIndex = 22;
            this.gameBlueScore_Label.Text = "0";
            this.gameBlueScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameRedScore_Label
            // 
            this.gameRedScore_Label.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameRedScore_Label.ForeColor = System.Drawing.Color.Red;
            this.gameRedScore_Label.Location = new System.Drawing.Point(12, 5);
            this.gameRedScore_Label.Name = "gameRedScore_Label";
            this.gameRedScore_Label.Size = new System.Drawing.Size(51, 26);
            this.gameRedScore_Label.TabIndex = 21;
            this.gameRedScore_Label.Text = "0";
            this.gameRedScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeTeam_Panel
            // 
            this.ChangeTeam_Panel.BackColor = System.Drawing.Color.Azure;
            this.ChangeTeam_Panel.Controls.Add(this.changeTeamRefuse_Button);
            this.ChangeTeam_Panel.Controls.Add(this.changeTeamAccept_Button);
            this.ChangeTeam_Panel.Controls.Add(this.changeTeamUser_Label);
            this.ChangeTeam_Panel.Controls.Add(this.changeTeam_Label);
            this.ChangeTeam_Panel.Location = new System.Drawing.Point(840, 200);
            this.ChangeTeam_Panel.Name = "ChangeTeam_Panel";
            this.ChangeTeam_Panel.Size = new System.Drawing.Size(305, 168);
            this.ChangeTeam_Panel.TabIndex = 37;
            // 
            // changeTeamRefuse_Button
            // 
            this.changeTeamRefuse_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.changeTeamRefuse_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeTeamRefuse_Button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeTeamRefuse_Button.ForeColor = System.Drawing.Color.White;
            this.changeTeamRefuse_Button.Location = new System.Drawing.Point(172, 108);
            this.changeTeamRefuse_Button.Name = "changeTeamRefuse_Button";
            this.changeTeamRefuse_Button.Size = new System.Drawing.Size(68, 37);
            this.changeTeamRefuse_Button.TabIndex = 7;
            this.changeTeamRefuse_Button.Text = "拒絕";
            this.changeTeamRefuse_Button.UseVisualStyleBackColor = false;
            this.changeTeamRefuse_Button.Click += new System.EventHandler(this.changeTeamRefuse_Button_Click);
            // 
            // changeTeamAccept_Button
            // 
            this.changeTeamAccept_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.changeTeamAccept_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeTeamAccept_Button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeTeamAccept_Button.ForeColor = System.Drawing.Color.White;
            this.changeTeamAccept_Button.Location = new System.Drawing.Point(67, 108);
            this.changeTeamAccept_Button.Name = "changeTeamAccept_Button";
            this.changeTeamAccept_Button.Size = new System.Drawing.Size(68, 37);
            this.changeTeamAccept_Button.TabIndex = 6;
            this.changeTeamAccept_Button.Text = "同意";
            this.changeTeamAccept_Button.UseVisualStyleBackColor = false;
            this.changeTeamAccept_Button.Click += new System.EventHandler(this.changeTeamAccept_Button_Click);
            // 
            // changeTeamUser_Label
            // 
            this.changeTeamUser_Label.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeTeamUser_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.changeTeamUser_Label.Location = new System.Drawing.Point(3, 23);
            this.changeTeamUser_Label.Name = "changeTeamUser_Label";
            this.changeTeamUser_Label.Size = new System.Drawing.Size(299, 35);
            this.changeTeamUser_Label.TabIndex = 5;
            this.changeTeamUser_Label.Text = "TEST";
            this.changeTeamUser_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeTeam_Label
            // 
            this.changeTeam_Label.AutoSize = true;
            this.changeTeam_Label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeTeam_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.changeTeam_Label.Location = new System.Drawing.Point(50, 63);
            this.changeTeam_Label.Name = "changeTeam_Label";
            this.changeTeam_Label.Size = new System.Drawing.Size(206, 31);
            this.changeTeam_Label.TabIndex = 4;
            this.changeTeam_Label.Text = "請求與你交換隊伍";
            // 
            // ChangeCheck_Panel
            // 
            this.ChangeCheck_Panel.BackColor = System.Drawing.Color.Azure;
            this.ChangeCheck_Panel.Controls.Add(this.changeCheckNOK_Button);
            this.ChangeCheck_Panel.Controls.Add(this.changeCheckOK_Button);
            this.ChangeCheck_Panel.Controls.Add(this.changeCheckUser_Label);
            this.ChangeCheck_Panel.Controls.Add(this.changeCheck_Label);
            this.ChangeCheck_Panel.Location = new System.Drawing.Point(275, 200);
            this.ChangeCheck_Panel.Name = "ChangeCheck_Panel";
            this.ChangeCheck_Panel.Size = new System.Drawing.Size(305, 168);
            this.ChangeCheck_Panel.TabIndex = 38;
            this.ChangeCheck_Panel.Visible = false;
            // 
            // changeCheckNOK_Button
            // 
            this.changeCheckNOK_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.changeCheckNOK_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCheckNOK_Button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeCheckNOK_Button.ForeColor = System.Drawing.Color.White;
            this.changeCheckNOK_Button.Location = new System.Drawing.Point(172, 108);
            this.changeCheckNOK_Button.Name = "changeCheckNOK_Button";
            this.changeCheckNOK_Button.Size = new System.Drawing.Size(68, 37);
            this.changeCheckNOK_Button.TabIndex = 7;
            this.changeCheckNOK_Button.Text = "取消";
            this.changeCheckNOK_Button.UseVisualStyleBackColor = false;
            this.changeCheckNOK_Button.Click += new System.EventHandler(this.changeCheckNOK_Button_Click);
            // 
            // changeCheckOK_Button
            // 
            this.changeCheckOK_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.changeCheckOK_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeCheckOK_Button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeCheckOK_Button.ForeColor = System.Drawing.Color.White;
            this.changeCheckOK_Button.Location = new System.Drawing.Point(67, 108);
            this.changeCheckOK_Button.Name = "changeCheckOK_Button";
            this.changeCheckOK_Button.Size = new System.Drawing.Size(68, 37);
            this.changeCheckOK_Button.TabIndex = 6;
            this.changeCheckOK_Button.Text = "確定";
            this.changeCheckOK_Button.UseVisualStyleBackColor = false;
            this.changeCheckOK_Button.Click += new System.EventHandler(this.changeCheckOK_Button_Click);
            // 
            // changeCheckUser_Label
            // 
            this.changeCheckUser_Label.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeCheckUser_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.changeCheckUser_Label.Location = new System.Drawing.Point(3, 23);
            this.changeCheckUser_Label.Name = "changeCheckUser_Label";
            this.changeCheckUser_Label.Size = new System.Drawing.Size(299, 35);
            this.changeCheckUser_Label.TabIndex = 5;
            this.changeCheckUser_Label.Text = "TEST";
            this.changeCheckUser_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeCheck_Label
            // 
            this.changeCheck_Label.AutoSize = true;
            this.changeCheck_Label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeCheck_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.changeCheck_Label.Location = new System.Drawing.Point(50, 63);
            this.changeCheck_Label.Name = "changeCheck_Label";
            this.changeCheck_Label.Size = new System.Drawing.Size(206, 31);
            this.changeCheck_Label.TabIndex = 4;
            this.changeCheck_Label.Text = "是否與他交換隊伍";
            // 
            // illustrate_Button
            // 
            this.illustrate_Button.BackgroundImage = global::FinalProject.Properties.Resources.illustrate;
            this.illustrate_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.illustrate_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.illustrate_Button.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.illustrate_Button.Location = new System.Drawing.Point(3, 549);
            this.illustrate_Button.Name = "illustrate_Button";
            this.illustrate_Button.Size = new System.Drawing.Size(60, 60);
            this.illustrate_Button.TabIndex = 35;
            this.illustrate_Button.UseVisualStyleBackColor = true;
            this.illustrate_Button.Click += new System.EventHandler(this.illustrate_Button_Click);
            this.illustrate_Button.Paint += new System.Windows.Forms.PaintEventHandler(this.illustrate_Button_Paint);
            // 
            // roomLeave_Button
            // 
            this.roomLeave_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.roomLeave_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomLeave_Button.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomLeave_Button.ForeColor = System.Drawing.Color.White;
            this.roomLeave_Button.Location = new System.Drawing.Point(501, 494);
            this.roomLeave_Button.Name = "roomLeave_Button";
            this.roomLeave_Button.Size = new System.Drawing.Size(227, 76);
            this.roomLeave_Button.TabIndex = 33;
            this.roomLeave_Button.Text = "離   開";
            this.roomLeave_Button.UseVisualStyleBackColor = false;
            this.roomLeave_Button.Click += new System.EventHandler(this.roomLeave_Button_Click);
            // 
            // roomReady_Button
            // 
            this.roomReady_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.roomReady_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomReady_Button.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomReady_Button.ForeColor = System.Drawing.Color.White;
            this.roomReady_Button.Location = new System.Drawing.Point(114, 494);
            this.roomReady_Button.Name = "roomReady_Button";
            this.roomReady_Button.Size = new System.Drawing.Size(227, 76);
            this.roomReady_Button.TabIndex = 32;
            this.roomReady_Button.Text = "準   備";
            this.roomReady_Button.UseVisualStyleBackColor = false;
            this.roomReady_Button.Click += new System.EventHandler(this.roomReady_Button_Click);
            // 
            // roomPlayerB2_Label
            // 
            this.roomPlayerB2_Label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roomPlayerB2_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomPlayerB2_Label.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerB2_Label.ForeColor = System.Drawing.Color.White;
            this.roomPlayerB2_Label.Location = new System.Drawing.Point(676, 352);
            this.roomPlayerB2_Label.Name = "roomPlayerB2_Label";
            this.roomPlayerB2_Label.Size = new System.Drawing.Size(62, 80);
            this.roomPlayerB2_Label.TabIndex = 31;
            this.roomPlayerB2_Label.Text = "B2";
            this.roomPlayerB2_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomPlayerB2_Label.Click += new System.EventHandler(this.roomPlayer_Label_Click);
            // 
            // roomPlayerB1_Label
            // 
            this.roomPlayerB1_Label.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roomPlayerB1_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomPlayerB1_Label.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerB1_Label.ForeColor = System.Drawing.Color.White;
            this.roomPlayerB1_Label.Location = new System.Drawing.Point(487, 350);
            this.roomPlayerB1_Label.Name = "roomPlayerB1_Label";
            this.roomPlayerB1_Label.Size = new System.Drawing.Size(62, 80);
            this.roomPlayerB1_Label.TabIndex = 30;
            this.roomPlayerB1_Label.Text = "B1";
            this.roomPlayerB1_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomPlayerB1_Label.Click += new System.EventHandler(this.roomPlayer_Label_Click);
            // 
            // roomPlayerR2_Label
            // 
            this.roomPlayerR2_Label.BackColor = System.Drawing.Color.LightCoral;
            this.roomPlayerR2_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomPlayerR2_Label.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerR2_Label.ForeColor = System.Drawing.Color.White;
            this.roomPlayerR2_Label.Location = new System.Drawing.Point(293, 350);
            this.roomPlayerR2_Label.Name = "roomPlayerR2_Label";
            this.roomPlayerR2_Label.Size = new System.Drawing.Size(62, 80);
            this.roomPlayerR2_Label.TabIndex = 29;
            this.roomPlayerR2_Label.Text = "R2";
            this.roomPlayerR2_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomPlayerR1_Label
            // 
            this.roomPlayerR1_Label.BackColor = System.Drawing.Color.LightCoral;
            this.roomPlayerR1_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomPlayerR1_Label.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerR1_Label.ForeColor = System.Drawing.Color.White;
            this.roomPlayerR1_Label.Location = new System.Drawing.Point(97, 350);
            this.roomPlayerR1_Label.Name = "roomPlayerR1_Label";
            this.roomPlayerR1_Label.Size = new System.Drawing.Size(62, 80);
            this.roomPlayerR1_Label.TabIndex = 28;
            this.roomPlayerR1_Label.Tag = "";
            this.roomPlayerR1_Label.Text = "R1";
            this.roomPlayerR1_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomPlayerR1_Label.Click += new System.EventHandler(this.roomPlayer_Label_Click);
            // 
            // roomMessage_TextBox
            // 
            this.roomMessage_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomMessage_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.roomMessage_TextBox.Location = new System.Drawing.Point(29, 256);
            this.roomMessage_TextBox.Name = "roomMessage_TextBox";
            this.roomMessage_TextBox.Size = new System.Drawing.Size(776, 29);
            this.roomMessage_TextBox.TabIndex = 26;
            this.roomMessage_TextBox.Text = "按下 Enter 鍵輸入";
            this.roomMessage_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roomMessage_TextBox_MouseClick);
            this.roomMessage_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roomMessage_TextBox_KeyDown);
            this.roomMessage_TextBox.Leave += new System.EventHandler(this.roomMessage_TextBox_Leave);
            // 
            // roomMessage_ListBox
            // 
            this.roomMessage_ListBox.BackColor = System.Drawing.Color.Linen;
            this.roomMessage_ListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomMessage_ListBox.ForeColor = System.Drawing.Color.Black;
            this.roomMessage_ListBox.FormattingEnabled = true;
            this.roomMessage_ListBox.ItemHeight = 20;
            this.roomMessage_ListBox.Location = new System.Drawing.Point(29, 42);
            this.roomMessage_ListBox.Name = "roomMessage_ListBox";
            this.roomMessage_ListBox.Size = new System.Drawing.Size(776, 204);
            this.roomMessage_ListBox.TabIndex = 25;
            // 
            // roomPlayerR1Name_Label
            // 
            this.roomPlayerR1Name_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerR1Name_Label.Location = new System.Drawing.Point(44, 438);
            this.roomPlayerR1Name_Label.Name = "roomPlayerR1Name_Label";
            this.roomPlayerR1Name_Label.Size = new System.Drawing.Size(169, 23);
            this.roomPlayerR1Name_Label.TabIndex = 39;
            this.roomPlayerR1Name_Label.Text = "Empty";
            this.roomPlayerR1Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomPlayerB1Name_Label
            // 
            this.roomPlayerB1Name_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerB1Name_Label.Location = new System.Drawing.Point(434, 438);
            this.roomPlayerB1Name_Label.Name = "roomPlayerB1Name_Label";
            this.roomPlayerB1Name_Label.Size = new System.Drawing.Size(169, 20);
            this.roomPlayerB1Name_Label.TabIndex = 41;
            this.roomPlayerB1Name_Label.Text = "Empty";
            this.roomPlayerB1Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomPlayerR2Name_Label
            // 
            this.roomPlayerR2Name_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerR2Name_Label.Location = new System.Drawing.Point(239, 438);
            this.roomPlayerR2Name_Label.Name = "roomPlayerR2Name_Label";
            this.roomPlayerR2Name_Label.Size = new System.Drawing.Size(169, 20);
            this.roomPlayerR2Name_Label.TabIndex = 40;
            this.roomPlayerR2Name_Label.Text = "Empty";
            this.roomPlayerR2Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomPlayerB2Name_Label
            // 
            this.roomPlayerB2Name_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomPlayerB2Name_Label.Location = new System.Drawing.Point(624, 438);
            this.roomPlayerB2Name_Label.Name = "roomPlayerB2Name_Label";
            this.roomPlayerB2Name_Label.Size = new System.Drawing.Size(169, 20);
            this.roomPlayerB2Name_Label.TabIndex = 42;
            this.roomPlayerB2Name_Label.Text = "Empty";
            this.roomPlayerB2Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createRoom_GroupBox
            // 
            this.createRoom_GroupBox.Controls.Add(this.lobbyJoinRoom_Button);
            this.createRoom_GroupBox.Controls.Add(this.lobbyCreateRoom_Button);
            this.createRoom_GroupBox.Controls.Add(this.lobbyLogOut_Button);
            this.createRoom_GroupBox.Location = new System.Drawing.Point(602, 512);
            this.createRoom_GroupBox.Name = "createRoom_GroupBox";
            this.createRoom_GroupBox.Size = new System.Drawing.Size(220, 88);
            this.createRoom_GroupBox.TabIndex = 44;
            this.createRoom_GroupBox.TabStop = false;
            // 
            // lobbyJoinRoom_Button
            // 
            this.lobbyJoinRoom_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lobbyJoinRoom_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyJoinRoom_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyJoinRoom_Button.ForeColor = System.Drawing.Color.White;
            this.lobbyJoinRoom_Button.Location = new System.Drawing.Point(76, 8);
            this.lobbyJoinRoom_Button.Name = "lobbyJoinRoom_Button";
            this.lobbyJoinRoom_Button.Size = new System.Drawing.Size(68, 80);
            this.lobbyJoinRoom_Button.TabIndex = 9;
            this.lobbyJoinRoom_Button.Text = "加入\r\n房間";
            this.lobbyJoinRoom_Button.UseVisualStyleBackColor = false;
            this.lobbyJoinRoom_Button.Click += new System.EventHandler(this.lobbyJoinRoom_Button_Click);
            // 
            // lobbyCreateRoom_Button
            // 
            this.lobbyCreateRoom_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lobbyCreateRoom_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyCreateRoom_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyCreateRoom_Button.ForeColor = System.Drawing.Color.White;
            this.lobbyCreateRoom_Button.Location = new System.Drawing.Point(2, 8);
            this.lobbyCreateRoom_Button.Name = "lobbyCreateRoom_Button";
            this.lobbyCreateRoom_Button.Size = new System.Drawing.Size(68, 81);
            this.lobbyCreateRoom_Button.TabIndex = 8;
            this.lobbyCreateRoom_Button.Text = "創建\r\n房間";
            this.lobbyCreateRoom_Button.UseVisualStyleBackColor = false;
            this.lobbyCreateRoom_Button.Click += new System.EventHandler(this.lobbyCreateRoom_Button_Click);
            // 
            // lobbyLogOut_Button
            // 
            this.lobbyLogOut_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lobbyLogOut_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyLogOut_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyLogOut_Button.ForeColor = System.Drawing.Color.White;
            this.lobbyLogOut_Button.Location = new System.Drawing.Point(150, 8);
            this.lobbyLogOut_Button.Name = "lobbyLogOut_Button";
            this.lobbyLogOut_Button.Size = new System.Drawing.Size(68, 80);
            this.lobbyLogOut_Button.TabIndex = 10;
            this.lobbyLogOut_Button.Text = "登出";
            this.lobbyLogOut_Button.UseVisualStyleBackColor = false;
            this.lobbyLogOut_Button.Click += new System.EventHandler(this.lobbyLogOut_Button_Click);
            // 
            // lobbyCreateCencel_Button
            // 
            this.lobbyCreateCencel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lobbyCreateCencel_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyCreateCencel_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyCreateCencel_Button.ForeColor = System.Drawing.Color.White;
            this.lobbyCreateCencel_Button.Location = new System.Drawing.Point(732, 560);
            this.lobbyCreateCencel_Button.Name = "lobbyCreateCencel_Button";
            this.lobbyCreateCencel_Button.Size = new System.Drawing.Size(75, 28);
            this.lobbyCreateCencel_Button.TabIndex = 43;
            this.lobbyCreateCencel_Button.Text = "取消";
            this.lobbyCreateCencel_Button.UseVisualStyleBackColor = false;
            this.lobbyCreateCencel_Button.Click += new System.EventHandler(this.lobbyCreateCencel_Button_Click);
            // 
            // lobbyCreateOK_Button
            // 
            this.lobbyCreateOK_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lobbyCreateOK_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyCreateOK_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyCreateOK_Button.ForeColor = System.Drawing.Color.White;
            this.lobbyCreateOK_Button.Location = new System.Drawing.Point(616, 560);
            this.lobbyCreateOK_Button.Name = "lobbyCreateOK_Button";
            this.lobbyCreateOK_Button.Size = new System.Drawing.Size(75, 28);
            this.lobbyCreateOK_Button.TabIndex = 42;
            this.lobbyCreateOK_Button.Text = "確定";
            this.lobbyCreateOK_Button.UseVisualStyleBackColor = false;
            this.lobbyCreateOK_Button.Click += new System.EventHandler(this.lobbyCreateOK_Button_Click);
            // 
            // lobbyCreateName_TextBox
            // 
            this.lobbyCreateName_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyCreateName_TextBox.Location = new System.Drawing.Point(604, 521);
            this.lobbyCreateName_TextBox.Name = "lobbyCreateName_TextBox";
            this.lobbyCreateName_TextBox.Size = new System.Drawing.Size(214, 29);
            this.lobbyCreateName_TextBox.TabIndex = 41;
            // 
            // lobbyOnlineUser_Label
            // 
            this.lobbyOnlineUser_Label.AutoSize = true;
            this.lobbyOnlineUser_Label.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyOnlineUser_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lobbyOnlineUser_Label.Location = new System.Drawing.Point(626, 19);
            this.lobbyOnlineUser_Label.Name = "lobbyOnlineUser_Label";
            this.lobbyOnlineUser_Label.Size = new System.Drawing.Size(177, 40);
            this.lobbyOnlineUser_Label.TabIndex = 40;
            this.lobbyOnlineUser_Label.Text = "線上使用者";
            // 
            // lobbyOnlineUser_ListBox
            // 
            this.lobbyOnlineUser_ListBox.BackColor = System.Drawing.Color.SeaShell;
            this.lobbyOnlineUser_ListBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyOnlineUser_ListBox.FormattingEnabled = true;
            this.lobbyOnlineUser_ListBox.ItemHeight = 26;
            this.lobbyOnlineUser_ListBox.Location = new System.Drawing.Point(603, 62);
            this.lobbyOnlineUser_ListBox.Name = "lobbyOnlineUser_ListBox";
            this.lobbyOnlineUser_ListBox.Size = new System.Drawing.Size(217, 446);
            this.lobbyOnlineUser_ListBox.TabIndex = 39;
            // 
            // lobbyBroadcast_Button
            // 
            this.lobbyBroadcast_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lobbyBroadcast_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyBroadcast_Button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyBroadcast_Button.ForeColor = System.Drawing.Color.White;
            this.lobbyBroadcast_Button.Location = new System.Drawing.Point(22, 568);
            this.lobbyBroadcast_Button.Name = "lobbyBroadcast_Button";
            this.lobbyBroadcast_Button.Size = new System.Drawing.Size(66, 29);
            this.lobbyBroadcast_Button.TabIndex = 38;
            this.lobbyBroadcast_Button.Text = "廣播";
            this.lobbyBroadcast_Button.UseVisualStyleBackColor = false;
            this.lobbyBroadcast_Button.Click += new System.EventHandler(this.lobbySendMessage_Button_Click);
            // 
            // lobbyMessage_TextBox
            // 
            this.lobbyMessage_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyMessage_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.lobbyMessage_TextBox.Location = new System.Drawing.Point(94, 568);
            this.lobbyMessage_TextBox.Name = "lobbyMessage_TextBox";
            this.lobbyMessage_TextBox.Size = new System.Drawing.Size(502, 29);
            this.lobbyMessage_TextBox.TabIndex = 37;
            this.lobbyMessage_TextBox.Text = "按下 Enter 鍵輸入";
            this.lobbyMessage_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lobbyMessage_TextBox_MouseClick);
            this.lobbyMessage_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lobbyMessage_TextBox_KeyDown);
            this.lobbyMessage_TextBox.Leave += new System.EventHandler(this.lobbyMessage_TextBox_Leave);
            // 
            // lobbyMessage_ListBox
            // 
            this.lobbyMessage_ListBox.BackColor = System.Drawing.Color.Linen;
            this.lobbyMessage_ListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.lobbyMessage_ListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyMessage_ListBox.FormattingEnabled = true;
            this.lobbyMessage_ListBox.ItemHeight = 20;
            this.lobbyMessage_ListBox.Location = new System.Drawing.Point(22, 438);
            this.lobbyMessage_ListBox.Name = "lobbyMessage_ListBox";
            this.lobbyMessage_ListBox.Size = new System.Drawing.Size(574, 124);
            this.lobbyMessage_ListBox.TabIndex = 36;
            // 
            // lobbyRoom_ListBox
            // 
            this.lobbyRoom_ListBox.BackColor = System.Drawing.Color.SeaShell;
            this.lobbyRoom_ListBox.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyRoom_ListBox.FormattingEnabled = true;
            this.lobbyRoom_ListBox.ItemHeight = 61;
            this.lobbyRoom_ListBox.Location = new System.Drawing.Point(22, 62);
            this.lobbyRoom_ListBox.Name = "lobbyRoom_ListBox";
            this.lobbyRoom_ListBox.Size = new System.Drawing.Size(574, 370);
            this.lobbyRoom_ListBox.TabIndex = 35;
            // 
            // lobbyRefresh_Button
            // 
            this.lobbyRefresh_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lobbyRefresh_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lobbyRefresh_Button.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyRefresh_Button.ForeColor = System.Drawing.Color.White;
            this.lobbyRefresh_Button.Location = new System.Drawing.Point(523, 16);
            this.lobbyRefresh_Button.Name = "lobbyRefresh_Button";
            this.lobbyRefresh_Button.Size = new System.Drawing.Size(73, 40);
            this.lobbyRefresh_Button.TabIndex = 34;
            this.lobbyRefresh_Button.Text = "刷 新";
            this.lobbyRefresh_Button.UseVisualStyleBackColor = false;
            this.lobbyRefresh_Button.Click += new System.EventHandler(this.lobbyRefresh_Button_Click);
            // 
            // lobbyRoom_Label
            // 
            this.lobbyRoom_Label.AutoSize = true;
            this.lobbyRoom_Label.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lobbyRoom_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lobbyRoom_Label.Location = new System.Drawing.Point(12, 19);
            this.lobbyRoom_Label.Name = "lobbyRoom_Label";
            this.lobbyRoom_Label.Size = new System.Drawing.Size(145, 40);
            this.lobbyRoom_Label.TabIndex = 33;
            this.lobbyRoom_Label.Text = "房間列表";
            // 
            // serverPort_TextBox
            // 
            this.serverPort_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverPort_TextBox.Location = new System.Drawing.Point(464, 319);
            this.serverPort_TextBox.Name = "serverPort_TextBox";
            this.serverPort_TextBox.Size = new System.Drawing.Size(57, 29);
            this.serverPort_TextBox.TabIndex = 38;
            this.serverPort_TextBox.Text = "55555";
            this.serverPort_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serverPort_Label
            // 
            this.serverPort_Label.AutoSize = true;
            this.serverPort_Label.BackColor = System.Drawing.Color.Transparent;
            this.serverPort_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverPort_Label.Location = new System.Drawing.Point(460, 296);
            this.serverPort_Label.Name = "serverPort_Label";
            this.serverPort_Label.Size = new System.Drawing.Size(41, 20);
            this.serverPort_Label.TabIndex = 37;
            this.serverPort_Label.Text = "Port";
            // 
            // serverIP_TextBox
            // 
            this.serverIP_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverIP_TextBox.Location = new System.Drawing.Point(303, 319);
            this.serverIP_TextBox.Name = "serverIP_TextBox";
            this.serverIP_TextBox.Size = new System.Drawing.Size(134, 29);
            this.serverIP_TextBox.TabIndex = 36;
            this.serverIP_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serverIP_Label
            // 
            this.serverIP_Label.AutoSize = true;
            this.serverIP_Label.BackColor = System.Drawing.Color.Transparent;
            this.serverIP_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverIP_Label.Location = new System.Drawing.Point(299, 296);
            this.serverIP_Label.Name = "serverIP_Label";
            this.serverIP_Label.Size = new System.Drawing.Size(76, 20);
            this.serverIP_Label.TabIndex = 35;
            this.serverIP_Label.Text = "伺服器 IP";
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_Button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.login_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.login_Button.Location = new System.Drawing.Point(308, 417);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(216, 40);
            this.login_Button.TabIndex = 31;
            this.login_Button.Text = "登 入 伺 服 器";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userName_TextBox
            // 
            this.userName_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userName_TextBox.Location = new System.Drawing.Point(360, 376);
            this.userName_TextBox.Name = "userName_TextBox";
            this.userName_TextBox.Size = new System.Drawing.Size(183, 29);
            this.userName_TextBox.TabIndex = 32;
            // 
            // userName_Label
            // 
            this.userName_Label.AutoSize = true;
            this.userName_Label.BackColor = System.Drawing.Color.Transparent;
            this.userName_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userName_Label.Location = new System.Drawing.Point(281, 379);
            this.userName_Label.Name = "userName_Label";
            this.userName_Label.Size = new System.Drawing.Size(73, 20);
            this.userName_Label.TabIndex = 33;
            this.userName_Label.Text = "玩家名稱";
            // 
            // gaming
            // 
            this.gaming.Location = new System.Drawing.Point(999, 999);
            this.gaming.Name = "gaming";
            this.gaming.Size = new System.Drawing.Size(19, 16);
            this.gaming.TabIndex = 26;
            this.gaming.UseVisualStyleBackColor = true;
            // 
            // FinalProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.Login_Panel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FinalProject";
            this.Text = "PooPoo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinalProject_FormClosing);
            this.Load += new System.EventHandler(this.FinalProject_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FinalProject_KeyDown);
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            this.Lobby_Panel.ResumeLayout(false);
            this.Lobby_Panel.PerformLayout();
            this.Room_Panel.ResumeLayout(false);
            this.Room_Panel.PerformLayout();
            this.Game_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameWall_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerB2_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerB1_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerR2_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayerR1_PictureBox)).EndInit();
            this.Result_Panel.ResumeLayout(false);
            this.Result_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ChangeTeam_Panel.ResumeLayout(false);
            this.ChangeTeam_Panel.PerformLayout();
            this.ChangeCheck_Panel.ResumeLayout(false);
            this.ChangeCheck_Panel.PerformLayout();
            this.createRoom_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.Panel Lobby_Panel;
        private System.Windows.Forms.GroupBox createRoom_GroupBox;
        private System.Windows.Forms.Button lobbyJoinRoom_Button;
        private System.Windows.Forms.Button lobbyCreateRoom_Button;
        private System.Windows.Forms.Button lobbyLogOut_Button;
        private System.Windows.Forms.Button lobbyCreateCencel_Button;
        private System.Windows.Forms.Button lobbyCreateOK_Button;
        private System.Windows.Forms.TextBox lobbyCreateName_TextBox;
        private System.Windows.Forms.Label lobbyOnlineUser_Label;
        private System.Windows.Forms.ListBox lobbyOnlineUser_ListBox;
        private System.Windows.Forms.Button lobbyBroadcast_Button;
        private System.Windows.Forms.TextBox lobbyMessage_TextBox;
        private System.Windows.Forms.ListBox lobbyMessage_ListBox;
        private System.Windows.Forms.ListBox lobbyRoom_ListBox;
        private System.Windows.Forms.Button lobbyRefresh_Button;
        private System.Windows.Forms.Label lobbyRoom_Label;
        private System.Windows.Forms.TextBox serverPort_TextBox;
        private System.Windows.Forms.Label serverPort_Label;
        private System.Windows.Forms.TextBox serverIP_TextBox;
        private System.Windows.Forms.Label serverIP_Label;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.TextBox userName_TextBox;
        private System.Windows.Forms.Label userName_Label;
        private System.Windows.Forms.Panel Room_Panel;
        private System.Windows.Forms.Button roomLeave_Button;
        private System.Windows.Forms.Button roomReady_Button;
        private System.Windows.Forms.Label roomPlayerB2_Label;
        private System.Windows.Forms.Label roomPlayerB1_Label;
        private System.Windows.Forms.Label roomPlayerR2_Label;
        private System.Windows.Forms.Label roomPlayerR1_Label;
        private System.Windows.Forms.TextBox roomMessage_TextBox;
        private System.Windows.Forms.ListBox roomMessage_ListBox;
        private System.Windows.Forms.Panel Game_Panel;
        private System.Windows.Forms.Label gameBlueScore_Label;
        private System.Windows.Forms.Label gameRedScore_Label;
        private System.Windows.Forms.Button illustrate_Button;
        private System.Windows.Forms.Panel Result_Panel;
        private System.Windows.Forms.Label gameBullet_Label;
        private System.Windows.Forms.Button resultBack_Button;
        private System.Windows.Forms.Label resultBlueScore_Label;
        private System.Windows.Forms.Label resultBlue_Label;
        private System.Windows.Forms.Label resultRedScore_Label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label resultRed_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ChangeTeam_Panel;
        private System.Windows.Forms.Button changeTeamRefuse_Button;
        private System.Windows.Forms.Button changeTeamAccept_Button;
        private System.Windows.Forms.Label changeTeamUser_Label;
        private System.Windows.Forms.Label changeTeam_Label;
        private System.Windows.Forms.Panel ChangeCheck_Panel;
        private System.Windows.Forms.Button changeCheckNOK_Button;
        private System.Windows.Forms.Button changeCheckOK_Button;
        private System.Windows.Forms.Label changeCheckUser_Label;
        private System.Windows.Forms.Label changeCheck_Label;
        private System.Windows.Forms.Label roomPlayerR1Name_Label;
        private System.Windows.Forms.Label roomPlayerB2Name_Label;
        private System.Windows.Forms.Label roomPlayerB1Name_Label;
        private System.Windows.Forms.Label roomPlayerR2Name_Label;
        private System.Windows.Forms.PictureBox gamePlayerR1_PictureBox;
        private System.Windows.Forms.PictureBox gamePlayerB2_PictureBox;
        private System.Windows.Forms.PictureBox gamePlayerB1_PictureBox;
        private System.Windows.Forms.PictureBox gamePlayerR2_PictureBox;
        private System.Windows.Forms.Label gameTime_Label;
        private System.Windows.Forms.Label gameWall_Label;
        private System.Windows.Forms.PictureBox gameWall_PictureBox;
        private System.Windows.Forms.Button gaming;
    }
}

