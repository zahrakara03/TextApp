
namespace TextApp
{
    partial class frmProfile
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
            this.components = new System.ComponentModel.Container();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxChat = new System.Windows.Forms.PictureBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtProfilePassword = new System.Windows.Forms.TextBox();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.txtProfileLName = new System.Windows.Forms.TextBox();
            this.txtProfileFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbxAccount = new System.Windows.Forms.PictureBox();
            this.pbxLogOut = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.pbxProf = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxMenu2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOut)).BeginInit();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProf)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pbxMenu);
            this.panel1.Controls.Add(this.pbxProfile);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(274, 612);
            this.panel1.MinimumSize = new System.Drawing.Size(64, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 612);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Controls.Add(this.pbxChat);
            this.panel2.Controls.Add(this.btnChat);
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 276);
            this.panel2.TabIndex = 0;
            // 
            // pbxChat
            // 
            this.pbxChat.Image = global::TextApp.Properties.Resources.chat;
            this.pbxChat.Location = new System.Drawing.Point(9, 92);
            this.pbxChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxChat.Name = "pbxChat";
            this.pbxChat.Size = new System.Drawing.Size(47, 51);
            this.pbxChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxChat.TabIndex = 14;
            this.pbxChat.TabStop = false;
            this.pbxChat.Click += new System.EventHandler(this.pbxChat_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.Location = new System.Drawing.Point(65, 92);
            this.btnChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(198, 51);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(292, 49);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(613, 558);
            this.panel6.TabIndex = 16;
            // 
            // pbxMenu
            // 
            this.pbxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxMenu.Image = global::TextApp.Properties.Resources.list;
            this.pbxMenu.Location = new System.Drawing.Point(9, 10);
            this.pbxMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(49, 41);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu.TabIndex = 13;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.pbxMenu_Click);
            // 
            // pbxProfile
            // 
            this.pbxProfile.BackColor = System.Drawing.Color.White;
            this.pbxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxProfile.Location = new System.Drawing.Point(65, 86);
            this.pbxProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(138, 112);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfile.TabIndex = 9;
            this.pbxProfile.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(42, 228);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(183, 26);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "EMAIL";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProfilePassword
            // 
            this.txtProfilePassword.Enabled = false;
            this.txtProfilePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfilePassword.Location = new System.Drawing.Point(165, 351);
            this.txtProfilePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfilePassword.Multiline = true;
            this.txtProfilePassword.Name = "txtProfilePassword";
            this.txtProfilePassword.Size = new System.Drawing.Size(234, 36);
            this.txtProfilePassword.TabIndex = 25;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Enabled = false;
            this.txtProfileEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileEmail.Location = new System.Drawing.Point(165, 295);
            this.txtProfileEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfileEmail.Multiline = true;
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(234, 32);
            this.txtProfileEmail.TabIndex = 12;
            // 
            // txtProfileLName
            // 
            this.txtProfileLName.Enabled = false;
            this.txtProfileLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileLName.Location = new System.Drawing.Point(165, 240);
            this.txtProfileLName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfileLName.Multiline = true;
            this.txtProfileLName.Name = "txtProfileLName";
            this.txtProfileLName.Size = new System.Drawing.Size(234, 32);
            this.txtProfileLName.TabIndex = 11;
            // 
            // txtProfileFName
            // 
            this.txtProfileFName.Enabled = false;
            this.txtProfileFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileFName.Location = new System.Drawing.Point(165, 184);
            this.txtProfileFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfileFName.Multiline = true;
            this.txtProfileFName.Name = "txtProfileFName";
            this.txtProfileFName.Size = new System.Drawing.Size(234, 32);
            this.txtProfileFName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.Black;
            this.lblAccount.Location = new System.Drawing.Point(6, 0);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(176, 41);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "Account";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAccount.Click += new System.EventHandler(this.lblAccount_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SpringGreen;
            this.panel5.Controls.Add(this.pbxAccount);
            this.panel5.Controls.Add(this.pbxLogOut);
            this.panel5.Controls.Add(this.lblAccount);
            this.panel5.Controls.Add(this.lblLogOut);
            this.panel5.Location = new System.Drawing.Point(719, 56);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 96);
            this.panel5.TabIndex = 18;
            this.panel5.Visible = false;
            // 
            // pbxAccount
            // 
            this.pbxAccount.Image = global::TextApp.Properties.Resources.user;
            this.pbxAccount.Location = new System.Drawing.Point(6, 7);
            this.pbxAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxAccount.Name = "pbxAccount";
            this.pbxAccount.Size = new System.Drawing.Size(29, 34);
            this.pbxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAccount.TabIndex = 13;
            this.pbxAccount.TabStop = false;
            this.pbxAccount.Click += new System.EventHandler(this.pbxAccount_Click);
            // 
            // pbxLogOut
            // 
            this.pbxLogOut.Image = global::TextApp.Properties.Resources.logout;
            this.pbxLogOut.Location = new System.Drawing.Point(6, 54);
            this.pbxLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxLogOut.Name = "pbxLogOut";
            this.pbxLogOut.Size = new System.Drawing.Size(29, 34);
            this.pbxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogOut.TabIndex = 8;
            this.pbxLogOut.TabStop = false;
            this.pbxLogOut.Click += new System.EventHandler(this.pbxLogOut_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Black;
            this.lblLogOut.Location = new System.Drawing.Point(6, 54);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(176, 41);
            this.lblLogOut.TabIndex = 2;
            this.lblLogOut.Text = "Logout";
            this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.txtProfilePassword);
            this.pnlProfile.Controls.Add(this.txtProfileEmail);
            this.pnlProfile.Controls.Add(this.txtProfileLName);
            this.pnlProfile.Controls.Add(this.pbxProf);
            this.pnlProfile.Controls.Add(this.txtProfileFName);
            this.pnlProfile.Controls.Add(this.label3);
            this.pnlProfile.Controls.Add(this.label4);
            this.pnlProfile.Controls.Add(this.label2);
            this.pnlProfile.Controls.Add(this.label1);
            this.pnlProfile.Location = new System.Drawing.Point(278, 49);
            this.pnlProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(428, 502);
            this.pnlProfile.TabIndex = 19;
            this.pnlProfile.Visible = false;
            // 
            // pbxProf
            // 
            this.pbxProf.BackColor = System.Drawing.Color.White;
            this.pbxProf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxProf.Location = new System.Drawing.Point(141, 35);
            this.pbxProf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxProf.Name = "pbxProf";
            this.pbxProf.Size = new System.Drawing.Size(138, 98);
            this.pbxProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProf.TabIndex = 22;
            this.pbxProf.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(640, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 96);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pbxMenu2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(64, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 51);
            this.panel3.TabIndex = 17;
            // 
            // pbxMenu2
            // 
            this.pbxMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxMenu2.Image = global::TextApp.Properties.Resources.ellipsis;
            this.pbxMenu2.Location = new System.Drawing.Point(786, 8);
            this.pbxMenu2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxMenu2.Name = "pbxMenu2";
            this.pbxMenu2.Size = new System.Drawing.Size(49, 38);
            this.pbxMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu2.TabIndex = 14;
            this.pbxMenu2.TabStop = false;
            this.pbxMenu2.Click += new System.EventHandler(this.pbxMenu2_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(908, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProfile";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogOut)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProf)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxChat;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtProfilePassword;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.TextBox txtProfileLName;
        private System.Windows.Forms.PictureBox pbxProf;
        public System.Windows.Forms.TextBox txtProfileFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxAccount;
        private System.Windows.Forms.PictureBox pbxLogOut;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxMenu2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}