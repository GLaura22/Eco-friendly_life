using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_friendly_life_winform.Database_Backend.Tables
{
    internal class Person
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; } 
        // plusz otlet pontgyujteshez
        //public int Points { get; set; }
    }
}
