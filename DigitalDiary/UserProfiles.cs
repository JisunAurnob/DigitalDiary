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
    public partial class UserProfiles : Form
    {
        public UserProfiles()
        {
            InitializeComponent();
        }

        private void UserProfiles_Load(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            string sql = "SELECT * FROM Users WHERE Username='" + LogIn.usernameLogin + "'";
            SqlCommand cmd = new SqlCommand(sql, db.con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            usernameTextBox.Text = dt.Rows[0]["Username"].ToString();
            nameTextBox.Text = dt.Rows[0]["Name"].ToString();
            genderTextBox.Text = dt.Rows[0]["Gender"].ToString();
            dateOfBirthTextBox.Text = dt.Rows[0]["DateOfBirth"].ToString();
            bloodGroupTextBox.Text = dt.Rows[0]["BloodGroup"].ToString();
            try
            {
                pictureBox1.Image = new Bitmap(dt.Rows[0]["Picture"].ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

            }
            db.CloseConnection();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
