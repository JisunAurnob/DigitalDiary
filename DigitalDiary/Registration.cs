using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDiary
{
    public partial class Registration : Form
    {
        string path;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string usname = "";
            try
            {
                DbConnection db = new DbConnection();
                string sql = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(sql, db.con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                usname = dt.Rows[0]["Username"].ToString();
                db.CloseConnection();
            }
            catch (Exception)
            {
            }
            if (nameTextBox.Text.Equals(string.Empty) || usernameTextBox.Text.Equals(string.Empty) || passwordTextBox.Text.Equals(string.Empty) || confirmPasswordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Field can not be empty");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password must match");
                }
                else
                {
                    if ((maleRadioButton.Checked == false) && (femaleRadioButton.Checked == false))
                    {
                        MessageBox.Show("Please select gender");
                    }
                    else if (dateOfBirthPicker.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Please select date of birth");
                    }
                    else if (bloodGroupComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select blood group");
                    }
                    else if (conditionCheckBox.Checked == false)
                    {
                        MessageBox.Show("Please select the agreement");
                    }
                    else if (usname.Equals(usernameTextBox.Text))
                    {
                        MessageBox.Show("This Username Already Exist. Please Use Different Username");
                    }
                    else
                    {
                        string name, username, password, gender, dob, bg, pic;
                        name = nameTextBox.Text;
                        username = usernameTextBox.Text;
                        password = passwordTextBox.Text;
                        if (maleRadioButton.Checked)
                            gender = "Male";
                        else
                            gender = "Female";
                        dob = dateOfBirthPicker.Value.Date.ToString();
                        bg = bloodGroupComboBox.SelectedItem.ToString();
                        pic = path;
                        pic = path;
                        DbConnection db2 = new DbConnection();
                        int i = db2.AddUser(name, username, password, gender, dob, bg, pic);
                        if (i == 1)
                        {
                            MessageBox.Show("User added successfully");
                            this.Hide();
                            new LogIn().Show();
                        }
                        db2.CloseConnection();
                    }
                }
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path = Path.GetFullPath("PictureData") + @"\" + usernameTextBox.Text + ".jpg";
                File.Copy(fd.FileName, path, true);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }
    }
}