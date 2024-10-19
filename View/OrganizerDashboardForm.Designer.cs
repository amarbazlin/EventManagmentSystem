namespace EventManagmentSystem.View
{
    partial class OrganizerDashboardForm
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
            panel3 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            logout_ = new Label();
            button4 = new Button();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            manageBookings1 = new ManageBookings();
            eventManager2 = new EventManager();
            logout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Image = Properties.Resources.Logout;
            logout.Location = new Point(12, 727);
            logout.Name = "logout";
            logout.Size = new Size(68, 68);
            logout.SizeMode = PictureBoxSizeMode.Zoom;
            logout.TabIndex = 8;
            logout.TabStop = false;
            logout.Click += logout_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrange;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-81, -57);
            panel3.Name = "panel3";
            panel3.Size = new Size(1883, 132);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1792, 66);
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
            label1.Location = new Point(89, 61);
            label1.Name = "label1";
            label1.Size = new Size(589, 59);
            label1.TabIndex = 0;
            label1.Text = "Event Managment System ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(logout_);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 868);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 288);
            label4.Name = "label4";
            label4.Size = new Size(429, 100);
            label4.TabIndex = 10;
            label4.Text = "Welcome,";
            label4.Click += label4_Click;
            // 
            // logout_
            // 
            logout_.AutoSize = true;
            logout_.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_.Location = new Point(96, 740);
            logout_.Name = "logout_";
            logout_.Size = new Size(136, 40);
            logout_.TabIndex = 9;
            logout_.Text = "Sign Out";
            logout_.Click += logout__Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(49, 549);
            button4.Name = "button4";
            button4.Size = new Size(310, 70);
            button4.TabIndex = 7;
            button4.Text = "View Bookings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(49, 419);
            button1.Name = "button1";
            button1.Size = new Size(310, 72);
            button1.TabIndex = 4;
            button1.Text = "Manage Events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 276);
            label2.Name = "label2";
            label2.Size = new Size(0, 40);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.organizer;
            pictureBox1.Location = new Point(71, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // manageBookings1
            // 
            manageBookings1.BackColor = SystemColors.ScrollBar;
            manageBookings1.Location = new Point(433, 77);
            manageBookings1.Name = "manageBookings1";
            manageBookings1.Size = new Size(3086, 2073);
            manageBookings1.TabIndex = 3;
            manageBookings1.Load += manageBookings1_Load;
            // 
            // eventManager2
            // 
            eventManager2.BackColor = SystemColors.ScrollBar;
            eventManager2.Location = new Point(426, 75);
            eventManager2.Name = "eventManager2";
            eventManager2.Size = new Size(3119, 1919);
            eventManager2.TabIndex = 11;
            eventManager2.Load += eventManager2_Load;
            // 
            // OrganizerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1762, 890);
            Controls.Add(eventManager2);
            Controls.Add(manageBookings1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrganizerDashboardForm";
            Text = "OrganizerDashboardForm";
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button4;
        private Label logout_;
        private ManageBookings manageBookings1;
        private EventManager eventManager1;
        private Label label4;
        private EventManager eventManager2;
    }
}