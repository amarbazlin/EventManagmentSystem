using EventManagmentSystem.Interfaces_Contract_;
using EventManagmentSystem.Model;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagmentSystem.Controller
{
    internal class PersonManager : IUserAuthentication
    {

        public void AddUser(string username, string password, string name, string phoneNo, string role)
        {
            // Create a new DbConnection instance to connect to the database
            DbConnection dbConnection = new DbConnection();

            // SQL query to insert a new user into the 'person' table
            string query = "INSERT INTO person (Username,Password,Name, PhoneNo, Role) VALUES(@username, @pwd, @name, @phoneNo, @role)";

            // Create a MySqlCommand to execute the query
            MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());

            // Use parameterized queries to prevent SQL injection
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@pwd", password);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@phoneNo", phoneNo);
            command.Parameters.AddWithValue("@role", role);

            try
            {
                // Open the database connection
                dbConnection.OpenConnection();

                // Prepare the query to ensure it's executed correctly
                command.Prepare();

                // Execute the query to insert the new user
                command.ExecuteNonQuery();

                // Display a message box to inform the user of a successful registration
                MessageBox.Show("You are successfully registered.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Handle any errors, such as if the username already exists
                MessageBox.Show("Username already exists, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection 
                dbConnection.CloseConnection();
            }
        }
        //Authenticate the user
        public Person Authentication(string username, string password)
        {
            DbConnection dbConnection = new DbConnection();

            // Use parameterized query to prevent SQL injection
            string query = "SELECT * FROM person WHERE Username = @Username";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            cmd.Parameters.AddWithValue("@Username", username);  // Parameterized query to avoid SQL injection

            try
            {
                // Open the database connection
                dbConnection.OpenConnection();

                // Execute the query and retrieve data
                MySqlDataReader reader = cmd.ExecuteReader();

                // Validate the reader object
                if (reader.Read())
                {
                    // Retrieve the password from the database and compare it
                    string storedPassword = reader["Password"].ToString();

                    if (storedPassword == password)  // Simple password check; in production use hashed passwords
                    {
                        // If authenticated, retrieve the user details
                        int PersonID = int.Parse(reader["PersonID"].ToString());
                        string name = reader["Name"].ToString();
                        string role = reader["Role"].ToString();  // Retrieve the role (admin, organizer, or participant)
                        string phoneNo = reader["PhoneNo"].ToString();

                        // Create and return a new Person object with the retrieved data
                        Person person = new Person(username, password, name, phoneNo, role, PersonID);

                        Person.LoggedInUser = person;
                        return person;

                    }
                    else
                    {
                        // Password mismatch; return null
                        return null;
                    }
                }
                else
                {
                    // Username not found; return null
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions properly and inform the user
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the database connection is closed in the finally block
                dbConnection.CloseConnection();
            }

            return null;


        }
    }
}
