namespace EventManagmentSystem.View
{
    partial class ParticipantDashboardForm
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
            PictureBox logout;
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            logout_ = new Label();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            manageBookings1 = new ManageBookings();
            eventsParticipants1 = new EventsParticipants();
            logout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Image = Properties.Resources.Logout;
            logout.Location = new Point(14, 726);
            logout.Name = "logout";
            logout.Size = new Size(68, 68);
            logout.SizeMode = PictureBoxSizeMode.Zoom;
            logout.TabIndex = 2;
            logout.TabStop = false;
            logout.Click += logout_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1716, 82);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1647, 17);
            label4.Name = "label4";
            label4.Size = new Size(39, 42);
            label4.TabIndex = 3;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(589, 59);
            label3.TabIndex = 1;
            label3.Text = "Event Managment System ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(logout_);
            panel2.Controls.Add(logout);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-2, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 814);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(339, 379);
            label6.Name = "label6";
            label6.Size = new Size(0, 41);
            label6.TabIndex = 11;
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 379);
            label2.Name = "label2";
            label2.Size = new Size(0, 40);
            label2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 335);
            label1.Name = "label1";
            label1.Size = new Size(46, 40);
            label1.TabIndex = 9;
            label1.Text = "W";
            label1.Click += label1_Click;
            // 
            // logout_
            // 
            logout_.AutoSize = true;
            logout_.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_.Location = new Point(97, 741);
            logout_.Name = "logout_";
            logout_.Size = new Size(136, 40);
            logout_.TabIndex = 8;
            logout_.Text = "Sign Out";
            logout_.Click += logout__Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(65, 566);
            button2.Name = "button2";
            button2.Size = new Size(310, 66);
            button2.TabIndex = 5;
            button2.Text = "View Bookings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(67, 437);
            button1.Name = "button1";
            button1.Size = new Size(310, 66);
            button1.TabIndex = 4;
            button1.Text = "Available Events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.event_manager_rgb_color_icon_vector_32173975_removebg_preview;
            pictureBox1.Location = new Point(64, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(121, 363);
            label5.Name = "label5";
            label5.Size = new Size(0, 40);
            label5.TabIndex = 2;
            label5.Click += label5_Click;
            // 
            // manageBookings1
            // 
            manageBookings1.BackColor = SystemColors.ScrollBar;
            manageBookings1.Location = new Point(424, 74);
            manageBookings1.Name = "manageBookings1";
            manageBookings1.Size = new Size(3180, 1967);
            manageBookings1.TabIndex = 2;
            // 
            // eventsParticipants1
            // 
            eventsParticipants1.BackColor = SystemColors.ScrollBar;
            eventsParticipants1.Location = new Point(424, 74);
            eventsParticipants1.Name = "eventsParticipants1";
            eventsParticipants1.Size = new Size(2976, 1835);
            eventsParticipants1.TabIndex = 9;
            eventsParticipants1.Load += eventsParticipants1_Load;
            // 
            // ParticipantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1696, 880);
            Controls.Add(eventsParticipants1);
            Controls.Add(manageBookings1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParticipantDashboardForm";
            Text = "ParticipantDashboardForm";
            Load += ParticipantDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label logout_;
        private ManageBookings manageBookings1;
        private EventsParticipants eventsParticipants1;
        private Label label1;
        private Label label6;
        private Label label2;
    }
}