using EventManagmentSystem.Controller;
using EventManagmentSystem.Model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventManagmentSystem.View
{
    public partial class EventManager : UserControl
    {
        public EventManager()
        {
            InitializeComponent();
            DisplayEvents(dataGridView_events);// Display events in the DataGridView when the form loads
        }

        private void EventManager_Load(object sender, EventArgs e)
        {

            DisplayEvents(dataGridView_events);
            //check the logged in user is a organizer or admin 
            if (Person.LoggedInUser != null && Person.LoggedInUser.GetRole() == "Organizer")
            {
                textOrganizerID.Text = Person.LoggedInUser.GetUserID().ToString();
                textOrganizerID.ReadOnly = true; // Organizers can't change their Organizer ID
            }
            else
            {
                textOrganizerID.ReadOnly = false; // Admin can edit the Organizer ID
            }
        }

        private void DisplayEvents(DataGridView dataGridView_events)
        {
            DbConnection dbConnection = new DbConnection();
            string query;

            // Check if the user is an organizer or admin
            if (Person.LoggedInUser != null && Person.LoggedInUser.GetRole() == "Organizer")
            {
                query = "SELECT EventID, EventName, Description, Venue, EventDate, OrganizerID, MaxParticipants FROM events WHERE OrganizerID=@OrganizerID";
            }
            else
            {
                // Admin can see all events
                query = "SELECT EventID, EventName, Description, Venue, EventDate, OrganizerID, MaxParticipants FROM events";
            }

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            if (Person.LoggedInUser != null && Person.LoggedInUser.GetRole() == "Organizer")
            {
                cmd.Parameters.AddWithValue("@OrganizerID", Person.LoggedInUser.GetUserID());
            }

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
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
                // Check if any required fields are missing
                if (string.IsNullOrWhiteSpace(textEventName.Text) ||
                    string.IsNullOrWhiteSpace(textDescription.Text) ||
                    string.IsNullOrWhiteSpace(textVenue.Text) ||
                    string.IsNullOrWhiteSpace(textOrganizerID.Text) ||
                    string.IsNullOrWhiteSpace(textMaxParticipants.Text))
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                DateTime selectedDate = dateTimePicker1.Value;
                if (selectedDate < DateTime.Now.Date)
                {
                    MessageBox.Show("The event date you have entered is a past date.");
                    return; // Stop the process if the date is invalid
                }
                // Create a new event object
                Event newEvent = new Event(
                    0, // EventID will be auto-incremented in DB
                    textEventName.Text,
                    textDescription.Text,
                    textVenue.Text,
                    Convert.ToInt32(textOrganizerID.Text),
                    Convert.ToInt32(textMaxParticipants.Text),
                    selectedDate
                );
                // Add the new event to the database
                EventLogicManager.AddEvent(newEvent);
                MessageBox.Show("Record entered successfully");

                DisplayEvents(dataGridView_events);// Refresh the event list

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("OrganizerID"))
                {
                    MessageBox.Show("The OrganizerID you entered does not exist. Please enter a valid OrganizerID.");
                }


                else
                {
                    // Display any other errors that might occur
                    MessageBox.Show("Error adding event: " + ex.Message);
                }
            }
        }


        private void clear_Click(object sender, EventArgs e)
        {
            textEventName.Clear();
            textDescription.Clear();
            textVenue.Clear();
            textOrganizerID.Clear();
            textMaxParticipants.Clear();
            dateTimePicker1.Value = DateTime.Now;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                // Same validation as in the add event method
                if (string.IsNullOrWhiteSpace(textEventName.Text) ||
                    string.IsNullOrWhiteSpace(textDescription.Text) ||
                    string.IsNullOrWhiteSpace(textVenue.Text) ||
                    string.IsNullOrWhiteSpace(textOrganizerID.Text) ||
                    string.IsNullOrWhiteSpace(textMaxParticipants.Text) ||
                    string.IsNullOrWhiteSpace(eventID.Text))
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                // Create an updated event object
                Event updatedEvent = new Event(
                    Convert.ToInt32(eventID.Text),
                    textEventName.Text,
                    textDescription.Text,
                    textVenue.Text,
                    Convert.ToInt32(textOrganizerID.Text),
                    Convert.ToInt32(textMaxParticipants.Text),
                    dateTimePicker1.Value
                );
                // Update the event
                EventLogicManager.EditEvent(updatedEvent);
                MessageBox.Show("Event updated successfully.");
                DisplayEvents(dataGridView_events);// Refresh the list
            }
            catch (Exception ex)
            {
                //Check if the entered OrganizerID exists
                if (ex.Message.Contains("OrganizerID"))
                {
                    MessageBox.Show("The OrganizerID you entered does not exist. Please enter a valid OrganizerID.");
                }
                
                
                else
                {
                    
                    MessageBox.Show("Error adding event: " + ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView_events.SelectedRows.Count > 0)
            {
                // Get the EventID and OrganizerID of the selected event
                int selectedEventID = Convert.ToInt32(dataGridView_events.SelectedRows[0].Cells[0].Value);
                int selectedOrganizerID = Convert.ToInt32(dataGridView_events.SelectedRows[0].Cells[5].Value);

                // Check if the logged-in user is either an Admin or the Organizer of the event
                if (Person.LoggedInUser != null &&
                    (Person.LoggedInUser.GetRole() == "Admin" || Person.LoggedInUser.GetUserID() == selectedOrganizerID))
                {
                    // Ask the user for confirmation before deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this event?",
                                                          "Confirm Deletion",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    // If the user confirms deletion, proceed
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Call EventLogicManager to delete the event from the database
                            EventLogicManager.DeleteEvent(selectedEventID);

                            MessageBox.Show("Event deleted successfully.");

                            // Refresh the events list
                            DisplayEvents(dataGridView_events);
                        }
                        catch (Exception ex)
                        {
                           
                            MessageBox.Show("Error deleting event: " + ex.Message);
                        }
                    }
                }
                else
                {
                    // If the user doesn't have permission to delete the event, show an error message
                    MessageBox.Show("You do not have permission to delete this event.");
                }
            }
            else
            {
                
                MessageBox.Show("Please select an event to delete.");
            }
        }



        private void dataGridView_events_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_events_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView_events_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that the clicked row is valid
            if (e.RowIndex != -1)
            {
                // Get the selected row in the DataGridView
                DataGridViewRow row = dataGridView_events.Rows[e.RowIndex];

                // Extract values from the selected row and set them into corresponding text fields

                eventID.Text = row.Cells[0].Value.ToString();
                textEventName.Text = row.Cells[1].Value.ToString();
                textDescription.Text = row.Cells[2].Value.ToString();
                textVenue.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                textOrganizerID.Text = row.Cells[5].Value.ToString();
                textMaxParticipants.Text = row.Cells[6].Value.ToString();


            }
        }

        private void dataGridView_events_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textOID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textOrganizerID_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
