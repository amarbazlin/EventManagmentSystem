using EventManagmentSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Controller
{
    public class ParticipantManager
    {
        // Method to add a new booking for a participant
        public static void AddParticipantBooking(int eventID, int participantID)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                // Open connection to the database
                dbConnection.OpenConnection();

                // Check if the event exists in the database
                string eventCheckQuery = "SELECT COUNT(*) FROM events WHERE EventID=@EventID";
                MySqlCommand eventCheckCmd = new MySqlCommand(eventCheckQuery, dbConnection.GetConnection());
                eventCheckCmd.Parameters.AddWithValue("@EventID", eventID);


                // Check if the participant has already booked the event
                string checkQuery = "SELECT COUNT(*) FROM bookings WHERE EventID=@EventID AND ParticipantID=@ParticipantID";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, dbConnection.GetConnection());
                checkCmd.Parameters.AddWithValue("@EventID", eventID);
                checkCmd.Parameters.AddWithValue("@ParticipantID", participantID);

                int bookingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (bookingCount > 0)
                {
                    // If the participant has already booked the event
                    throw new Exception("You have already booked this event.");
                }
                else
                {
                    // Insert a new booking record
                    string insertQuery = @"INSERT INTO bookings (EventID, ParticipantID, BookingDate) 
                                   VALUES (@EventID, @ParticipantID, CURDATE())";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, dbConnection.GetConnection());
                    insertCmd.Parameters.AddWithValue("@EventID", eventID);
                    insertCmd.Parameters.AddWithValue("@ParticipantID", participantID);

                    insertCmd.ExecuteNonQuery();

                    // Log success (you could return this info if needed)
                    Console.WriteLine("Booking added successfully.");
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, rethrow it with a more specific message
                throw new Exception("Error adding participant booking: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConnection.CloseConnection();
            }
        }

        // Method to fetch all participants from the database
        public static List<Participant> FetchParticipants()
        {
            DbConnection dbConnection = new DbConnection();
            string query = "SELECT PersonID, Username, Password, Name, PhoneNo, Role FROM person WHERE Role = 'Participant'";

            // Create a list to hold participant objects
            List<Participant> participantList = new List<Participant>();

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            try
            {
                // Open the database connection
                dbConnection.OpenConnection();

                // Execute the query to retrieve participants
                MySqlDataReader reader = cmd.ExecuteReader();

                // Loop through the result set and create Participant objects
                while (reader.Read())
                {
                    Participant participant = new Participant(
                        reader["Username"].ToString(),   // Participant's username
                        reader["Password"].ToString(),   // Participant's password
                        reader["Name"].ToString(),       // Participant's name
                        reader["PhoneNo"].ToString(),    // Participant's phone number
                        reader["Role"].ToString(),       // Role, which should be 'Participant'
                        Convert.ToInt32(reader["PersonID"]) // Participant's unique ID (PersonID)
                    );
                    // Add the participant to the list
                    participantList.Add(participant);
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, rethrow it with a more specific message
                throw new Exception("Error fetching participants: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConnection.CloseConnection();
            }

            // Return the list of participants
            return participantList;
        }

        // Method to delete a participant from the database
        public static void DeleteParticipant(int participantID)
        {
            DbConnection dbConnection = new DbConnection();
            try
            {
                // Open the database connection
                dbConnection.OpenConnection();

                // Query to delete the participant from the 'person' table based on the PersonID
                string deleteParticipantQuery = "DELETE FROM person WHERE PersonID=@PersonID";
                MySqlCommand deleteParticipantCmd = new MySqlCommand(deleteParticipantQuery, dbConnection.GetConnection());
                deleteParticipantCmd.Parameters.AddWithValue("@PersonID", participantID); // Bind participant ID to the query

                // Execute the delete query
                deleteParticipantCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If an exception occurs, rethrow it with a more specific message
                throw new Exception("An error occurred while deleting the participant: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConnection.CloseConnection();
            }
        }

    }
}
