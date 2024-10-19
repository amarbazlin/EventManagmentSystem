using EventManagmentSystem.Controller;
using EventManagmentSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagmentSystem.View
{
    public partial class ManageBookings : UserControl
    {
        private BookingManager bookingManager;
        public ManageBookings()
        {
            InitializeComponent();
            dataGridView_book.Columns.Add("BookingID", "Booking ID");
            dataGridView_book.Columns.Add("EventID","Event ID");
            dataGridView_book.Columns.Add("BookingDate", "Booking Date");
            dataGridView_book.Columns.Add("ParticipantID", "Participant ID");

            bookingManager = new BookingManager();
        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {
            DisplayBookings();
        }
   

        public void DisplayBookings()
        {
            try
            {
                // Fetch the logged-in user's role and ID
                string role = Person.LoggedInUser.GetRole();
                int userID = Person.LoggedInUser.GetUserID();

                // Fetch bookings based on the user's role and ID
                List<Booking> bookings = BookingManager.FetchBookings(role, userID);

                // Clear the DataGridView before adding new rows
                dataGridView_book.Rows.Clear();

                // Add each booking to the DataGridView
                foreach (Booking booking in bookings)
                {
                    dataGridView_book.Rows.Add(
                        booking.GetBookingID(),
                        booking.GetEventID(),
                        booking.GetBookingDate().ToString("yyyy-MM-dd"),
                        booking.GetParticipantID()
                    );
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void cancel_booking_Click(object sender, EventArgs e)
        {
            if (dataGridView_book.SelectedRows.Count > 0)
            {
                int selectedBookingID = Convert.ToInt32(dataGridView_book.SelectedRows[0].Cells["BookingID"].Value);

                // Call CancelBooking and handle the result
                bool isCanceled = bookingManager.CancelBooking(selectedBookingID);


                if (isCanceled)
                {
                    // Optionally refresh the DataGridView to reflect the changes
                    DisplayBookings();  // Assuming this method refreshes the bookings in the DataGridView
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to cancel.");
            }
        }

        private void dataGridView_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
