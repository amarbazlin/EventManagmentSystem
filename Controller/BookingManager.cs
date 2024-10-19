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
    public class BookingManager
    {

        public static List<Booking> FetchBookings(string role, int userID)
        {
            List<Booking> bookingList = new List<Booking>();
            DbConnection dbConnection = new DbConnection();
            string query;

            // Check the user's role and adjust the query accordingly
            if (role == "Participant")
            {
                // If the user is a participant, fetch only their bookings
                query = "SELECT BookingID, EventID, ParticipantID, BookingDate FROM bookings WHERE ParticipantID=@ParticipantID";
            }
            else
            {
                // If the user is an admin or organizer, fetch all bookings
                query = "SELECT BookingID, EventID, ParticipantID, BookingDate FROM bookings";
            }

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            // Bind ParticipantID if the user is a participant
            if (role == "Participant")
            {
                cmd.Parameters.AddWithValue("@ParticipantID", userID);
            }

            try
            {
                // Open the database connection and execute the query
                dbConnection.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Loop through the results and populate the list of bookings
                while (reader.Read())
                {
                    Booking booking = new Booking(
                        Convert.ToInt32(reader["EventID"]),
                        Convert.ToInt32(reader["BookingID"]),
                        Convert.ToDateTime(reader["BookingDate"]),
                        Convert.ToInt32(reader["ParticipantID"])
                    );
                    bookingList.Add(booking); // Add the booking to the list
                }
            }
            catch (Exception ex)
            {
                // Catch and throw an exception with an appropriate error message
                throw new Exception("Error fetching bookings: " + ex.Message);
            }
            finally
            {
                // Always close the database connection
                dbConnection.CloseConnection();
            }

            return bookingList; // Return the list of bookings
        }

        public bool CancelBooking(int bookingID)
        {
            // Get the ID and role of the currently logged-in user
            int loggedInPersonID = Person.LoggedInUser.GetUserID();
            string loggedInUserRole = Person.LoggedInUser.GetRole();

            DbConnection dbConnection = new DbConnection();
            try
            {
                // Open the database connection
                dbConnection.OpenConnection();

                // Query to retrieve the ParticipantID and OrganizerID for the booking
                string query = @"SELECT b.ParticipantID, e.OrganizerID 
                         FROM bookings b 
                         JOIN events e ON b.EventID = e.EventID 
                         WHERE b.BookingID = @BookingID";

                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@BookingID", bookingID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // If the booking exists, read the ParticipantID and OrganizerID
                    if (reader.Read())
                    {
                        int bookingParticipantID = Convert.ToInt32(reader["ParticipantID"]);
                        int eventOrganizerID = Convert.ToInt32(reader["OrganizerID"]);

                        // Admin can cancel any booking, organizers can cancel their events' bookings,
                        // and participants can cancel their own bookings
                        if (loggedInUserRole == "Admin" ||
                            (loggedInUserRole == "Organizer" && eventOrganizerID == loggedInPersonID) ||
                            (loggedInUserRole == "Participant" && bookingParticipantID == loggedInPersonID))
                        {
                            reader.Close(); // Ensure the reader is closed before continuing
                            return BookingCancellation(bookingID); // Proceed with cancellation
                        }
                        else
                        {
                            // User does not have permission to cancel this booking
                            MessageBox.Show("You do not have permission to cancel this booking.");
                            return false;
                        }
                    }
                    else
                    {
                        // Booking not found
                        MessageBox.Show("Booking not found.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
            finally
            {
                // Always close the database connection
                dbConnection.CloseConnection();
            }
        }
        private bool BookingCancellation(int bookingID)
        {
            DbConnection dbConnection = new DbConnection();  // Create a new database connection instance
            try
            {
                // Open a new connection to the database
                dbConnection.OpenConnection();

                // Define the query to delete the booking by its BookingID
                string deleteQuery = "DELETE FROM bookings WHERE BookingID = @BookingID";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, dbConnection.GetConnection()))
                {
                    // Bind the BookingID parameter to the query
                    deleteCmd.Parameters.AddWithValue("@BookingID", bookingID);

                    // Execute the delete command
                    deleteCmd.ExecuteNonQuery();
                }

                // Notify that the booking was canceled successfully
                MessageBox.Show("Booking canceled successfully.");
                return true;
            }
            catch (Exception ex)
            {
                // If something goes wrong during cancellation, display an error message
                MessageBox.Show("An error occurred during cancellation: " + ex.Message);
                return false;
            }
            finally
            {
                // Always close the database connection
                dbConnection.CloseConnection();
            }
        }


    }
}
