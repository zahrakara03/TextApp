namespace TextApp
{
    public partial class frmTest
    {
        /*public Test()
        {
            InitializeComponent();
        }*/

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.serverTab = new System.Windows.Forms.TabPage();
            this.serverTextboxBig = new System.Windows.Forms.TextBox();
            this.serverSendButton1 = new System.Windows.Forms.Button();
            this.serverSendTextbox1 = new System.Windows.Forms.TextBox();
            this.serverStartButton = new System.Windows.Forms.Button();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTab = new System.Windows.Forms.TabPage();
            this.clientTextboxBig = new System.Windows.Forms.TextBox();
            this.clientSendButton1 = new System.Windows.Forms.Button();
            this.clientSendTextbox1 = new System.Windows.Forms.TextBox();
            this.clientStartButton = new System.Windows.Forms.Button();
            this.clientPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbxMenu2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbxLogOut = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.serverTab.SuspendLayout();
            this.clientTab.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.serverTab);
            this.tabControl1.Controls.Add(this.clientTab);
            this.tabControl1.Location = new System.Drawing.Point(274, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // serverTab
            // 
            this.serverTab.BackColor = System.Drawing.Color.DarkSlateGray;
            this.serverTab.Controls.Add(this.serverTextboxBig);
            this.serverTab.Controls.Add(this.serverSendButton1);
            this.serverTab.Controls.Add(this.serverSendTextbox1);
            this.serverTab.Controls.Add(this.serverStartButton);
            this.serverTab.Controls.Add(this.serverPort);
            this.serverTab.Controls.Add(this.label1);
            this.serverTab.Location = new System.Drawing.Point(4, 25);
            this.serverTab.Name = "serverTab";
            this.serverTab.Padding = new System.Windows.Forms.Padding(3);
            this.serverTab.Size = new System.Drawing.Size(876, 551);
            this.serverTab.TabIndex = 0;
            this.serverTab.Text = "Server";
            // 
            // serverTextboxBig
            // 
            this.serverTextboxBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTextboxBig.Location = new System.Drawing.Point(6, 6);
            this.serverTextboxBig.Multiline = true;
            this.serverTextboxBig.Name = "serverTextboxBig";
            this.serverTextboxBig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serverTextboxBig.Size = new System.Drawing.Size(572, 473);
            this.serverTextboxBig.TabIndex = 7;
            // 
            // serverSendButton1
            // 
            this.serverSendButton1.BackColor = System.Drawing.Color.SpringGreen;
            this.serverSendButton1.BackgroundImage = global::TextApp.Properties.Resources.send;
            this.serverSendButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.serverSendButton1.Location = new System.Drawing.Point(795, 488);
            this.serverSendButton1.Name = "serverSendButton1";
            this.serverSendButton1.Size = new System.Drawing.Size(75, 57);
            this.serverSendButton1.TabIndex = 3;
            this.serverSendButton1.UseVisualStyleBackColor = false;
            this.serverSendButton1.Click += new System.EventHandler(this.serverSendButton1_Click);
            // 
            // serverSendTextbox1
            // 
            this.serverSendTextbox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.serverSendTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverSendTextbox1.ForeColor = System.Drawing.Color.White;
            this.serverSendTextbox1.Location = new System.Drawing.Point(6, 488);
            this.serverSendTextbox1.Multiline = true;
            this.serverSendTextbox1.Name = "serverSendTextbox1";
            this.serverSendTextbox1.Size = new System.Drawing.Size(771, 57);
            this.serverSendTextbox1.TabIndex = 2;
            // 
            // serverStartButton
            // 
            this.serverStartButton.BackColor = System.Drawing.Color.SpringGreen;
            this.serverStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStartButton.Location = new System.Drawing.Point(605, 279);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(253, 93);
            this.serverStartButton.TabIndex = 1;
            this.serverStartButton.Text = "Listen";
            this.serverStartButton.UseVisualStyleBackColor = false;
            this.serverStartButton.Click += new System.EventHandler(this.serverStartButton_Click);
            // 
            // serverPort
            // 
            this.serverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPort.Location = new System.Drawing.Point(605, 217);
            this.serverPort.Multiline = true;
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(253, 42);
            this.serverPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // clientTab
            // 
            this.clientTab.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clientTab.Controls.Add(this.clientTextboxBig);
            this.clientTab.Controls.Add(this.clientSendButton1);
            this.clientTab.Controls.Add(this.clientSendTextbox1);
            this.clientTab.Controls.Add(this.clientStartButton);
            this.clientTab.Controls.Add(this.clientPort);
            this.clientTab.Controls.Add(this.label3);
            this.clientTab.Controls.Add(this.clientIP);
            this.clientTab.Controls.Add(this.label2);
            this.clientTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTab.Location = new System.Drawing.Point(4, 25);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientTab.Size = new System.Drawing.Size(876, 551);
            this.clientTab.TabIndex = 1;
            this.clientTab.Text = "Client";
            // 
            // clientTextboxBig
            // 
            this.clientTextboxBig.Location = new System.Drawing.Point(6, 6);
            this.clientTextboxBig.Multiline = true;
            this.clientTextboxBig.Name = "clientTextboxBig";
            this.clientTextboxBig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientTextboxBig.Size = new System.Drawing.Size(572, 473);
            this.clientTextboxBig.TabIndex = 17;
            // 
            // clientSendButton1
            // 
            this.clientSendButton1.BackColor = System.Drawing.Color.SpringGreen;
            this.clientSendButton1.BackgroundImage = global::TextApp.Properties.Resources.send;
            this.clientSendButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clientSendButton1.Location = new System.Drawing.Point(795, 488);
            this.clientSendButton1.Name = "clientSendButton1";
            this.clientSendButton1.Size = new System.Drawing.Size(75, 57);
            this.clientSendButton1.TabIndex = 8;
            this.clientSendButton1.UseVisualStyleBackColor = false;
            this.clientSendButton1.Click += new System.EventHandler(this.clientSendButton1_Click);
            // 
            // clientSendTextbox1
            // 
            this.clientSendTextbox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clientSendTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSendTextbox1.ForeColor = System.Drawing.Color.White;
            this.clientSendTextbox1.Location = new System.Drawing.Point(6, 488);
            this.clientSendTextbox1.Multiline = true;
            this.clientSendTextbox1.Name = "clientSendTextbox1";
            this.clientSendTextbox1.Size = new System.Drawing.Size(771, 57);
            this.clientSendTextbox1.TabIndex = 7;
            // 
            // clientStartButton
            // 
            this.clientStartButton.BackColor = System.Drawing.Color.SpringGreen;
            this.clientStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientStartButton.Location = new System.Drawing.Point(605, 279);
            this.clientStartButton.Name = "clientStartButton";
            this.clientStartButton.Size = new System.Drawing.Size(253, 93);
            this.clientStartButton.TabIndex = 6;
            this.clientStartButton.Text = "Connect";
            this.clientStartButton.UseVisualStyleBackColor = false;
            this.clientStartButton.Click += new System.EventHandler(this.clientStartButton_Click);
            // 
            // clientPort
            // 
            this.clientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPort.Location = new System.Drawing.Point(605, 217);
            this.clientPort.Name = "clientPort";
            this.clientPort.Size = new System.Drawing.Size(253, 34);
            this.clientPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(600, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port:";
            // 
            // clientIP
            // 
            this.clientIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIP.Location = new System.Drawing.Point(605, 129);
            this.clientIP.Name = "clientIP";
            this.clientIP.Size = new System.Drawing.Size(253, 34);
            this.clientIP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(600, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP Address:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SpringGreen;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(257, 661);
            this.panel8.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 458);
            this.label4.TabIndex = 0;
            this.label4.Text = "CHAT ROOM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pbxMenu2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(257, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 60);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(853, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 118);
            this.panel4.TabIndex = 14;
            // 
            // pbxMenu2
            // 
            this.pbxMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxMenu2.Image = global::TextApp.Properties.Resources.ellipsis;
            this.pbxMenu2.Location = new System.Drawing.Point(840, 10);
            this.pbxMenu2.Name = "pbxMenu2";
            this.pbxMenu2.Size = new System.Drawing.Size(65, 44);
            this.pbxMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu2.TabIndex = 14;
            this.pbxMenu2.TabStop = false;
            this.pbxMenu2.Click += new System.EventHandler(this.pbxMenu2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SpringGreen;
            this.panel5.Controls.Add(this.pbxLogOut);
            this.panel5.Controls.Add(this.lblLogOut);
            this.panel5.Location = new System.Drawing.Point(917, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 66);
            this.panel5.TabIndex = 27;
            this.panel5.Visible = false;
            // 
            // pbxLogOut
            // 
            this.pbxLogOut.Image = global::TextApp.Properties.Resources.logout;
            this.pbxLogOut.Location = new System.Drawing.Point(7, 9);
            this.pbxLogOut.Name = "pbxLogOut";
            this.pbxLogOut.Size = new System.Drawing.Size(39, 42);
            this.pbxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogOut.TabIndex = 8;
            this.pbxLogOut.TabStop = false;
            this.pbxLogOut.Click += new System.EventHandler(this.pbxLogOut_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Black;
            this.lblLogOut.Location = new System.Drawing.Point(7, 9);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(234, 51);
            this.lblLogOut.TabIndex = 9;
            this.lblLogOut.Text = "Logout";
            this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // frmTest
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1174, 661);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTest";
            this.ShowIcon = false;
            this.tabControl1.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
            this.serverTab.PerformLayout();
            this.clientTab.ResumeLayout(false);
            this.clientTab.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOut)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage serverTab;
        private System.Windows.Forms.TextBox serverTextboxBig;
        private System.Windows.Forms.Button serverSendButton1;
        private System.Windows.Forms.TextBox serverSendTextbox1;
        private System.Windows.Forms.Button serverStartButton;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage clientTab;
        private System.Windows.Forms.TextBox clientTextboxBig;
        private System.Windows.Forms.Button clientSendButton1;
        private System.Windows.Forms.TextBox clientSendTextbox1;
        private System.Windows.Forms.Button clientStartButton;
        private System.Windows.Forms.TextBox clientPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbxMenu2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbxLogOut;
        private System.Windows.Forms.Label lblLogOut;
    }
}
