namespace A103223013_FinalTerm_20161221
{
    partial class FinalTCP_Server
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
            this.startServer_Button = new System.Windows.Forms.Button();
            this.serverIP_Label = new System.Windows.Forms.Label();
            this.serverIP_TextBox = new System.Windows.Forms.TextBox();
            this.serverPort_TextBox = new System.Windows.Forms.TextBox();
            this.serverPort_Label = new System.Windows.Forms.Label();
            this.onlineUser_ListBox = new System.Windows.Forms.ListBox();
            this.message_ListBox = new System.Windows.Forms.ListBox();
            this.message_Label = new System.Windows.Forms.Label();
            this.onlineUser_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startServer_Button
            // 
            this.startServer_Button.Location = new System.Drawing.Point(31, 29);
            this.startServer_Button.Name = "startServer_Button";
            this.startServer_Button.Size = new System.Drawing.Size(191, 62);
            this.startServer_Button.TabIndex = 0;
            this.startServer_Button.Text = "Start Server";
            this.startServer_Button.UseVisualStyleBackColor = true;
            this.startServer_Button.Click += new System.EventHandler(this.startServer_Button_Click);
            // 
            // serverIP_Label
            // 
            this.serverIP_Label.AutoSize = true;
            this.serverIP_Label.Location = new System.Drawing.Point(47, 122);
            this.serverIP_Label.Name = "serverIP_Label";
            this.serverIP_Label.Size = new System.Drawing.Size(69, 15);
            this.serverIP_Label.TabIndex = 1;
            this.serverIP_Label.Text = "Server IP :";
            // 
            // serverIP_TextBox
            // 
            this.serverIP_TextBox.Location = new System.Drawing.Point(122, 119);
            this.serverIP_TextBox.Name = "serverIP_TextBox";
            this.serverIP_TextBox.Size = new System.Drawing.Size(100, 25);
            this.serverIP_TextBox.TabIndex = 2;
            // 
            // serverPort_TextBox
            // 
            this.serverPort_TextBox.Location = new System.Drawing.Point(122, 150);
            this.serverPort_TextBox.Name = "serverPort_TextBox";
            this.serverPort_TextBox.Size = new System.Drawing.Size(100, 25);
            this.serverPort_TextBox.TabIndex = 4;
            this.serverPort_TextBox.Text = "5555";
            // 
            // serverPort_Label
            // 
            this.serverPort_Label.AutoSize = true;
            this.serverPort_Label.Location = new System.Drawing.Point(36, 153);
            this.serverPort_Label.Name = "serverPort_Label";
            this.serverPort_Label.Size = new System.Drawing.Size(80, 15);
            this.serverPort_Label.TabIndex = 3;
            this.serverPort_Label.Text = "Server Port :";
            // 
            // onlineUser_ListBox
            // 
            this.onlineUser_ListBox.FormattingEnabled = true;
            this.onlineUser_ListBox.ItemHeight = 15;
            this.onlineUser_ListBox.Location = new System.Drawing.Point(240, 51);
            this.onlineUser_ListBox.Name = "onlineUser_ListBox";
            this.onlineUser_ListBox.Size = new System.Drawing.Size(131, 154);
            this.onlineUser_ListBox.TabIndex = 5;
            // 
            // message_ListBox
            // 
            this.message_ListBox.FormattingEnabled = true;
            this.message_ListBox.ItemHeight = 15;
            this.message_ListBox.Location = new System.Drawing.Point(31, 224);
            this.message_ListBox.Name = "message_ListBox";
            this.message_ListBox.Size = new System.Drawing.Size(340, 124);
            this.message_ListBox.TabIndex = 6;
            // 
            // message_Label
            // 
            this.message_Label.AutoSize = true;
            this.message_Label.Location = new System.Drawing.Point(28, 206);
            this.message_Label.Name = "message_Label";
            this.message_Label.Size = new System.Drawing.Size(67, 15);
            this.message_Label.TabIndex = 7;
            this.message_Label.Text = "Message : ";
            // 
            // onlineUser_Label
            // 
            this.onlineUser_Label.AutoSize = true;
            this.onlineUser_Label.Location = new System.Drawing.Point(237, 29);
            this.onlineUser_Label.Name = "onlineUser_Label";
            this.onlineUser_Label.Size = new System.Drawing.Size(83, 15);
            this.onlineUser_Label.TabIndex = 8;
            this.onlineUser_Label.Text = "Online User :";
            // 
            // FinalTCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 372);
            this.Controls.Add(this.onlineUser_Label);
            this.Controls.Add(this.message_Label);
            this.Controls.Add(this.message_ListBox);
            this.Controls.Add(this.onlineUser_ListBox);
            this.Controls.Add(this.serverPort_TextBox);
            this.Controls.Add(this.serverPort_Label);
            this.Controls.Add(this.serverIP_TextBox);
            this.Controls.Add(this.serverIP_Label);
            this.Controls.Add(this.startServer_Button);
            this.Name = "FinalTCP_Server";
            this.Text = "TCP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinalTCP_Server_FormClosing);
            this.Load += new System.EventHandler(this.FinalTCP_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServer_Button;
        private System.Windows.Forms.Label serverIP_Label;
        private System.Windows.Forms.TextBox serverIP_TextBox;
        private System.Windows.Forms.TextBox serverPort_TextBox;
        private System.Windows.Forms.Label serverPort_Label;
        private System.Windows.Forms.ListBox onlineUser_ListBox;
        private System.Windows.Forms.ListBox message_ListBox;
        private System.Windows.Forms.Label message_Label;
        private System.Windows.Forms.Label onlineUser_Label;
    }
}

