using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CodingExcercise.Models
{
    //Represents User table with basic information about the user
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
