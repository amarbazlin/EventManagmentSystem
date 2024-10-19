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
    public partial class ParticipantDashboardForm : Form
    {
        public ParticipantDashboardForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void ParticipantDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void eventsParticipants1_Load(object sender, EventArgs e)
        {

        }
        private void logout__Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            LoginForm LoginDashboard = new LoginForm();
            LoginDashboard.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            LoginForm LoginDashboard = new LoginForm();
            LoginDashboard.ShowDialog();

        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            LoginForm LoginDashboard = new LoginForm();
            LoginDashboard.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eventsParticipants1.Visible = true;
            this.manageBookings1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.eventsParticipants1.Visible = false;
            this.manageBookings1.Visible = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadUserData()
        {
            // Check if there's a logged-in user
            if (Person.LoggedInUser != null)
            {
                // Display the logged-in user's ID
                label1.Text = $"Welcome, {Person.LoggedInUser.GetName()}!";
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
