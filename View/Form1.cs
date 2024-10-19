
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
using EventManagmentSystem.Controller;
using EventManagmentSystem.View;

namespace EventManagmentSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string name = nametxt.Text;
            string phoneNo = phoneNotxt.Text;

            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNo))
            {
                MessageBox.Show("Please fill all the input fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop the process if any field is empty
            }

            // Validate that phoneNo contains only numeric values and is of correct length
            if (phoneNo.Length < 8 || phoneNo.Length > 10 || !phoneNo.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop the process if phone number is invalid
            }

            // Check if a role is selected
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop if role is not selected
            }

            string role = comboBox1.SelectedItem.ToString();

            // You can add additional validation for username here if needed

            // Create an instance of the manager class
            PersonManager personManager = new PersonManager();

            // Call the AddUser method
            personManager.AddUser(username, password, name, phoneNo, role);

            // Clear fields after successful addition
            usernametxt.Text = string.Empty;
            passwordtxt.Text = string.Empty;
            nametxt.Text = string.Empty;
            phoneNotxt.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginDashboard = new LoginForm();
            LoginDashboard.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
