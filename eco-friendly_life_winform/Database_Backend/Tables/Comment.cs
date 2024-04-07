using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_friendly_life_winform.Database_Backend.Tables
{
    internal class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }
        public int Rating { get; set; }
        public int UserID {get; set;}
        public string MealID { get; set;}

        [Column(TypeName = "image")] // Specify the data type as "image" in SQL Server
        public byte[] MealImage { get; set; } // Store the image as byte array
    }
}
