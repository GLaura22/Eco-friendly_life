using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eco_friendly_life_winform.Database_Backend.Tables
{
    internal class DishType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DishTypeID { get; set; }
        public string DishTypeName {get; set;}
    }
}
