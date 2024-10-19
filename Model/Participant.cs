using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Model
{
    public class Participant: Person
    {
        //Constructor 
        public Participant(string username, string password, string name, string phoneNo, string role, int userID) : base (username, password, name, phoneNo, role, userID)
        {

        }

    }
}
