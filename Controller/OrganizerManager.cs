using EventManagmentSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Controller
{
    internal class OrganizerManager
    {

        // Fetch all organizers from the database
        public static List<Organizer> FetchOrganizers()
        {
            // Create a list to hold Organizer objects
            List<Organizer> organizerList = new List<Organizer>();
            DbConnection dbConnection = new DbConnection();

            // SQL query to select organizers from the 'person' table where the role is 'Organizer'
            string query = "SELECT PersonID, Username, Password, Name, PhoneNo, Role FROM person WHERE Role = 'Organizer'";

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            try
            {
                // Open the database connection
                dbConnection.OpenConnection();

                // Execute the query and retrieve the result set
                MySqlDataReader reader = cmd.ExecuteReader();

                // Loop through the result set and create Organizer objects from the data
                while (reader.Read())
                {
                    Organizer organizer = new Organizer(
                        reader["Username"].ToString(),
                        reader["Password"].ToString(), 
                        reader["Name"].ToString(),    
                        reader["PhoneNo"].ToString(), 
                        reader["Role"].ToString(),     
                        Convert.ToInt32(reader["PersonID"]) 
                    );
                    // Add each organizer to the list
                    organizerList.Add(organizer);
                }
            }
            catch (Exception ex)
            {
                // Catch any exceptions and throw a new one with a more detailed error message
                throw new Exception("Error fetching organizers: " + ex.Message);
            }
            finally
            {
                // close the database connection
                dbConnection.CloseConnection();
            }

            // Return the list of organizers
            return organizerList;
        }

        public static void DeleteOrganizer(int organizerID)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                // Open the database connection
                dbConnection.OpenConnection();

                // Step 1: Delete all events associated with the organizer
                string deleteEventsQuery = "DELETE FROM events WHERE OrganizerID=@PersonID";
                MySqlCommand deleteEventsCmd = new MySqlCommand(deleteEventsQuery, dbConnection.GetConnection());
                deleteEventsCmd.Parameters.AddWithValue("@PersonID", organizerID); // Bind the organizer's ID to the query
                deleteEventsCmd.ExecuteNonQuery(); // Execute the query to delete events

                // Step 2: Delete the organizer from the 'person' table
                string deleteOrganizerQuery = "DELETE FROM person WHERE PersonID=@PersonID";
                MySqlCommand deleteOrganizerCmd = new MySqlCommand(deleteOrganizerQuery, dbConnection.GetConnection());
                deleteOrganizerCmd.Parameters.AddWithValue("@PersonID", organizerID); // Bind the organizer's ID to the query
                deleteOrganizerCmd.ExecuteNonQuery(); // Execute the query to delete the organizer
            }
            catch (Exception ex)
            {
                // Catch any exceptions and throw a new one with a detailed error message
                throw new Exception("Error deleting organizer: " + ex.Message);
            }
            finally
            {
                // close the database connection
                dbConnection.CloseConnection();
            }
        }
    }
}
