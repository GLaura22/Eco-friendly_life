using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_friendly_life_winform.Database_Backend.Tables
{
    internal class IngRecRel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RelID { get; set; }
        // foreign key from Recipe
        public int RecipeID { get; set; }
        // foreign key from Ingredient
        public int IngredientID { get; set; } 
    }
}
