using EventManagmentSystem.Controller;
using EventManagmentSystem.Interfaces_Contract_;
using EventManagmentSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EventManagmentSystem.View
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            IUserAuthentication personManagerInstance = new PersonManager();

            // Retrieve the entered username and password from the textboxes
            string enteredUsername = username.Text;
            string enteredPassword = password.Text;

            // Authenticate the user
            Person personObj = personManagerInstance.Authentication(enteredUsername, enteredPassword);

            if (personObj != null)
            {
                MessageBox.Show("Successfully Logged In");

                // Role-based redirection
                string role = personObj.Role;

                if (role == "Admin")
                {
                    // Admin user: Redirect to AdminDashboard
                    this.Hide();
                    AdminDashboardForm dashboard = new AdminDashboardForm();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else if (role == "Organizer")
                {
                    // Organizer: Redirect to OrganizerDashboard
                    this.Hide();
                    OrganizerDashboardForm organizerDashboard = new OrganizerDashboardForm();
                    organizerDashboard.ShowDialog();
                    this.Close();
                }
                else if (role == "Participant")
                {
                    // Participant: Redirect to ParticipantDashboard
                    this.Hide();
                    ParticipantDashboardForm participantDashboard = new ParticipantDashboardForm();
                    participantDashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid role detected.");
                }
            }
            else
            {
                // Invalid username or password
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form register = new Form1();
            register.ShowDialog();
            

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
