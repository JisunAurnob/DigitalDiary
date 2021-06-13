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
    public partial class UpdateEvent : Form
    {
        string path;
        public UpdateEvent()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnection db = new DbConnection();
                string sql = "SELECT * FROM EventDetails WHERE EventId='" + eventIdTextBox.Text.ToString() + "' AND Username = '" + LogIn.usernameLogin.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, db.con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                eventNameTextBox.Text = dt.Rows[0]["EventName"].ToString();
                diaryTextrichTextBox.Text = dt.Rows[0]["DiaryNote"].ToString();
                importanceComboBox.SelectedItem = dt.Rows[0]["Importance"].ToString();
                dateTimePicker.Value = Convert.ToDateTime(dt.Rows[0]["DateOfEvent"].ToString());
                path = dt.Rows[0]["PictureOfEvent"].ToString();
                pictureBox1.Image = new Bitmap(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Event ID not Found");
            }
        }

        private void updateEventButton_Click(object sender, EventArgs e)
        {
            /*UPDATE table_name
              SET column1 = value1, column2 = value2, ...
              WHERE condition;*/
            if (eventNameTextBox.Text.Equals(string.Empty) || diaryTextrichTextBox.Text.Equals(string.Empty) || diaryTextrichTextBox.Text.Equals("Write Your Text Here") || importanceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Fields can not be empty");
            }
            else
            {
                try
                {
                    DbConnection db = new DbConnection();
                    string sql = "UPDATE EventDetails SET EventName='" + eventNameTextBox.Text + "', DiaryNote='" + diaryTextrichTextBox.Text + "', Importance='" + importanceComboBox.SelectedItem.ToString() +
                        "', DateOfEvent='" + dateTimePicker.Value.Date.ToString() + "', PictureOfEvent='" + path + "', LastModificationDate='" + DateTime.Now.ToString() +
                        "' WHERE EventId='" + eventIdTextBox.Text.ToString() + "' AND Username = '" + LogIn.usernameLogin.ToString() + "'";
                    SqlCommand command = new SqlCommand(sql, db.con);
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    DiaryHomepage.eventDataGridView.DataSource = db.GetAllEvent(LogIn.usernameLogin);
                    MessageBox.Show("Event Updated successfully");
                    this.Close();
                    db.CloseConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Updating Event");
                }
            }
        }

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
    }
}