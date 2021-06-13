using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDiary
{
    public partial class DeleteEvent : Form
    {
        public DeleteEvent()
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
                pictureBox1.Image = new Bitmap(dt.Rows[0]["PictureOfEvent"].ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Event ID not Found");
            }
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnection db = new DbConnection();
                string sql = "DELETE FROM EventDetails WHERE EventId='" + eventIdTextBox.Text.ToString() + "' AND Username = '" + LogIn.usernameLogin.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, db.con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DiaryHomepage.eventDataGridView.DataSource = db.GetAllEvent(LogIn.usernameLogin);
                db.CloseConnection();
                MessageBox.Show("Event Deleted Succesfully");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Faild To Delete Event");
            }
        }
    }
    }