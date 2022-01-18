using System.ComponentModel;

namespace Chatter.Client
{
    partial class UserWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActiveUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenPrivateChatBtn = new System.Windows.Forms.Button();
            this.MessagesBox = new System.Windows.Forms.ListBox();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.ChatConnectionLabel = new System.Windows.Forms.Label();
            this.AddToGroupBtn = new System.Windows.Forms.Button();
            this.MyGroups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupNameBox = new System.Windows.Forms.TextBox();
            this.OpenGroupChatBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddGroupBtn = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActiveUsers
            // 
            this.ActiveUsers.FormattingEnabled = true;
            this.ActiveUsers.ItemHeight = 15;
            this.ActiveUsers.Location = new System.Drawing.Point(12, 27);
            this.ActiveUsers.Name = "ActiveUsers";
            this.ActiveUsers.Size = new System.Drawing.Size(176, 619);
            this.ActiveUsers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active users";
            // 
            // OpenPrivateChatBtn
            // 
            this.OpenPrivateChatBtn.Location = new System.Drawing.Point(12, 665);
            this.OpenPrivateChatBtn.Name = "OpenPrivateChatBtn";
            this.OpenPrivateChatBtn.Size = new System.Drawing.Size(176, 44);
            this.OpenPrivateChatBtn.TabIndex = 2;
            this.OpenPrivateChatBtn.Text = "Open private chat";
            this.OpenPrivateChatBtn.UseVisualStyleBackColor = true;
            this.OpenPrivateChatBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenPrivateChatBtn_MouseClick);
            // 
            // MessagesBox
            // 
            this.MessagesBox.FormattingEnabled = true;
            this.MessagesBox.ItemHeight = 15;
            this.MessagesBox.Location = new System.Drawing.Point(211, 312);
            this.MessagesBox.Name = "MessagesBox";
            this.MessagesBox.Size = new System.Drawing.Size(580, 319);
            this.MessagesBox.TabIndex = 3;
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(211, 636);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(454, 73);
            this.MessageText.TabIndex = 4;
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(671, 636);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(120, 73);
            this.SendMessageBtn.TabIndex = 5;
            this.SendMessageBtn.Text = "Send";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // ChatConnectionLabel
            // 
            this.ChatConnectionLabel.AutoSize = true;
            this.ChatConnectionLabel.Location = new System.Drawing.Point(211, 294);
            this.ChatConnectionLabel.Name = "ChatConnectionLabel";
            this.ChatConnectionLabel.Size = new System.Drawing.Size(94, 15);
            this.ChatConnectionLabel.TabIndex = 6;
            this.ChatConnectionLabel.Text = "Connected with:";
            // 
            // AddToGroupBtn
            // 
            this.AddToGroupBtn.Location = new System.Drawing.Point(447, 27);
            this.AddToGroupBtn.Name = "AddToGroupBtn";
            this.AddToGroupBtn.Size = new System.Drawing.Size(201, 52);
            this.AddToGroupBtn.TabIndex = 7;
            this.AddToGroupBtn.Text = "Add to group";
            this.AddToGroupBtn.UseVisualStyleBackColor = true;
            this.AddToGroupBtn.Click += new System.EventHandler(this.AddToGroupBtn_Click);
            // 
            // MyGroups
            // 
            this.MyGroups.FormattingEnabled = true;
            this.MyGroups.ItemHeight = 15;
            this.MyGroups.Location = new System.Drawing.Point(211, 27);
            this.MyGroups.Name = "MyGroups";
            this.MyGroups.Size = new System.Drawing.Size(210, 214);
            this.MyGroups.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "My groups";
            // 
            // GroupNameBox
            // 
            this.GroupNameBox.Location = new System.Drawing.Point(447, 189);
            this.GroupNameBox.Name = "GroupNameBox";
            this.GroupNameBox.PlaceholderText = "Name";
            this.GroupNameBox.Size = new System.Drawing.Size(201, 23);
            this.GroupNameBox.TabIndex = 10;
            this.GroupNameBox.TextChanged += new System.EventHandler(this.GroupNameBox_TextChanged);
            // 
            // OpenGroupChatBtn
            // 
            this.OpenGroupChatBtn.Location = new System.Drawing.Point(211, 247);
            this.OpenGroupChatBtn.Name = "OpenGroupChatBtn";
            this.OpenGroupChatBtn.Size = new System.Drawing.Size(210, 32);
            this.OpenGroupChatBtn.TabIndex = 11;
            this.OpenGroupChatBtn.Text = "OpenGroupChat";
            this.OpenGroupChatBtn.UseVisualStyleBackColor = true;
            this.OpenGroupChatBtn.Click += new System.EventHandler(this.OpenGroupChatBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Group creation";
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.Enabled = false;
            this.AddGroupBtn.Location = new System.Drawing.Point(447, 218);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(201, 23);
            this.AddGroupBtn.TabIndex = 13;
            this.AddGroupBtn.Text = "Add group";
            this.AddGroupBtn.UseVisualStyleBackColor = true;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(447, 82);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(200, 30);
            this.Info.TabIndex = 14;
            this.Info.Text = "To add user to group select them on \r\ntheir corresponding lists first\r\n";
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 722);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.AddGroupBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenGroupChatBtn);
            this.Controls.Add(this.GroupNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MyGroups);
            this.Controls.Add(this.AddToGroupBtn);
            this.Controls.Add(this.ChatConnectionLabel);
            this.Controls.Add(this.SendMessageBtn);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.MessagesBox);
            this.Controls.Add(this.OpenPrivateChatBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActiveUsers);
            this.Name = "UserWindow";
            this.Text = "Connected user:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserWindow_FormClosing);
            this.Shown += new System.EventHandler(this.UserWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ActiveUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenPrivateChatBtn;
        private System.Windows.Forms.ListBox MessagesBox;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.Label ChatConnectionLabel;
        private System.Windows.Forms.Button AddToGroupBtn;
        private System.Windows.Forms.ListBox MyGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GroupNameBox;
        private System.Windows.Forms.Button OpenGroupChatBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddGroupBtn;
        private System.Windows.Forms.Label Info;
    }
}