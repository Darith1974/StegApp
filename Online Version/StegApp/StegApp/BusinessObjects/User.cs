using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4.BusinessObjects
{
    /*This class minics the table User in the database type for type and is used mainly in DataAccess.cs as type which can 
    * hold information retrieved from the Database or be used to store data to be saved to the Database.
    */
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string MesageKey { get; set; }
    }
}