
namespace TextApp
{
    partial class frmChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.serverSendTextbox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbxMenu2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbxLogOut = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.serverSendButton1 = new System.Windows.Forms.Button();
            this.clientTab = new System.Windows.Forms.TabControl();
            this.serverTab = new System.Windows.Forms.TabPage();
            this.serverStartButton = new System.Windows.Forms.Button();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverTextboxBig = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientSendTextbox1 = new System.Windows.Forms.TextBox();
            this.clientSendButton1 = new System.Windows.Forms.Button();
            this.clientTextboxBig = new System.Windows.Forms.TextBox();
            this.clientPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientStartButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOut)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.clientTab.SuspendLayout();
            this.serverTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 458);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHAT ROOM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverSendTextbox1
            // 
            this.serverSendTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverSendTextbox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.serverSendTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverSendTextbox1.ForeColor = System.Drawing.Color.White;
            this.serverSendTextbox1.Location = new System.Drawing.Point(7, 17);
            this.serverSendTextbox1.Multiline = true;
            this.serverSendTextbox1.Name = "serverSendTextbox1";
            this.serverSendTextbox1.Size = new System.Drawing.Size(734, 52);
            this.serverSendTextbox1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pbxMenu2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(257, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 60);
            this.panel3.TabIndex = 21;
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
            this.pbxMenu2.Location = new System.Drawing.Point(858, 10);
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
            this.panel5.Location = new System.Drawing.Point(939, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 66);
            this.panel5.TabIndex = 22;
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
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "Logout";
            this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SpringGreen;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(257, 708);
            this.panel8.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.serverSendTextbox1);
            this.panel7.Controls.Add(this.serverSendButton1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 517);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(907, 81);
            this.panel7.TabIndex = 23;
            // 
            // serverSendButton1
            // 
            this.serverSendButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverSendButton1.BackColor = System.Drawing.Color.SpringGreen;
            this.serverSendButton1.BackgroundImage = global::TextApp.Properties.Resources.send;
            this.serverSendButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.serverSendButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverSendButton1.Location = new System.Drawing.Point(766, 17);
            this.serverSendButton1.Name = "serverSendButton1";
            this.serverSendButton1.Size = new System.Drawing.Size(108, 52);
            this.serverSendButton1.TabIndex = 4;
            this.serverSendButton1.UseVisualStyleBackColor = false;
            this.serverSendButton1.Click += new System.EventHandler(this.serverSendButton1_Click);
            // 
            // clientTab
            // 
            this.clientTab.Controls.Add(this.serverTab);
            this.clientTab.Controls.Add(this.tabPage2);
            this.clientTab.Location = new System.Drawing.Point(263, 66);
            this.clientTab.Name = "clientTab";
            this.clientTab.SelectedIndex = 0;
            this.clientTab.Size = new System.Drawing.Size(921, 630);
            this.clientTab.TabIndex = 1;
            // 
            // serverTab
            // 
            this.serverTab.BackColor = System.Drawing.Color.DarkSlateGray;
            this.serverTab.Controls.Add(this.serverStartButton);
            this.serverTab.Controls.Add(this.serverPort);
            this.serverTab.Controls.Add(this.label1);
            this.serverTab.Controls.Add(this.serverTextboxBig);
            this.serverTab.Controls.Add(this.panel7);
            this.serverTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTab.Location = new System.Drawing.Point(4, 25);
            this.serverTab.Name = "serverTab";
            this.serverTab.Padding = new System.Windows.Forms.Padding(3);
            this.serverTab.Size = new System.Drawing.Size(913, 601);
            this.serverTab.TabIndex = 0;
            this.serverTab.Text = "Server";
            // 
            // serverStartButton
            // 
            this.serverStartButton.BackColor = System.Drawing.Color.SpringGreen;
            this.serverStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStartButton.Location = new System.Drawing.Point(659, 285);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(236, 95);
            this.serverStartButton.TabIndex = 2;
            this.serverStartButton.Text = "Listen";
            this.serverStartButton.UseVisualStyleBackColor = false;
            this.serverStartButton.Click += new System.EventHandler(this.serverStartButton_Click);
            // 
            // serverPort
            // 
            this.serverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPort.Location = new System.Drawing.Point(659, 232);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(236, 34);
            this.serverPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(653, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port:";
            // 
            // serverTextboxBig
            // 
            this.serverTextboxBig.Location = new System.Drawing.Point(17, 17);
            this.serverTextboxBig.Multiline = true;
            this.serverTextboxBig.Name = "serverTextboxBig";
            this.serverTextboxBig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serverTextboxBig.Size = new System.Drawing.Size(627, 494);
            this.serverTextboxBig.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.clientTextboxBig);
            this.tabPage2.Controls.Add(this.clientPort);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.clientIP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.clientStartButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(913, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(653, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Port:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clientSendTextbox1);
            this.panel1.Controls.Add(this.clientSendButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 81);
            this.panel1.TabIndex = 24;
            // 
            // clientSendTextbox1
            // 
            this.clientSendTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSendTextbox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clientSendTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSendTextbox1.ForeColor = System.Drawing.Color.White;
            this.clientSendTextbox1.Location = new System.Drawing.Point(7, 17);
            this.clientSendTextbox1.Multiline = true;
            this.clientSendTextbox1.Name = "clientSendTextbox1";
            this.clientSendTextbox1.Size = new System.Drawing.Size(734, 52);
            this.clientSendTextbox1.TabIndex = 5;
            // 
            // clientSendButton1
            // 
            this.clientSendButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSendButton1.BackColor = System.Drawing.Color.SpringGreen;
            this.clientSendButton1.BackgroundImage = global::TextApp.Properties.Resources.send;
            this.clientSendButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clientSendButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientSendButton1.Location = new System.Drawing.Point(766, 17);
            this.clientSendButton1.Name = "clientSendButton1";
            this.clientSendButton1.Size = new System.Drawing.Size(108, 52);
            this.clientSendButton1.TabIndex = 6;
            this.clientSendButton1.UseVisualStyleBackColor = false;
            this.clientSendButton1.Click += new System.EventHandler(this.clientSendButton1_Click);
            // 
            // clientTextboxBig
            // 
            this.clientTextboxBig.Location = new System.Drawing.Point(17, 17);
            this.clientTextboxBig.Multiline = true;
            this.clientTextboxBig.Name = "clientTextboxBig";
            this.clientTextboxBig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientTextboxBig.Size = new System.Drawing.Size(627, 494);
            this.clientTextboxBig.TabIndex = 23;
            // 
            // clientPort
            // 
            this.clientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPort.Location = new System.Drawing.Point(659, 232);
            this.clientPort.Name = "clientPort";
            this.clientPort.Size = new System.Drawing.Size(236, 34);
            this.clientPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Port:";
            // 
            // clientIP
            // 
            this.clientIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIP.Location = new System.Drawing.Point(659, 136);
            this.clientIP.Name = "clientIP";
            this.clientIP.Size = new System.Drawing.Size(236, 34);
            this.clientIP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(654, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "IP Address:";
            // 
            // clientStartButton
            // 
            this.clientStartButton.BackColor = System.Drawing.Color.SpringGreen;
            this.clientStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientStartButton.Location = new System.Drawing.Point(659, 285);
            this.clientStartButton.Name = "clientStartButton";
            this.clientStartButton.Size = new System.Drawing.Size(236, 95);
            this.clientStartButton.TabIndex = 4;
            this.clientStartButton.Text = "Connect";
            this.clientStartButton.UseVisualStyleBackColor = false;
            this.clientStartButton.Click += new System.EventHandler(this.clientStartButton_Click);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1192, 708);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.clientTab);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChat";
            this.Text = "frmChat";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOut)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.clientTab.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
            this.serverTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverSendTextbox1;
        private System.Windows.Forms.Button serverSendButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbxMenu2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbxLogOut;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabControl clientTab;
        private System.Windows.Forms.TabPage serverTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox serverTextboxBig;
        private System.Windows.Forms.Button serverStartButton;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientTextboxBig;
        private System.Windows.Forms.Button clientStartButton;
        private System.Windows.Forms.TextBox clientPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox clientSendTextbox1;
        private System.Windows.Forms.Button clientSendButton1;
        private System.Windows.Forms.Label label5;
    }
}