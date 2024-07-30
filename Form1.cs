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
using System.Text.RegularExpressions;

namespace TextApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Info.mdf;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter adapter;
        MemoryStream memory;

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            //Display Login page
            panel1.BringToFront();
            btnLogin1.BackColor = Color.SpringGreen;
            btnRegister1.BackColor = Color.Gray;
            panel3.BackColor = Color.SpringGreen;
            panel4.BackColor = Color.DarkSlateGray;
        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {
            //Display registration page
            panel2.BringToFront();
            btnRegister1.BackColor = Color.SpringGreen;
            btnLogin1.BackColor = Color.Gray;
            panel4.BackColor = Color.SpringGreen;
            panel3.BackColor = Color.DarkSlateGray;
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            try
            {
                //Checking errors
                if (string.IsNullOrEmpty(txtLoginEmail.Text.Trim()))
                {
                    errorProvider1.SetError(txtLoginEmail, "Email required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtLoginEmail, string.Empty);
                }
                if (string.IsNullOrEmpty(txtLoginPassword.Text.Trim()))
                {
                    errorProvider1.SetError(txtLoginPassword, "Password required");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtLoginPassword, string.Empty);
                }

                string validEmail = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z8-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                if (Regex.IsMatch(txtLoginEmail.Text, validEmail))
                {
                    errorProvider1.Clear();

                }
                else
                {
                    errorProvider1.SetError(this.txtLoginEmail, "please provide valid email");
                    return;
                }

                con = new SqlConnection(constring);
                con.Open();

                string query = "SELECT * FROM Login WHERE Email = '" + txtLoginEmail.Text + "' AND Password = '" + txtLoginPassword.Text + "'";

                cmd = new SqlCommand(query, con);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows == true)
                {
                    frmProfile profile = new frmProfile();

                    profile.email = txtLoginEmail.Text;

                    //Display profile form
                    this.Hide();
                    profile.Show();
                }
                else
                {
                    MessageBox.Show("Check your Email and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckBxShowLoginPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtLoginPassword.PasswordChar == '*')
            {
                txtLoginPassword.PasswordChar = '\0';
            }
            else
            {
                txtLoginPassword.PasswordChar = '*';
            }
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            try
            {

                if (pbxRegistration.Image == null)
                {
                    MessageBox.Show("Select photo.");
                }
                else
                {
                    //Checking errors
                    if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
                    {
                        errorProvider1.SetError(txtFirstName, "Firstname required");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtFirstName, string.Empty);
                    }
                    if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
                    {
                        errorProvider1.SetError(txtLastName, "Lastname required");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtLastName, string.Empty);
                    }
                    if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                    {
                        errorProvider1.SetError(txtEmail, "Email required");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtEmail, string.Empty);
                    }

                    //Password
                    var input = txtPass.Text.Trim();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        errorProvider1.SetError(txtPass, "Password should not be empty");
                        return;
                    }

                    bool hasLowerChar = Regex.IsMatch(input, @"[a-z]+");
                    bool hasUpperChar = Regex.IsMatch(input, @"[A-Z]+");
                    bool hasNumber = Regex.IsMatch(input, @"[0-9]+");
                    bool hasSymbols = Regex.IsMatch(input, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

                    if (!hasLowerChar)
                    {
                        errorProvider1.SetError(txtPass, "Password must contain at least one lowercase letter");
                        return;
                    }

                    if (!hasUpperChar)
                    {
                        errorProvider1.SetError(txtPass, "Password must contain at least one uppercase letter");
                        return;
                    }

                    if (!hasNumber)
                    {
                        errorProvider1.SetError(txtPass, "Password must contain at least one numerical value");
                        return;
                    }

                    if (!hasSymbols)
                    {
                        errorProvider1.SetError(txtPass, "Password must contain at least one special character");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtPass, string.Empty);
                    }
                    if (string.IsNullOrEmpty(txtConfirmPass.Text.Trim()))
                    {
                        errorProvider1.SetError(txtConfirmPass, "Password confirmation required");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtConfirmPass, string.Empty);
                    }
                    string validEmail = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z8-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                    if (Regex.IsMatch(txtEmail.Text, validEmail))
                    {
                        errorProvider1.Clear();

                    }
                    else
                    {
                        errorProvider1.SetError(this.txtEmail, "please provide valid email");
                        return;
                    }
                    if (input != txtConfirmPass.Text)
                    {
                        MessageBox.Show("Passwords do not match!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        try
                        {
                            con = new SqlConnection(constring);

                            //open connection
                            con.Open();

                            //setup sql string command and command as well as datadapter
                            adapter = new SqlDataAdapter();
                            string sql = $"INSERT INTO Login(Firstname,Lastname,Email,Password,ConfirmPassword,Image) VALUES('{txtFirstName.Text}', '{txtLastName.Text}', '{txtEmail.Text}', '{txtPass.Text}', '{txtConfirmPass.Text}', @Image)";
                            cmd = new SqlCommand(sql, con);

                            memory = new MemoryStream();
                            pbxRegistration.Image.Save(memory, pbxRegistration.Image.RawFormat);
                            cmd.Parameters.AddWithValue("Image", memory.ToArray());
                            
                            //Use adapter for executing the command
                            adapter.InsertCommand = cmd;
                            cmd.ExecuteNonQuery();

                            //close connection 
                            con.Close();

                            MessageBox.Show("Registration successful.");

                            //Clear input
                            txtFirstName.Clear();
                            txtLastName.Clear();
                            txtEmail.Clear();
                            txtPass.Clear();
                            txtConfirmPass.Clear();
                            pbxRegistration.Image = null;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxRegistration_Click(object sender, EventArgs e)
        {
            //Open file dialog to select picture
            openFileDialog1.Filter = "Select image (*Jpg; *.png; *Gif|*.Jpg; *.png; *Gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxRegistration.Image = Image.FromFile(openFileDialog1.FileName);
            }               
        }

        private void cbxShowLoginPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*' && txtConfirmPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
