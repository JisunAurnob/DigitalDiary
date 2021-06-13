namespace DigitalDiary
{
    partial class DeleteEvent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.findButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.diaryTextrichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.importanceComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.eventIdTextBox);
            this.panel1.Controls.Add(this.deleteEventButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eventNameTextBox);
            this.panel1.Controls.Add(this.diaryTextrichTextBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.importanceComboBox);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(43, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 473);
            this.panel1.TabIndex = 11;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.DarkOrange;
            this.findButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(271, 3);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(96, 35);
            this.findButton.TabIndex = 46;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(-1, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Event ID: ";
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIdTextBox.Location = new System.Drawing.Point(102, 3);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(141, 30);
            this.eventIdTextBox.TabIndex = 44;
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEventButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteEventButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventButton.Location = new System.Drawing.Point(581, 352);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(203, 55);
            this.deleteEventButton.TabIndex = 43;
            this.deleteEventButton.Text = "Delete Event";
            this.deleteEventButton.UseVisualStyleBackColor = false;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(66, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Event Name: ";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTextBox.Location = new System.Drawing.Point(202, 65);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.ReadOnly = true;
            this.eventNameTextBox.Size = new System.Drawing.Size(329, 30);
            this.eventNameTextBox.TabIndex = 41;
            // 
            // diaryTextrichTextBox
            // 
            this.diaryTextrichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diaryTextrichTextBox.EnableAutoDragDrop = true;
            this.diaryTextrichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaryTextrichTextBox.Location = new System.Drawing.Point(71, 101);
            this.diaryTextrichTextBox.Name = "diaryTextrichTextBox";
            this.diaryTextrichTextBox.ReadOnly = true;
            this.diaryTextrichTextBox.Size = new System.Drawing.Size(460, 369);
            this.diaryTextrichTextBox.TabIndex = 40;
            this.diaryTextrichTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(581, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 177);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // importanceComboBox
            // 
            this.importanceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importanceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importanceComboBox.FormattingEnabled = true;
            this.importanceComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate ",
            "Less"});
            this.importanceComboBox.Location = new System.Drawing.Point(617, 31);
            this.importanceComboBox.Name = "importanceComboBox";
            this.importanceComboBox.Size = new System.Drawing.Size(167, 28);
            this.importanceComboBox.TabIndex = 1;
            this.importanceComboBox.Text = "Set Importance";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(537, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Firebrick;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(43, 18);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(872, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseButton);
            this.Name = "DeleteEvent";
            this.Text = "DeleteEvent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.RichTextBox diaryTextrichTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox importanceComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventIdTextBox;
    }
}