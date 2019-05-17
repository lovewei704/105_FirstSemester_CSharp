namespace A103223013_FinalTerm_GuessNumber
{
    partial class TCP_GuessNumber
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
            this.userName_Label = new System.Windows.Forms.Label();
            this.login_Button = new System.Windows.Forms.Button();
            this.userName_TextBox = new System.Windows.Forms.TextBox();
            this.serverIP_TextBox = new System.Windows.Forms.TextBox();
            this.serverIP_Label = new System.Windows.Forms.Label();
            this.serverPort_TextBox = new System.Windows.Forms.TextBox();
            this.serverPort_Label = new System.Windows.Forms.Label();
            this.myNumber_TextBox = new System.Windows.Forms.TextBox();
            this.myNumber_Label = new System.Windows.Forms.Label();
            this.guessNumber_TextBox = new System.Windows.Forms.TextBox();
            this.guessNumber_Label = new System.Windows.Forms.Label();
            this.send_Button = new System.Windows.Forms.Button();
            this.otherGuess_Label = new System.Windows.Forms.Label();
            this.myGuess_Label = new System.Windows.Forms.Label();
            this.otherGuess_ListBox = new System.Windows.Forms.ListBox();
            this.myGuess_ListBox = new System.Windows.Forms.ListBox();
            this.onlineUser_ListBox = new System.Windows.Forms.ListBox();
            this.onlineUser_Label = new System.Windows.Forms.Label();
            this.systemMessage_ListBox = new System.Windows.Forms.ListBox();
            this.systemMessage_Label = new System.Windows.Forms.Label();
            this.serverMessage_ListBox = new System.Windows.Forms.ListBox();
            this.serverMessage_Label = new System.Windows.Forms.Label();
            this.lock_Button = new System.Windows.Forms.Button();
            this.otherGuessCount_Label = new System.Windows.Forms.Label();
            this.otherGuessCount_Show = new System.Windows.Forms.Label();
            this.myGuessCount_Label = new System.Windows.Forms.Label();
            this.myGuessCount_Show = new System.Windows.Forms.Label();
            this.restart_Button = new System.Windows.Forms.Button();
            this.ExitGame_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName_Label
            // 
            this.userName_Label.AutoSize = true;
            this.userName_Label.Location = new System.Drawing.Point(300, 18);
            this.userName_Label.Name = "userName_Label";
            this.userName_Label.Size = new System.Drawing.Size(82, 15);
            this.userName_Label.TabIndex = 0;
            this.userName_Label.Text = "User Name : ";
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(308, 49);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(212, 32);
            this.login_Button.TabIndex = 1;
            this.login_Button.Text = "Login Server";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // userName_TextBox
            // 
            this.userName_TextBox.Location = new System.Drawing.Point(388, 15);
            this.userName_TextBox.Name = "userName_TextBox";
            this.userName_TextBox.Size = new System.Drawing.Size(127, 25);
            this.userName_TextBox.TabIndex = 2;
            // 
            // serverIP_TextBox
            // 
            this.serverIP_TextBox.Location = new System.Drawing.Point(106, 17);
            this.serverIP_TextBox.Name = "serverIP_TextBox";
            this.serverIP_TextBox.Size = new System.Drawing.Size(160, 25);
            this.serverIP_TextBox.TabIndex = 4;
            // 
            // serverIP_Label
            // 
            this.serverIP_Label.AutoSize = true;
            this.serverIP_Label.Location = new System.Drawing.Point(26, 20);
            this.serverIP_Label.Name = "serverIP_Label";
            this.serverIP_Label.Size = new System.Drawing.Size(73, 15);
            this.serverIP_Label.TabIndex = 3;
            this.serverIP_Label.Text = "Server IP : ";
            // 
            // serverPort_TextBox
            // 
            this.serverPort_TextBox.Location = new System.Drawing.Point(105, 55);
            this.serverPort_TextBox.Name = "serverPort_TextBox";
            this.serverPort_TextBox.Size = new System.Drawing.Size(161, 25);
            this.serverPort_TextBox.TabIndex = 6;
            this.serverPort_TextBox.Text = "5555";
            // 
            // serverPort_Label
            // 
            this.serverPort_Label.AutoSize = true;
            this.serverPort_Label.Location = new System.Drawing.Point(15, 55);
            this.serverPort_Label.Name = "serverPort_Label";
            this.serverPort_Label.Size = new System.Drawing.Size(84, 15);
            this.serverPort_Label.TabIndex = 5;
            this.serverPort_Label.Text = "Server Port : ";
            // 
            // myNumber_TextBox
            // 
            this.myNumber_TextBox.Location = new System.Drawing.Point(33, 120);
            this.myNumber_TextBox.Name = "myNumber_TextBox";
            this.myNumber_TextBox.Size = new System.Drawing.Size(112, 25);
            this.myNumber_TextBox.TabIndex = 8;
            // 
            // myNumber_Label
            // 
            this.myNumber_Label.AutoSize = true;
            this.myNumber_Label.Location = new System.Drawing.Point(23, 99);
            this.myNumber_Label.Name = "myNumber_Label";
            this.myNumber_Label.Size = new System.Drawing.Size(164, 15);
            this.myNumber_Label.TabIndex = 7;
            this.myNumber_Label.Text = "我的數字(四位不重複) : ";
            // 
            // guessNumber_TextBox
            // 
            this.guessNumber_TextBox.Location = new System.Drawing.Point(210, 120);
            this.guessNumber_TextBox.Name = "guessNumber_TextBox";
            this.guessNumber_TextBox.Size = new System.Drawing.Size(112, 25);
            this.guessNumber_TextBox.TabIndex = 10;
            // 
            // guessNumber_Label
            // 
            this.guessNumber_Label.AutoSize = true;
            this.guessNumber_Label.Location = new System.Drawing.Point(213, 101);
            this.guessNumber_Label.Name = "guessNumber_Label";
            this.guessNumber_Label.Size = new System.Drawing.Size(109, 15);
            this.guessNumber_Label.TabIndex = 9;
            this.guessNumber_Label.Text = "猜測對手數字 : ";
            // 
            // send_Button
            // 
            this.send_Button.Enabled = false;
            this.send_Button.Location = new System.Drawing.Point(328, 114);
            this.send_Button.Name = "send_Button";
            this.send_Button.Size = new System.Drawing.Size(45, 32);
            this.send_Button.TabIndex = 11;
            this.send_Button.Text = "送出";
            this.send_Button.UseVisualStyleBackColor = true;
            this.send_Button.Click += new System.EventHandler(this.send_Button_Click);
            // 
            // otherGuess_Label
            // 
            this.otherGuess_Label.AutoSize = true;
            this.otherGuess_Label.Location = new System.Drawing.Point(33, 148);
            this.otherGuess_Label.Name = "otherGuess_Label";
            this.otherGuess_Label.Size = new System.Drawing.Size(109, 15);
            this.otherGuess_Label.TabIndex = 12;
            this.otherGuess_Label.Text = "對方猜測紀錄 : ";
            // 
            // myGuess_Label
            // 
            this.myGuess_Label.AutoSize = true;
            this.myGuess_Label.Location = new System.Drawing.Point(202, 148);
            this.myGuess_Label.Name = "myGuess_Label";
            this.myGuess_Label.Size = new System.Drawing.Size(109, 15);
            this.myGuess_Label.TabIndex = 13;
            this.myGuess_Label.Text = "我的猜測紀錄 : ";
            // 
            // otherGuess_ListBox
            // 
            this.otherGuess_ListBox.FormattingEnabled = true;
            this.otherGuess_ListBox.ItemHeight = 15;
            this.otherGuess_ListBox.Location = new System.Drawing.Point(26, 166);
            this.otherGuess_ListBox.Name = "otherGuess_ListBox";
            this.otherGuess_ListBox.Size = new System.Drawing.Size(141, 154);
            this.otherGuess_ListBox.TabIndex = 14;
            // 
            // myGuess_ListBox
            // 
            this.myGuess_ListBox.FormattingEnabled = true;
            this.myGuess_ListBox.ItemHeight = 15;
            this.myGuess_ListBox.Location = new System.Drawing.Point(199, 166);
            this.myGuess_ListBox.Name = "myGuess_ListBox";
            this.myGuess_ListBox.Size = new System.Drawing.Size(132, 154);
            this.myGuess_ListBox.TabIndex = 15;
            // 
            // onlineUser_ListBox
            // 
            this.onlineUser_ListBox.FormattingEnabled = true;
            this.onlineUser_ListBox.ItemHeight = 15;
            this.onlineUser_ListBox.Location = new System.Drawing.Point(385, 106);
            this.onlineUser_ListBox.Name = "onlineUser_ListBox";
            this.onlineUser_ListBox.Size = new System.Drawing.Size(136, 184);
            this.onlineUser_ListBox.TabIndex = 16;
            // 
            // onlineUser_Label
            // 
            this.onlineUser_Label.AutoSize = true;
            this.onlineUser_Label.Location = new System.Drawing.Point(391, 88);
            this.onlineUser_Label.Name = "onlineUser_Label";
            this.onlineUser_Label.Size = new System.Drawing.Size(88, 15);
            this.onlineUser_Label.TabIndex = 17;
            this.onlineUser_Label.Text = "Online Users :";
            // 
            // systemMessage_ListBox
            // 
            this.systemMessage_ListBox.FormattingEnabled = true;
            this.systemMessage_ListBox.ItemHeight = 15;
            this.systemMessage_ListBox.Location = new System.Drawing.Point(29, 369);
            this.systemMessage_ListBox.Name = "systemMessage_ListBox";
            this.systemMessage_ListBox.Size = new System.Drawing.Size(237, 109);
            this.systemMessage_ListBox.TabIndex = 19;
            // 
            // systemMessage_Label
            // 
            this.systemMessage_Label.AutoSize = true;
            this.systemMessage_Label.Location = new System.Drawing.Point(26, 351);
            this.systemMessage_Label.Name = "systemMessage_Label";
            this.systemMessage_Label.Size = new System.Drawing.Size(112, 15);
            this.systemMessage_Label.TabIndex = 18;
            this.systemMessage_Label.Text = "System Message : ";
            // 
            // serverMessage_ListBox
            // 
            this.serverMessage_ListBox.FormattingEnabled = true;
            this.serverMessage_ListBox.ItemHeight = 15;
            this.serverMessage_ListBox.Location = new System.Drawing.Point(275, 369);
            this.serverMessage_ListBox.Name = "serverMessage_ListBox";
            this.serverMessage_ListBox.Size = new System.Drawing.Size(246, 109);
            this.serverMessage_ListBox.TabIndex = 21;
            // 
            // serverMessage_Label
            // 
            this.serverMessage_Label.AutoSize = true;
            this.serverMessage_Label.Location = new System.Drawing.Point(272, 351);
            this.serverMessage_Label.Name = "serverMessage_Label";
            this.serverMessage_Label.Size = new System.Drawing.Size(108, 15);
            this.serverMessage_Label.TabIndex = 20;
            this.serverMessage_Label.Text = "Server Message : ";
            // 
            // lock_Button
            // 
            this.lock_Button.Enabled = false;
            this.lock_Button.Location = new System.Drawing.Point(148, 117);
            this.lock_Button.Name = "lock_Button";
            this.lock_Button.Size = new System.Drawing.Size(45, 32);
            this.lock_Button.TabIndex = 22;
            this.lock_Button.Text = "鎖定";
            this.lock_Button.UseVisualStyleBackColor = true;
            this.lock_Button.Click += new System.EventHandler(this.lock_Button_Click);
            // 
            // otherGuessCount_Label
            // 
            this.otherGuessCount_Label.AutoSize = true;
            this.otherGuessCount_Label.ForeColor = System.Drawing.Color.Red;
            this.otherGuessCount_Label.Location = new System.Drawing.Point(33, 323);
            this.otherGuessCount_Label.Name = "otherGuessCount_Label";
            this.otherGuessCount_Label.Size = new System.Drawing.Size(109, 15);
            this.otherGuessCount_Label.TabIndex = 23;
            this.otherGuessCount_Label.Text = "對方猜測次數 : ";
            // 
            // otherGuessCount_Show
            // 
            this.otherGuessCount_Show.AutoSize = true;
            this.otherGuessCount_Show.ForeColor = System.Drawing.Color.Red;
            this.otherGuessCount_Show.Location = new System.Drawing.Point(140, 323);
            this.otherGuessCount_Show.Name = "otherGuessCount_Show";
            this.otherGuessCount_Show.Size = new System.Drawing.Size(14, 15);
            this.otherGuessCount_Show.TabIndex = 24;
            this.otherGuessCount_Show.Text = "0";
            // 
            // myGuessCount_Label
            // 
            this.myGuessCount_Label.AutoSize = true;
            this.myGuessCount_Label.ForeColor = System.Drawing.Color.Red;
            this.myGuessCount_Label.Location = new System.Drawing.Point(196, 323);
            this.myGuessCount_Label.Name = "myGuessCount_Label";
            this.myGuessCount_Label.Size = new System.Drawing.Size(109, 15);
            this.myGuessCount_Label.TabIndex = 25;
            this.myGuessCount_Label.Text = "我的猜測次數 : ";
            // 
            // myGuessCount_Show
            // 
            this.myGuessCount_Show.AutoSize = true;
            this.myGuessCount_Show.ForeColor = System.Drawing.Color.Red;
            this.myGuessCount_Show.Location = new System.Drawing.Point(303, 322);
            this.myGuessCount_Show.Name = "myGuessCount_Show";
            this.myGuessCount_Show.Size = new System.Drawing.Size(14, 15);
            this.myGuessCount_Show.TabIndex = 26;
            this.myGuessCount_Show.Text = "0";
            // 
            // restart_Button
            // 
            this.restart_Button.Enabled = false;
            this.restart_Button.Location = new System.Drawing.Point(337, 253);
            this.restart_Button.Name = "restart_Button";
            this.restart_Button.Size = new System.Drawing.Size(45, 37);
            this.restart_Button.TabIndex = 27;
            this.restart_Button.Text = "開始";
            this.restart_Button.UseVisualStyleBackColor = true;
            this.restart_Button.Click += new System.EventHandler(this.restart_Button_Click);
            // 
            // ExitGame_Button
            // 
            this.ExitGame_Button.Enabled = false;
            this.ExitGame_Button.Location = new System.Drawing.Point(337, 296);
            this.ExitGame_Button.Name = "ExitGame_Button";
            this.ExitGame_Button.Size = new System.Drawing.Size(45, 37);
            this.ExitGame_Button.TabIndex = 28;
            this.ExitGame_Button.Text = "結束";
            this.ExitGame_Button.UseVisualStyleBackColor = true;
            this.ExitGame_Button.Click += new System.EventHandler(this.ExitGame_Button_Click);
            // 
            // TCP_GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 492);
            this.Controls.Add(this.ExitGame_Button);
            this.Controls.Add(this.restart_Button);
            this.Controls.Add(this.myGuessCount_Show);
            this.Controls.Add(this.myGuessCount_Label);
            this.Controls.Add(this.otherGuessCount_Show);
            this.Controls.Add(this.otherGuessCount_Label);
            this.Controls.Add(this.lock_Button);
            this.Controls.Add(this.serverMessage_ListBox);
            this.Controls.Add(this.serverMessage_Label);
            this.Controls.Add(this.systemMessage_ListBox);
            this.Controls.Add(this.systemMessage_Label);
            this.Controls.Add(this.onlineUser_Label);
            this.Controls.Add(this.onlineUser_ListBox);
            this.Controls.Add(this.myGuess_ListBox);
            this.Controls.Add(this.otherGuess_ListBox);
            this.Controls.Add(this.myGuess_Label);
            this.Controls.Add(this.otherGuess_Label);
            this.Controls.Add(this.send_Button);
            this.Controls.Add(this.guessNumber_TextBox);
            this.Controls.Add(this.guessNumber_Label);
            this.Controls.Add(this.myNumber_TextBox);
            this.Controls.Add(this.myNumber_Label);
            this.Controls.Add(this.serverPort_TextBox);
            this.Controls.Add(this.serverPort_Label);
            this.Controls.Add(this.serverIP_TextBox);
            this.Controls.Add(this.serverIP_Label);
            this.Controls.Add(this.userName_TextBox);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.userName_Label);
            this.Name = "TCP_GuessNumber";
            this.Text = "TCP GuessNumber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TCP_GuessNumber_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName_Label;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.TextBox userName_TextBox;
        private System.Windows.Forms.TextBox serverIP_TextBox;
        private System.Windows.Forms.Label serverIP_Label;
        private System.Windows.Forms.TextBox serverPort_TextBox;
        private System.Windows.Forms.Label serverPort_Label;
        private System.Windows.Forms.TextBox myNumber_TextBox;
        private System.Windows.Forms.Label myNumber_Label;
        private System.Windows.Forms.TextBox guessNumber_TextBox;
        private System.Windows.Forms.Label guessNumber_Label;
        private System.Windows.Forms.Button send_Button;
        private System.Windows.Forms.Label otherGuess_Label;
        private System.Windows.Forms.Label myGuess_Label;
        private System.Windows.Forms.ListBox otherGuess_ListBox;
        private System.Windows.Forms.ListBox myGuess_ListBox;
        private System.Windows.Forms.ListBox onlineUser_ListBox;
        private System.Windows.Forms.Label onlineUser_Label;
        private System.Windows.Forms.ListBox systemMessage_ListBox;
        private System.Windows.Forms.Label systemMessage_Label;
        private System.Windows.Forms.ListBox serverMessage_ListBox;
        private System.Windows.Forms.Label serverMessage_Label;
        private System.Windows.Forms.Button lock_Button;
        private System.Windows.Forms.Label otherGuessCount_Label;
        private System.Windows.Forms.Label otherGuessCount_Show;
        private System.Windows.Forms.Label myGuessCount_Label;
        private System.Windows.Forms.Label myGuessCount_Show;
        private System.Windows.Forms.Button restart_Button;
        private System.Windows.Forms.Button ExitGame_Button;
    }
}

