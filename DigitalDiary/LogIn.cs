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
    public partial class LogIn : Form
    {
        public static string usernameLogin;
        public static int userIDLogin;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("UserID cannot be empty");

            }
            else if (passwordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Password field cannot be empty");
            }
            else
            {
                DbConnection db = new DbConnection();
                string sql = "SELECT * FROM Users WHERE Username='"+userNameTextBox.Text+"'AND Password='"+passwordTextBox.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, db.con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                try
                {
                    usernameLogin = dt.Rows[0]["Username"].ToString();
                    userIDLogin = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    var password = dt.Rows[0]["Password"];
                    this.Hide();
                    new DiaryHomepage().Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Username Or Password Not Found In The Database");
                }
                
                db.CloseConnection();
            }
        }
    }
}
