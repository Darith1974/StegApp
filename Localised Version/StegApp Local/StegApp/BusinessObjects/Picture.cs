using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4.BusinessObjects
{
    /*This class minics the table Picture in the database type for type and is used mainly in DataAccess.cs as type which can 
    * hold information retrieved from the Database or be used to store data to be saved to the Database. The enum PictureType
     * is used for the PictureTypeId in the Picture class. This relates to the table PictureType in the Database which does
     * not a need a class in this project.
    */
    public enum PictureType
    {
        Animals = 1,
        Earth = 2,
        Sea = 3,
        Sky = 4,
        General =5
    }

    public class Picture
    {
        public int PictureId { get; set; }
        public int PictureTypeId { get; set; }
        public string  PictureTypeDescription { get; set; }
        public string PictureName { get; set; }
        public byte[] PictureData { get; set; }
        public bool PictureStatus { get; set; }
    }
}