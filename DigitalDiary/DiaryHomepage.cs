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
    public partial class DiaryHomepage : Form
    {
        public DiaryHomepage()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void OpenAnotherForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }

        private void DiaryHomepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MemberDetailsButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new CreateEvent());
        }

        DataTable dt = new DataTable();
        private void DiaryHomepage_Load(object sender, EventArgs e)
        {
            profileButton.Text = LogIn.usernameLogin;
            DbConnection db = new DbConnection();
            eventDataGridView.DataSource = db.GetAllEvent(LogIn.usernameLogin);
            db.CloseConnection();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new UserProfiles());
        }

        private void fullVIewButton_Click(object sender, EventArgs e)
        {
            if (eventIDTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please Insert An Event ID");
            }
            else
            {
                OpenAnotherForm(new EventViewWindow(Convert.ToInt32(eventIDTextBox.Text)));
            }
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new DeleteEvent());
        }

        private void updateEventButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new UpdateEvent());
        }
    }
}
