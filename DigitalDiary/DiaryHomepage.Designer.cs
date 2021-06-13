namespace DigitalDiary
{
    partial class DiaryHomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaryHomepage));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.updateEventButton = new System.Windows.Forms.Button();
            this.MemberDetailsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profileButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.fullVIewButton = new System.Windows.Forms.Button();
            this.eventIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            eventDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.SideMenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(eventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SideMenuPanel.Controls.Add(this.deleteEventButton);
            this.SideMenuPanel.Controls.Add(this.updateEventButton);
            this.SideMenuPanel.Controls.Add(this.MemberDetailsButton);
            this.SideMenuPanel.Controls.Add(this.panel1);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(194, 666);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteEventButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteEventButton.FlatAppearance.BorderSize = 0;
            this.deleteEventButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deleteEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.deleteEventButton.Location = new System.Drawing.Point(0, 256);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deleteEventButton.Size = new System.Drawing.Size(194, 52);
            this.deleteEventButton.TabIndex = 7;
            this.deleteEventButton.Text = "Delete Event";
            this.deleteEventButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEventButton.UseVisualStyleBackColor = false;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // updateEventButton
            // 
            this.updateEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateEventButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateEventButton.FlatAppearance.BorderSize = 0;
            this.updateEventButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.updateEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.updateEventButton.Location = new System.Drawing.Point(0, 204);
            this.updateEventButton.Name = "updateEventButton";
            this.updateEventButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.updateEventButton.Size = new System.Drawing.Size(194, 52);
            this.updateEventButton.TabIndex = 6;
            this.updateEventButton.Text = "Update Event";
            this.updateEventButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateEventButton.UseVisualStyleBackColor = false;
            this.updateEventButton.Click += new System.EventHandler(this.updateEventButton_Click);
            // 
            // MemberDetailsButton
            // 
            this.MemberDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MemberDetailsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberDetailsButton.FlatAppearance.BorderSize = 0;
            this.MemberDetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.MemberDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberDetailsButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.MemberDetailsButton.Location = new System.Drawing.Point(0, 149);
            this.MemberDetailsButton.Name = "MemberDetailsButton";
            this.MemberDetailsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MemberDetailsButton.Size = new System.Drawing.Size(194, 55);
            this.MemberDetailsButton.TabIndex = 5;
            this.MemberDetailsButton.Text = "Create New Event";
            this.MemberDetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MemberDetailsButton.UseVisualStyleBackColor = false;
            this.MemberDetailsButton.Click += new System.EventHandler(this.MemberDetailsButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 149);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.profileButton);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 80);
            this.panel2.TabIndex = 3;
            // 
            // profileButton
            // 
            this.profileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.FlatAppearance.BorderSize = 2;
            this.profileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.profileButton.Location = new System.Drawing.Point(529, 23);
            this.profileButton.Name = "profileButton";
            this.profileButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.profileButton.Size = new System.Drawing.Size(194, 45);
            this.profileButton.TabIndex = 7;
            this.profileButton.Text = "Username";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.Gold;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(755, 26);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(91, 43);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(300, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digital Diary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChildFormPanel.BackColor = System.Drawing.Color.Black;
            this.ChildFormPanel.Controls.Add(this.fullVIewButton);
            this.ChildFormPanel.Controls.Add(this.eventIDTextBox);
            this.ChildFormPanel.Controls.Add(this.label1);
            this.ChildFormPanel.Controls.Add(eventDataGridView);
            this.ChildFormPanel.Controls.Add(this.label7);
            this.ChildFormPanel.Location = new System.Drawing.Point(194, 86);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(890, 586);
            this.ChildFormPanel.TabIndex = 5;
            // 
            // fullVIewButton
            // 
            this.fullVIewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fullVIewButton.BackColor = System.Drawing.Color.DarkOrange;
            this.fullVIewButton.FlatAppearance.BorderSize = 0;
            this.fullVIewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.fullVIewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullVIewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullVIewButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fullVIewButton.Location = new System.Drawing.Point(504, 395);
            this.fullVIewButton.Name = "fullVIewButton";
            this.fullVIewButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.fullVIewButton.Size = new System.Drawing.Size(194, 45);
            this.fullVIewButton.TabIndex = 55;
            this.fullVIewButton.Text = "Full VIew";
            this.fullVIewButton.UseVisualStyleBackColor = false;
            this.fullVIewButton.Click += new System.EventHandler(this.fullVIewButton_Click);
            // 
            // eventIDTextBox
            // 
            this.eventIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.eventIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIDTextBox.Location = new System.Drawing.Point(433, 329);
            this.eventIDTextBox.Name = "eventIDTextBox";
            this.eventIDTextBox.Size = new System.Drawing.Size(329, 30);
            this.eventIDTextBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(29, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "For Indivisual Detailed View Give EventId:";
            // 
            // eventDataGridView
            // 
            eventDataGridView.AllowUserToAddRows = false;
            eventDataGridView.AllowUserToDeleteRows = false;
            eventDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventDataGridView.Location = new System.Drawing.Point(6, 63);
            eventDataGridView.Name = "eventDataGridView";
            eventDataGridView.ReadOnly = true;
            eventDataGridView.RowHeadersWidth = 51;
            eventDataGridView.RowTemplate.Height = 24;
            eventDataGridView.Size = new System.Drawing.Size(872, 191);
            eventDataGridView.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(298, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 60);
            this.label7.TabIndex = 10;
            this.label7.Text = "Your Events";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiaryHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1084, 666);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SideMenuPanel);
            this.Name = "DiaryHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiaryHomepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiaryHomepage_FormClosing);
            this.Load += new System.EventHandler(this.DiaryHomepage_Load);
            this.SideMenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(eventDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateEventButton;
        private System.Windows.Forms.Button MemberDetailsButton;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fullVIewButton;
        private System.Windows.Forms.TextBox eventIDTextBox;
        public static System.Windows.Forms.DataGridView eventDataGridView;
    }
}