namespace A103223013_Midterm
{
    partial class Form1
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
            this.listenPort_Label = new System.Windows.Forms.Label();
            this.listenPort_TextBox = new System.Windows.Forms.TextBox();
            this.targetIP_TextBox = new System.Windows.Forms.TextBox();
            this.targetIP_Label = new System.Windows.Forms.Label();
            this.targetPort_TextBox = new System.Windows.Forms.TextBox();
            this.targetPort_Label = new System.Windows.Forms.Label();
            this.listenButton = new System.Windows.Forms.Button();
            this.myCard_ListBox = new System.Windows.Forms.ListBox();
            this.B0 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.targetCard_ListBox = new System.Windows.Forms.ListBox();
            this.result_ListBox = new System.Windows.Forms.ListBox();
            this.myCard_Label = new System.Windows.Forms.Label();
            this.targetCard_Label = new System.Windows.Forms.Label();
            this.result_Label = new System.Windows.Forms.Label();
            this.restart_Button = new System.Windows.Forms.Button();
            this.turn_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listenPort_Label
            // 
            this.listenPort_Label.AutoSize = true;
            this.listenPort_Label.Location = new System.Drawing.Point(13, 20);
            this.listenPort_Label.Name = "listenPort_Label";
            this.listenPort_Label.Size = new System.Drawing.Size(48, 12);
            this.listenPort_Label.TabIndex = 0;
            this.listenPort_Label.Text = "接聽Port";
            // 
            // listenPort_TextBox
            // 
            this.listenPort_TextBox.Location = new System.Drawing.Point(67, 15);
            this.listenPort_TextBox.Name = "listenPort_TextBox";
            this.listenPort_TextBox.Size = new System.Drawing.Size(100, 22);
            this.listenPort_TextBox.TabIndex = 1;
            this.listenPort_TextBox.Text = "8888";
            // 
            // targetIP_TextBox
            // 
            this.targetIP_TextBox.Location = new System.Drawing.Point(209, 16);
            this.targetIP_TextBox.Name = "targetIP_TextBox";
            this.targetIP_TextBox.Size = new System.Drawing.Size(100, 22);
            this.targetIP_TextBox.TabIndex = 3;
            this.targetIP_TextBox.Text = "127.0.0.1";
            // 
            // targetIP_Label
            // 
            this.targetIP_Label.AutoSize = true;
            this.targetIP_Label.Location = new System.Drawing.Point(170, 20);
            this.targetIP_Label.Name = "targetIP_Label";
            this.targetIP_Label.Size = new System.Drawing.Size(39, 12);
            this.targetIP_Label.TabIndex = 2;
            this.targetIP_Label.Text = "目標IP";
            // 
            // targetPort_TextBox
            // 
            this.targetPort_TextBox.Location = new System.Drawing.Point(360, 15);
            this.targetPort_TextBox.Name = "targetPort_TextBox";
            this.targetPort_TextBox.Size = new System.Drawing.Size(100, 22);
            this.targetPort_TextBox.TabIndex = 5;
            this.targetPort_TextBox.Text = "8888";
            // 
            // targetPort_Label
            // 
            this.targetPort_Label.AutoSize = true;
            this.targetPort_Label.Location = new System.Drawing.Point(311, 20);
            this.targetPort_Label.Name = "targetPort_Label";
            this.targetPort_Label.Size = new System.Drawing.Size(48, 12);
            this.targetPort_Label.TabIndex = 4;
            this.targetPort_Label.Text = "目標Port";
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(466, 15);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(75, 23);
            this.listenButton.TabIndex = 6;
            this.listenButton.Text = "啟動接聽";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // myCard_ListBox
            // 
            this.myCard_ListBox.FormattingEnabled = true;
            this.myCard_ListBox.ItemHeight = 12;
            this.myCard_ListBox.Location = new System.Drawing.Point(98, 63);
            this.myCard_ListBox.Name = "myCard_ListBox";
            this.myCard_ListBox.Size = new System.Drawing.Size(89, 316);
            this.myCard_ListBox.TabIndex = 7;
            // 
            // B0
            // 
            this.B0.Enabled = false;
            this.B0.Location = new System.Drawing.Point(15, 61);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(63, 48);
            this.B0.TabIndex = 8;
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // B1
            // 
            this.B1.Enabled = false;
            this.B1.Location = new System.Drawing.Point(15, 115);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(63, 48);
            this.B1.TabIndex = 9;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.Enabled = false;
            this.B3.Location = new System.Drawing.Point(15, 221);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(63, 48);
            this.B3.TabIndex = 10;
            this.B3.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            this.B4.Enabled = false;
            this.B4.Location = new System.Drawing.Point(15, 275);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(63, 48);
            this.B4.TabIndex = 11;
            this.B4.UseVisualStyleBackColor = true;
            // 
            // B5
            // 
            this.B5.Enabled = false;
            this.B5.Location = new System.Drawing.Point(15, 329);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(63, 48);
            this.B5.TabIndex = 12;
            this.B5.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.Enabled = false;
            this.B2.Location = new System.Drawing.Point(15, 169);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(63, 48);
            this.B2.TabIndex = 13;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // targetCard_ListBox
            // 
            this.targetCard_ListBox.FormattingEnabled = true;
            this.targetCard_ListBox.ItemHeight = 12;
            this.targetCard_ListBox.Location = new System.Drawing.Point(209, 61);
            this.targetCard_ListBox.Name = "targetCard_ListBox";
            this.targetCard_ListBox.Size = new System.Drawing.Size(95, 316);
            this.targetCard_ListBox.TabIndex = 14;
            // 
            // result_ListBox
            // 
            this.result_ListBox.FormattingEnabled = true;
            this.result_ListBox.ItemHeight = 12;
            this.result_ListBox.Location = new System.Drawing.Point(324, 63);
            this.result_ListBox.Name = "result_ListBox";
            this.result_ListBox.Size = new System.Drawing.Size(178, 316);
            this.result_ListBox.TabIndex = 15;
            // 
            // myCard_Label
            // 
            this.myCard_Label.AutoSize = true;
            this.myCard_Label.Location = new System.Drawing.Point(101, 48);
            this.myCard_Label.Name = "myCard_Label";
            this.myCard_Label.Size = new System.Drawing.Size(77, 12);
            this.myCard_Label.TabIndex = 16;
            this.myCard_Label.Text = "我的出牌紀錄";
            // 
            // targetCard_Label
            // 
            this.targetCard_Label.AutoSize = true;
            this.targetCard_Label.Location = new System.Drawing.Point(217, 46);
            this.targetCard_Label.Name = "targetCard_Label";
            this.targetCard_Label.Size = new System.Drawing.Size(77, 12);
            this.targetCard_Label.TabIndex = 17;
            this.targetCard_Label.Text = "對方出牌紀錄";
            // 
            // result_Label
            // 
            this.result_Label.AutoSize = true;
            this.result_Label.Location = new System.Drawing.Point(322, 48);
            this.result_Label.Name = "result_Label";
            this.result_Label.Size = new System.Drawing.Size(77, 12);
            this.result_Label.TabIndex = 18;
            this.result_Label.Text = "比賽結果紀錄";
            // 
            // restart_Button
            // 
            this.restart_Button.Location = new System.Drawing.Point(508, 339);
            this.restart_Button.Name = "restart_Button";
            this.restart_Button.Size = new System.Drawing.Size(45, 40);
            this.restart_Button.TabIndex = 19;
            this.restart_Button.Text = "重玩";
            this.restart_Button.UseVisualStyleBackColor = true;
            this.restart_Button.Click += new System.EventHandler(this.restart_Button_Click);
            // 
            // turn_Label
            // 
            this.turn_Label.AutoSize = true;
            this.turn_Label.ForeColor = System.Drawing.Color.Red;
            this.turn_Label.Location = new System.Drawing.Point(25, 46);
            this.turn_Label.Name = "turn_Label";
            this.turn_Label.Size = new System.Drawing.Size(53, 12);
            this.turn_Label.TabIndex = 20;
            this.turn_Label.Text = "你的回合";
            this.turn_Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 391);
            this.Controls.Add(this.turn_Label);
            this.Controls.Add(this.restart_Button);
            this.Controls.Add(this.result_Label);
            this.Controls.Add(this.targetCard_Label);
            this.Controls.Add(this.myCard_Label);
            this.Controls.Add(this.result_ListBox);
            this.Controls.Add(this.targetCard_ListBox);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.myCard_ListBox);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.targetPort_TextBox);
            this.Controls.Add(this.targetPort_Label);
            this.Controls.Add(this.targetIP_TextBox);
            this.Controls.Add(this.targetIP_Label);
            this.Controls.Add(this.listenPort_TextBox);
            this.Controls.Add(this.listenPort_Label);
            this.Name = "Form1";
            this.Text = "撲克牌比大小";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listenPort_Label;
        private System.Windows.Forms.TextBox listenPort_TextBox;
        private System.Windows.Forms.TextBox targetIP_TextBox;
        private System.Windows.Forms.Label targetIP_Label;
        private System.Windows.Forms.TextBox targetPort_TextBox;
        private System.Windows.Forms.Label targetPort_Label;
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.ListBox myCard_ListBox;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.ListBox targetCard_ListBox;
        private System.Windows.Forms.ListBox result_ListBox;
        private System.Windows.Forms.Label myCard_Label;
        private System.Windows.Forms.Label targetCard_Label;
        private System.Windows.Forms.Label result_Label;
        private System.Windows.Forms.Button restart_Button;
        private System.Windows.Forms.Label turn_Label;
    }
}

