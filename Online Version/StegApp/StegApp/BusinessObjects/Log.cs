using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4.BusinessObjects
{
    /*This class minics the table log in the database type for type and is used mainly in DataAccess.cs as type which can 
     * hold information retrieved from the Database or be used to store data to be saved to the Database.
     */
    public class Log
    {
        public int? UserId { get; set; }
        public int? LogId { get; set; }
        public DateTime SentDateTime { get; set; }
        public string MessageKey { get; set; }
        public int PictureId { get; set; }
        public int? EndUserID { get; set; }
    }
}