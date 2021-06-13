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
    public partial class EventViewWindow : Form
    {
        public int eventId;
        public EventViewWindow(int x)
        {
            this.eventId = x;
            InitializeComponent();
        }
        private void EventViewWindow_Load(object sender, EventArgs e)
        {
            try
            {
                DbConnection db = new DbConnection();
            string sql = "SELECT * FROM EventDetails WHERE EventId='" + eventId + "' AND Username = '" + LogIn.usernameLogin.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, db.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            eventNameTextBox.Text = dt.Rows[0]["EventName"].ToString();
            diaryTextrichTextBox.Text = dt.Rows[0]["DiaryNote"].ToString();
            importanceTextBox.Text = dt.Rows[0]["Importance"].ToString();
            dateOfEventTextBox.Text = dt.Rows[0]["DateOfEvent"].ToString();
            lastModifiedTextBox.Text = dt.Rows[0]["LastModificationDate"].ToString();
            
            pictureBox1.Image = new Bitmap(dt.Rows[0]["PictureOfEvent"].ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            db.CloseConnection();
            }
            catch (Exception)
            {

            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
