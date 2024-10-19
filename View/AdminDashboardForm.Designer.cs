namespace EventManagmentSystem.View
{
    partial class AdminDashboardForm
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
            event_Manager1 = new Event_Manager();
            logout_ = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label1 = new Label();
            manageBookings1 = new ManageBookings();
            manageParticipants1 = new ManageParticipants();
            manageOrganizer1 = new ManageOrganizer();
            eventManager2 = new EventManager();
            logout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Image = Properties.Resources.Logout;
            logout.Location = new Point(12, 767);
            logout.Name = "logout";
            logout.Size = new Size(68, 68);
            logout.SizeMode = PictureBoxSizeMode.Zoom;
            logout.TabIndex = 1;
            logout.TabStop = false;
            logout.Click += logout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(event_Manager1);
            panel1.Controls.Add(logout_);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 846);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // event_Manager1
            // 
            event_Manager1.Location = new Point(450, 40);
            event_Manager1.Name = "event_Manager1";
            event_Manager1.Size = new Size(3044, 1856);
            event_Manager1.TabIndex = 8;
            // 
            // logout_
            // 
            logout_.AutoSize = true;
            logout_.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_.Location = new Point(86, 779);
            logout_.Name = "logout_";
            logout_.Size = new Size(136, 40);
            logout_.TabIndex = 7;
            logout_.Text = "Sign Out";
            logout_.Click += logout__Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(79, 671);
            button4.Name = "button4";
            button4.Size = new Size(310, 66);
            button4.TabIndex = 6;
            button4.Text = "View Bookings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(79, 567);
            button3.Name = "button3";
            button3.Size = new Size(310, 66);
            button3.TabIndex = 5;
            button3.Text = "Manage Participants";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(79, 465);
            button2.Name = "button2";
            button2.Size = new Size(310, 66);
            button2.TabIndex = 4;
            button2.Text = "Manage Organizers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(79, 372);
            button1.Name = "button1";
            button1.Size = new Size(310, 66);
            button1.TabIndex = 3;
            button1.Text = "Manage Events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.admindashboard;
            pictureBox1.Location = new Point(79, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 257);
            label2.Name = "label2";
            label2.Size = new Size(214, 40);
            label2.TabIndex = 1;
            label2.Text = "Welcome,User";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, -18);
            panel3.Name = "panel3";
            panel3.Size = new Size(1783, 88);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1729, 27);
            label3.Name = "label3";
            label3.Size = new Size(39, 42);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(589, 59);
            label1.TabIndex = 0;
            label1.Text = "Event Managment System ";
            // 
            // manageBookings1
            // 
            manageBookings1.BackColor = SystemColors.ScrollBar;
            manageBookings1.Location = new Point(444, 70);
            manageBookings1.Name = "manageBookings1";
            manageBookings1.Size = new Size(2760, 1400);
            manageBookings1.TabIndex = 1;
            // 
            // manageParticipants1
            // 
            manageParticipants1.BackColor = SystemColors.ScrollBar;
            manageParticipants1.Location = new Point(443, 70);
            manageParticipants1.Name = "manageParticipants1";
            manageParticipants1.Size = new Size(2685, 1447);
            manageParticipants1.TabIndex = 2;
            manageParticipants1.Load += manageParticipants1_Load;
            // 
            // manageOrganizer1
            // 
            manageOrganizer1.BackColor = SystemColors.ScrollBar;
            manageOrganizer1.Location = new Point(443, 70);
            manageOrganizer1.Name = "manageOrganizer1";
            manageOrganizer1.Size = new Size(2633, 1445);
            manageOrganizer1.TabIndex = 3;
            manageOrganizer1.Load += manageOrganizer1_Load;
            // 
            // eventManager2
            // 
            eventManager2.BackColor = SystemColors.ScrollBar;
            eventManager2.Location = new Point(443, 69);
            eventManager2.Name = "eventManager2";
            eventManager2.Size = new Size(3084, 2076);
            eventManager2.TabIndex = 9;
            eventManager2.Load += eventManager2_Load;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1780, 916);
            Controls.Add(eventManager2);
            Controls.Add(manageOrganizer1);
            Controls.Add(manageParticipants1);
            Controls.Add(manageBookings1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            Text = "\\{\"[\\";
            Load += AdminDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox logout;
        private Label logout_;
        private ManageBookings manageBookings1;
        private ManageParticipants manageParticipants1;
        private ManageOrganizer manageOrganizer1;
        private EventManager eventManager1;
        private Event_Manager event_Manager1;
        private EventManager eventManager2;
    }
}