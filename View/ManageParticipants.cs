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
using EventManagmentSystem.Controller;
using EventManagmentSystem.Model;


namespace EventManagmentSystem.View
{
    public partial class ManageParticipants : UserControl
    {

        public ManageParticipants()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("ParticipantID", "Participant ID");
            dataGridView1.Columns.Add("ParticipantName", "Participant Name");
            dataGridView1.Columns.Add("ParticipantPhone", "Participant Phone");

        }
        private void DisplayEvents(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();

            try
            {
                // Fetch participants using the ParticipantManager class
                List<Participant> participants = ParticipantManager.FetchParticipants();

                // Populate DataGridView with the fetched participants
                foreach (var participant in participants)
                {
                    dataGridView1.Rows.Add(participant.GetUserID(), participant.GetName(), participant.GetPhoneNo());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ManageParticipants_Load(object sender, EventArgs e)
        {
            DisplayEvents(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that the clicked row is valid
            if (e.RowIndex != -1)
            {
                // Get the selected row in the DataGridView

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extract values from the selected row and set them into corresponding text fields

                participant_id.Text = row.Cells[0].Value.ToString();
                participant_name.Text = row.Cells[1].Value.ToString();
                participant_phone_no.Text = row.Cells[2].Value.ToString();


            }
        }

        private void remove_participant_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Retrieve the selected ParticpantID from the first cell of the selected row

                int selectedParticipantID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Display a confirmation dialog to the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this participant?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);


                // If the user confirms the deletion (chooses "Yes")

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Use the ParticipantManager to delete the participant
                        ParticipantManager.DeleteParticipant(selectedParticipantID);
                        MessageBox.Show("Participant deleted successfully.");

                        // Refresh the DataGridView to reflect changes
                        DisplayEvents(dataGridView1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the participant: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a participant to delete.");
            }
        }
    }

}
