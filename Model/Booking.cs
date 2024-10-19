using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Model
{

    public class Booking
    {
        private int BookingID;
        private DateTime BookingDate;
        private int EventID;
        private int ParticipantID;

        //Constructor 
        public Booking(int eventID, int bookingID, DateTime bookingDate, int participantID)
        {
            this.EventID = eventID;
            this.BookingID = bookingID;
            this.BookingDate = bookingDate;
            this.ParticipantID = participantID; 
        }

        // Getters and Setters
        public int GetBookingID()
        {
            return BookingID;
        }

        public void SetBookingID(int bookingID)
        {
            this.BookingID = bookingID;
        }

        public int GetEventID()
        {
            return EventID;
        }

        public void SetEventID(int eventID)
        {
            this.EventID = eventID;
        }

        public DateTime GetBookingDate()
        {
            return BookingDate;
        }

        public void SetBookingDate(DateTime bookingDate)
        {
            this.BookingDate = bookingDate;
        }

        public int GetParticipantID()
        {
            return ParticipantID;
        }

        public void SetParticipantID(int participantID)
        {
            this.ParticipantID = participantID;
        }
    }
}
