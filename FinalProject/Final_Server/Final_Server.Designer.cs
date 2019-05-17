namespace Final_Server
{
    partial class TCP_Server
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
            this.onlineUser_Listbox = new System.Windows.Forms.ListBox();
            this.serverPort_TextBox = new System.Windows.Forms.TextBox();
            this.serverPort_Label = new System.Windows.Forms.Label();
            this.message_ListBox = new System.Windows.Forms.ListBox();
            this.onlineUser_Label = new System.Windows.Forms.Label();
            this.message_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.onlineRoom_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startServer_Button
            // 
            this.startServer_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startServer_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startServer_Button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startServer_Button.ForeColor = System.Drawing.Color.White;
            this.startServer_Button.Location = new System.Drawing.Point(52, 88);
            this.startServer_Button.Name = "startServer_Button";
            this.startServer_Button.Size = new System.Drawing.Size(225, 40);
            this.startServer_Button.TabIndex = 0;
            this.startServer_Button.Text = "啟 動 伺 服 器";
            this.startServer_Button.UseVisualStyleBackColor = false;
            this.startServer_Button.Click += new System.EventHandler(this.startServer_Button_Click);
            // 
            // serverIP_Label
            // 
            this.serverIP_Label.AutoSize = true;
            this.serverIP_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverIP_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serverIP_Label.Location = new System.Drawing.Point(48, 27);
            this.serverIP_Label.Name = "serverIP_Label";
            this.serverIP_Label.Size = new System.Drawing.Size(77, 21);
            this.serverIP_Label.TabIndex = 1;
            this.serverIP_Label.Text = "伺服器 IP";
            // 
            // serverIP_TextBox
            // 
            this.serverIP_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverIP_TextBox.Location = new System.Drawing.Point(52, 50);
            this.serverIP_TextBox.Name = "serverIP_TextBox";
            this.serverIP_TextBox.Size = new System.Drawing.Size(134, 29);
            this.serverIP_TextBox.TabIndex = 2;
            this.serverIP_TextBox.Text = "111.111.111.111";
            this.serverIP_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // onlineUser_Listbox
            // 
            this.onlineUser_Listbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.onlineUser_Listbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.onlineUser_Listbox.FormattingEnabled = true;
            this.onlineUser_Listbox.ItemHeight = 20;
            this.onlineUser_Listbox.Location = new System.Drawing.Point(25, 166);
            this.onlineUser_Listbox.Name = "onlineUser_Listbox";
            this.onlineUser_Listbox.Size = new System.Drawing.Size(144, 264);
            this.onlineUser_Listbox.TabIndex = 3;
            // 
            // serverPort_TextBox
            // 
            this.serverPort_TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverPort_TextBox.Location = new System.Drawing.Point(220, 50);
            this.serverPort_TextBox.Name = "serverPort_TextBox";
            this.serverPort_TextBox.Size = new System.Drawing.Size(57, 29);
            this.serverPort_TextBox.TabIndex = 5;
            this.serverPort_TextBox.Text = "55555";
            this.serverPort_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serverPort_Label
            // 
            this.serverPort_Label.AutoSize = true;
            this.serverPort_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverPort_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serverPort_Label.Location = new System.Drawing.Point(216, 27);
            this.serverPort_Label.Name = "serverPort_Label";
            this.serverPort_Label.Size = new System.Drawing.Size(42, 21);
            this.serverPort_Label.TabIndex = 4;
            this.serverPort_Label.Text = "Port";
            // 
            // message_ListBox
            // 
            this.message_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message_ListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.message_ListBox.FormattingEnabled = true;
            this.message_ListBox.HorizontalScrollbar = true;
            this.message_ListBox.ItemHeight = 20;
            this.message_ListBox.Location = new System.Drawing.Point(325, 46);
            this.message_ListBox.Name = "message_ListBox";
            this.message_ListBox.Size = new System.Drawing.Size(202, 384);
            this.message_ListBox.TabIndex = 6;
            // 
            // onlineUser_Label
            // 
            this.onlineUser_Label.AutoSize = true;
            this.onlineUser_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.onlineUser_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.onlineUser_Label.Location = new System.Drawing.Point(53, 143);
            this.onlineUser_Label.Name = "onlineUser_Label";
            this.onlineUser_Label.Size = new System.Drawing.Size(90, 21);
            this.onlineUser_Label.TabIndex = 7;
            this.onlineUser_Label.Text = "線上使用者";
            // 
            // message_Label
            // 
            this.message_Label.AutoSize = true;
            this.message_Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.message_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.message_Label.Location = new System.Drawing.Point(389, 23);
            this.message_Label.Name = "message_Label";
            this.message_Label.Size = new System.Drawing.Size(74, 21);
            this.message_Label.TabIndex = 8;
            this.message_Label.Text = "系統訊息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(209, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "房間列表";
            // 
            // onlineRoom_ListBox
            // 
            this.onlineRoom_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.onlineRoom_ListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.onlineRoom_ListBox.FormattingEnabled = true;
            this.onlineRoom_ListBox.ItemHeight = 20;
            this.onlineRoom_ListBox.Location = new System.Drawing.Point(175, 166);
            this.onlineRoom_ListBox.Name = "onlineRoom_ListBox";
            this.onlineRoom_ListBox.Size = new System.Drawing.Size(144, 264);
            this.onlineRoom_ListBox.TabIndex = 9;
            // 
            // TCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(551, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onlineRoom_ListBox);
            this.Controls.Add(this.message_Label);
            this.Controls.Add(this.onlineUser_Label);
            this.Controls.Add(this.message_ListBox);
            this.Controls.Add(this.serverPort_TextBox);
            this.Controls.Add(this.serverPort_Label);
            this.Controls.Add(this.onlineUser_Listbox);
            this.Controls.Add(this.serverIP_TextBox);
            this.Controls.Add(this.serverIP_Label);
            this.Controls.Add(this.startServer_Button);
            this.Name = "TCP_Server";
            this.Text = "Poover";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TCP_Server_FormClosing);
            this.Load += new System.EventHandler(this.TCP_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServer_Button;
        private System.Windows.Forms.Label serverIP_Label;
        private System.Windows.Forms.TextBox serverIP_TextBox;
        private System.Windows.Forms.ListBox onlineUser_Listbox;
        private System.Windows.Forms.TextBox serverPort_TextBox;
        private System.Windows.Forms.Label serverPort_Label;
        private System.Windows.Forms.ListBox message_ListBox;
        private System.Windows.Forms.Label onlineUser_Label;
        private System.Windows.Forms.Label message_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox onlineRoom_ListBox;
    }
}

