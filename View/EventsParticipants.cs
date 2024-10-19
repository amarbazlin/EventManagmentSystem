using EventManagmentSystem.Controller;
using EventManagmentSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventManagmentSystem.View;

namespace EventManagmentSystem.View
{
    public partial class EventsParticipants : UserControl
    {
        
       
        public EventsParticipants()
        {
            InitializeComponent();
            
        }


        private void dataGridView_events_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayEvents(dataGridView_events);

        }
        private void DisplayEvents(DataGridView dataGridView_events)
        {
            // Create a new database connection
            DbConnection dbConnection = new DbConnection();
            // SQL query to fetch all events from the "events" table
            string query = "SELECT EventID, EventName, Description, Venue, EventDate, OrganizerID, MaxParticipants FROM events";


            // Create a new MySqlCommand with the query and connection
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            try
            {

                // Use MySqlDataAdapter to execute the query and fill the result into a DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the query
                adapter.Fill(dataTable);

                // Set the DataGridView's DataSource to the DataTable, displaying the events
                dataGridView_events.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Check if EventID is entered and valid
                if (string.IsNullOrWhiteSpace(textEventID.Text) || Convert.ToInt32(textEventID.Text) == 0)
                {
                    MessageBox.Show("Please enter a valid EventID.");
                    return;
                }
                int eventID = Convert.ToInt32(textEventID.Text);

                // Get the logged-in user's ID
                int loggedInUserID = Person.LoggedInUser.GetUserID();

                // Try to add the booking using the manager method
                ParticipantManager.AddParticipantBooking(eventID, loggedInUserID);

                // If successful, show confirmation message
                MessageBox.Show("Booking added successfully.");
            }
           
            catch (Exception ex)
            {
                // Display any errors that occurred during the booking process
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EventsParticipants_Load(object sender, EventArgs e)
        {
            DisplayEvents(dataGridView_events);
        }

        private void dataGridView_events_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_events.Rows[e.RowIndex];

                textEventID.Text = row.Cells[0].Value.ToString();
    

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
