using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Model
{
    public partial class Person
    {
        public string Username;
        public string Password;
        private string Name;
        private string PhoneNo;
        public string Role;
        private int UserID;

        //Constructor 

        public Person(string username, string password, string name, string phoneNo, string role, int userID)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.Role = role;
            this.UserID = userID;

        }     

        //Getters and stters 
        public string GetUsername()
        {

        return Username;
        
        }
        public void SetUsername(string username) 
        { 
            this.Username = username;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetPhoneNo()
        {
            return PhoneNo;
        }
        public void SetPhoneNo(string phoneNo)
        {
            this.PhoneNo = phoneNo; 
        }
        public string GetRole()
        {
            return Role;
        }
        public void SetRole(string role)
        {
            this.Role = role;
        }
        public int GetUserID()
        {
            return UserID;
        }
        public void SetUserID(int userID)
        {
            this.UserID = userID;
        }

        public static Person LoggedInUser { get; set; }


    }
}
