using EventManagmentSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Controller
{
    internal class EventLogicManager
    {
        


        // Adds a new event to the database
        public static void AddEvent(Event eventObj)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                // Open database connection
                dbConnection.OpenConnection();

                // Check if the event name already exists
                string checkQuery = "SELECT COUNT(*) FROM events WHERE EventName = @EventName";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, dbConnection.GetConnection());
                checkCmd.Parameters.AddWithValue("@EventName", eventObj.GetEventName());// Bind the EventName parameter

                // Execute the query and get the count of events with the same name
                int eventCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                // If an event with the same name already exists, throw an exception
                if (eventCount > 0)
                {
                    throw new Exception("The event name that you are going to create already exists.");
                }

                // Insert the event if it doesn't exist
                string query = @"INSERT INTO events (EventName, Description, Venue, EventDate, OrganizerID, MaxParticipants) 
                         VALUES (@EventName, @Description, @Venue, @EventDate, @OrganizerID, @MaxParticipants)";

                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

                // Bind the parameters to the SQL query
                cmd.Parameters.AddWithValue("@EventName", eventObj.GetEventName());
                cmd.Parameters.AddWithValue("@Description", eventObj.GetEventDescription());
                cmd.Parameters.AddWithValue("@Venue", eventObj.GetEventVenue());
                cmd.Parameters.AddWithValue("@EventDate", eventObj.GetEventDate().ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@OrganizerID", eventObj.GetOrganizerID());
                cmd.Parameters.AddWithValue("@MaxParticipants", eventObj.GetMaxParticipants());

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Catch any exceptions and throw a new exception with the error message
                throw new Exception(ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConnection.CloseConnection();
            }
        }

        // Updates an existing event in the database
        public static void EditEvent(Event eventObj)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                // Open database connection
                dbConnection.OpenConnection();

                // Prepare the SQL query to update the event based on EventID
                string query = @"UPDATE events 
                                 SET EventName=@EventName, Description=@Description, Venue=@Venue, EventDate=@EventDate, OrganizerID=@OrganizerID, MaxParticipants=@MaxParticipants 
                                 WHERE EventID=@EventID";

                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

                // Bind the parameters to the SQL query
                cmd.Parameters.AddWithValue("@EventName", eventObj.GetEventName());
                cmd.Parameters.AddWithValue("@Description", eventObj.GetEventDescription());
                cmd.Parameters.AddWithValue("@Venue", eventObj.GetEventVenue());
                cmd.Parameters.AddWithValue("@EventDate", eventObj.GetEventDate().ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@OrganizerID", eventObj.GetOrganizerID());
                cmd.Parameters.AddWithValue("@MaxParticipants", eventObj.GetMaxParticipants());
                cmd.Parameters.AddWithValue("@EventID", eventObj.GetEventID());

                // Execute the update command
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If there is an error during update, throw an exception with a meaningful message
                throw new Exception("Error updating event: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConnection.CloseConnection();
            }
        }

        // Deletes an event from the database
        public static void DeleteEvent(int eventID)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                // Open database connection
                dbConnection.OpenConnection();

                // Prepare the SQL query to delete the event based on EventID
                string query = "DELETE FROM events WHERE EventID=@EventID";

                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

                // Bind the EventID parameter to the query
                cmd.Parameters.AddWithValue("@EventID", eventID);

                // Execute the delete command
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If there is an error during deletion, throw an exception with a meaningful message
                throw new Exception("Error deleting event: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConnection.CloseConnection();
            }
        }

    }
}
