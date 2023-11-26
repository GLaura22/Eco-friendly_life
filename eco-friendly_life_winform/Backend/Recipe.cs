using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_friendly_life_winform.Backend
{
    internal class Recipe
    {
        public int RecipeID { get; set; }
        public string DishName { get; set; }
        public string RecipeDescription { get; set; }

        /* foreign key from the Ingredients table */
        //public int IngredientID { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public double CarbonFootprint { get; set; }
        public bool ContainsMeat { get; set; }

        /* foreign key from the DishType table */
        public string DishTypeName { get; set; }
    }
}
