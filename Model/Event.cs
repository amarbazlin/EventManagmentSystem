using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Model
{
    public partial class Event
    {
        private int EventID;
        private string EventName;
        private string Description;
        private string Venue;
        private int OrganizerID;
        private string OrganizerName;
        private int MaxParticipants;
        private DateTime EventDate;

       
       //Constructor 
        public Event(int eventID, string eventName, string description, string venue, int organizerID, int maxParticipants, DateTime eventDate)
        {
            this.EventID = eventID;
            this.EventName = eventName;
            this.Description = description;
            this.Venue = venue;
            this.OrganizerID = organizerID;
            this.MaxParticipants = maxParticipants;
            this.EventDate = eventDate;

        }
        //Getters and setters
        public int GetEventID()
        {
            return EventID;
        }
        public string GetEventName()
        {
            return EventName;
        }
        public string GetEventDescription()
        {
            return Description;
        }
        public string GetEventVenue()
        {
            return Venue;
        }
        public int GetOrganizerID()
        {
            return OrganizerID;
        }
        public string GetOrganizerName()
        {
            return OrganizerName;
        }
        public int GetMaxParticipants()
        {

        return MaxParticipants; 
        
        }
        public DateTime GetEventDate()
        {
            return EventDate;
        }
        public void SetEventID(int eventID)
        {
            this.EventID = eventID;
        }
        public void SetEventName(string eventName)
        {
            this.EventName= eventName;
        }
        public void SetDescription(string description)
        {
            this.Description= description;
        }
        public void SetVenue(string venue)
        {
            this.Venue= venue;
        }
        public void SetOrganizerID(int organizerID)
        {
            this.OrganizerID= organizerID;
        }
        public void SetOrganizerName(string organizerName)
        {
            this.OrganizerName= organizerName;
        }
        public void SetMaxParticipants(int maxParticipants)
        {
            this.MaxParticipants= maxParticipants;
        }
        public void SetEventDate(DateTime eventDate)
        {
            this.EventDate= eventDate;
        }
    }
}
