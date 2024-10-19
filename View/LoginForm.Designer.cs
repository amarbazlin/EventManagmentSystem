namespace EventManagmentSystem.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            password = new TextBox();
            LoginBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label8 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(407, 265);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 9);
            label1.Size = new Size(157, 68);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(242, 323);
            label2.Name = "label2";
            label2.Size = new Size(167, 37);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(242, 428);
            label3.Name = "label3";
            label3.Size = new Size(162, 37);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // username
            // 
            username.BackColor = SystemColors.ButtonHighlight;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Location = new Point(247, 366);
            username.Name = "username";
            username.Size = new Size(518, 39);
            username.TabIndex = 3;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.BackColor = SystemColors.ButtonHighlight;
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Location = new Point(247, 471);
            password.Name = "password";
            password.Size = new Size(518, 39);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Navy;
            LoginBtn.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(545, 546);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(220, 80);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.username;
            pictureBox1.Location = new Point(187, 365);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(193, 471);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(375, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(220, 192);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(242, 546);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(211, 36);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Remember Me";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(379, 43);
            button1.Name = "button1";
            button1.Size = new Size(220, 55);
            button1.TabIndex = 10;
            button1.Text = "Register Now ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(968, 11);
            label8.Name = "label8";
            label8.Size = new Size(44, 47);
            label8.TabIndex = 15;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-4, 654);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 112);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(335, 0);
            label4.Name = "label4";
            label4.Size = new Size(292, 32);
            label4.TabIndex = 11;
            label4.Text = "Haven't registered yet ?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(-28, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1062, 76);
            panel2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 3);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 9);
            label5.Size = new Size(577, 68);
            label5.TabIndex = 18;
            label5.Text = "Event Managment System";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(996, 764);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private Button LoginBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RadioButton radioButton1;
        private Button button1;
        private Label label8;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label5;
    }
}