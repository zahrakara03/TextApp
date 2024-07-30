using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using TextApp.Properties;
using System.Text.RegularExpressions;

namespace TextApp
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Info.mdf;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dataReader;
        MemoryStream memory;

        public string email { set; get; }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                Timer timer = new Timer();
                timer.Interval = (10 * 1000);
                timer.Tick += new EventHandler(timer2_Tick);
                timer.Start();

                //Display user details
                lblEmail.Text = email;
                byte[] getImage = new byte[0];

                con = new SqlConnection(constring);
                con.Open();
                string query = "SELECT * FROM Login WHERE Email = '" + lblEmail.Text + "'";

                cmd = new SqlCommand(query, con);
                dataReader = cmd.ExecuteReader();
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    lblEmail.Text = dataReader["Email"].ToString();

                    txtProfileFName.Text = dataReader["Firstname"].ToString();

                    txtProfileLName.Text = dataReader["Lastname"].ToString();

                    txtProfileEmail.Text = dataReader["Email"].ToString();

                    txtProfilePassword.Text = dataReader["Password"].ToString();

                    byte[] images = (byte[])dataReader["Image"];

                    if (images == null)
                    {
                        pbxLogOut.Image = null;
                        pbxProf.Image = null;

                    }
                    else
                    {
                        memory = new MemoryStream(images);
                        pbxProfile.Image = Image.FromStream(memory);
                        pbxProf.Image = Image.FromStream(memory);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxMenu2_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
            }
        }

        private void pbxAccount_Click(object sender, EventArgs e)
        {
            if (pnlProfile.Visible == false)
            {
                pnlProfile.Visible = true;
            }
            else
            {
                pnlProfile.Visible = false;
            }
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            if (pnlProfile.Visible == false)
            {
                pnlProfile.Visible = true;
            }
            else
            {
                pnlProfile.Visible = false;
            }
        }

        private void pbxLogOut_Click(object sender, EventArgs e)
        {
            frmLogin loginRegister = new frmLogin();
            this.Hide();
            loginRegister.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            frmLogin loginRegister = new frmLogin();
            this.Hide();
            loginRegister.Show();
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pbxChat_Click(object sender, EventArgs e)
        {
            /*frmChat chat = new frmChat();
            this.Hide();
            chat.Show();*/

            frmTest test = new frmTest();
            this.Hide();
            test.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            /*frmChat chat = new frmChat();
            this.Hide();
            chat.Show();*/

            frmTest test = new frmTest();
            this.Hide();
            test.Show();
        }

        private bool check;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                panel1.Width += 10;

                if (panel1.Size == panel1.MaximumSize)
                {
                    pbxMenu.Left = 12;
                    timer1.Stop();
                    check = false;
                    pbxMenu.Image = Resources.list;
                }
            }
            else
            {
                panel1.Width -= 10;

                if (panel1.Size == panel1.MinimumSize)
                {
                    pbxMenu.Left = 12;
                    timer1.Stop();
                    check = true;
                    pbxMenu.Image = Resources.list;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
