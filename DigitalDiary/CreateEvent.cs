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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }
        string path;
        private void browseButton_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Event Name First");
            }
            else
            {
                OpenFileDialog fd = new OpenFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(fd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    path = Path.GetFullPath("PictureData") + @"\" + eventNameTextBox.Text + ".jpg";
                    File.Copy(fd.FileName, path, true);
                }
            }
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text.Equals(string.Empty) || diaryTextrichTextBox.Text.Equals(string.Empty) || diaryTextrichTextBox.Text.Equals("Write Your Text Here") || importanceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Fields can not be empty");
            }
            else
            {
                try
                {
                    DbConnection db = new DbConnection();
                    string sql = "INSERT INTO EventDetails(Username,EventName,DiaryNote,Importance,DateOfEvent,PictureOfEvent,LastModificationDate,UserId) VALUES('" + LogIn.usernameLogin + "','" + eventNameTextBox.Text + "','" + diaryTextrichTextBox.Text + "','" + importanceComboBox.SelectedItem.ToString() + "','" + dateTimePicker.Value.Date.ToString() + "','" + path + "','" + DateTime.Now.ToString()+ "'," + LogIn.userIDLogin + ")";
                    SqlCommand command = new SqlCommand(sql, db.con);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    DiaryHomepage.eventDataGridView.DataSource = db.GetAllEvent(LogIn.usernameLogin);
                    MessageBox.Show("Event Created successfully");
                    this.Close();
                    db.CloseConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Creating Event");
                }
            }
        }

        private void diaryTextrichTextBox_Click(object sender, EventArgs e)
        {
            if(diaryTextrichTextBox.Text == "Write Your Text Here")
            {
                diaryTextrichTextBox.Text = "";
            }
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
