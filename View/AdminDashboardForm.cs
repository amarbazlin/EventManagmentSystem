using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventManagmentSystem.Controller;
using EventManagmentSystem.View;

namespace EventManagmentSystem.View
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            //redirects to the Login Form
            LoginForm LoginDashboard = new LoginForm();
            LoginDashboard.ShowDialog();

        }

        private void logout__Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            //redirects to the Login Form
            LoginForm LoginDashboard = new LoginForm();
            LoginDashboard.ShowDialog();

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.manageParticipants1.Visible = false;
            this.manageBookings1.Visible = false;
            this.manageOrganizer1.Visible = false;
            this.eventManager2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.manageParticipants1.Visible = false;
            this.manageBookings1.Visible = false;
            this.manageOrganizer1.Visible = true;
            this.eventManager2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.manageParticipants1.Visible = true;
            this.manageBookings1.Visible = false;
            this.manageOrganizer1.Visible = false;
            this.eventManager2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.manageParticipants1.Visible = false;
            this.manageBookings1.Visible = true;
            this.manageOrganizer1.Visible = false;
            this.eventManager2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageParticipants1_Load(object sender, EventArgs e)
        {

        }

        private void manageOrganizer1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eventManager1_Load(object sender, EventArgs e)
        {

        }
        private void event_Manager1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eventManager2_Load(object sender, EventArgs e)
        {

        }
    }
}
