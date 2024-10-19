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
    public partial class OrganizerDashboardForm : Form
    {


        public OrganizerDashboardForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.manageBookings1.Visible = true;
            this.eventManager2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.manageBookings1.Visible = false;
            this.eventManager2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadUserData()
        {
            // Check if there's a logged-in user
            if (Person.LoggedInUser != null)
            {
                // Display the logged-in user's ID
                label4.Text = $"Welcome, {Person.LoggedInUser.GetName()}!";

            }
        }
        private void manageBookings1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void eventManager2_Load(object sender, EventArgs e)
        {

        }
    }
}
