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

namespace EventManagmentSystem.View
{
    public partial class ManageOrganizer : UserControl
    {
        public ManageOrganizer()
        {
            InitializeComponent();
            dataGridView_organizer.Columns.Add("OrganizerID", "Organizer ID");
            dataGridView_organizer.Columns.Add("OrganizerName", "Organizer Name");
            dataGridView_organizer.Columns.Add("OrganizerPhone", "Organizer Phone");
            


        }
        private void DisplayEvents(DataGridView dataGridView_organizer)
        {
            try
            {
                List<Organizer> organizers = OrganizerManager.FetchOrganizers();

                // Bind the list of organizers to the DataGridView
                dataGridView_organizer.Rows.Clear();
                foreach (Organizer organizer in organizers)
                {
                    dataGridView_organizer.Rows.Add(organizer.GetUserID(), organizer.GetName(), organizer.GetPhoneNo());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageOrganizer_Load(object sender, EventArgs e)
        {
            DisplayEvents(dataGridView_organizer);

        }

        private void dataGridView_organizer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_organizer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that the clicked row is valid
            if (e.RowIndex != -1)
            {
                // Get the selected row in the DataGridView
                DataGridViewRow row = dataGridView_organizer.Rows[e.RowIndex];

                // Extract values from the selected row and set them into corresponding text fields
                organizer_id.Text = row.Cells[0].Value.ToString();
                organizer_name.Text = row.Cells[1].Value.ToString();
                organizer_phone_no.Text = row.Cells[2].Value.ToString();


            }
        }

        private void remove_organizer_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected in the DataGridView
            if (dataGridView_organizer.SelectedRows.Count > 0)
            {
                // Retrieve the selected OrganizerID from the first cell of the selected row
                int selectedOrganizerID = Convert.ToInt32(dataGridView_organizer.SelectedRows[0].Cells[0].Value);

                // Display a confirmation dialog to the user
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this organizer?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // If the user confirms the deletion (chooses "Yes")
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Call the OrganizerManager method to delete the selected organizer from the database
                        OrganizerManager.DeleteOrganizer(selectedOrganizerID);

                        // Show a success message
                        MessageBox.Show("Organizer deleted successfully.");

                        // Refresh the DataGridView to reflect the changes
                        DisplayEvents(dataGridView_organizer);
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                // If no organizer is selected
                MessageBox.Show("Please select an organizer to delete.");
            }
        }


    }
}
