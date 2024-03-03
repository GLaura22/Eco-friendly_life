using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eco_friendly_life_winform.Database_Backend.Connection;
using eco_friendly_life_winform.Database_Backend.Tables;

namespace eco_friendly_life_winform.Database_Backend.Controllers
{
    internal class IngredientController
    {
        internal List<Tables.Ingredient> GetItems()
        {
            using (var context = new AppDbContext())
            {
                var ingredients = context.Ingredients.ToList();
                return ingredients;
            }
        }
    }
}
